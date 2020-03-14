using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IcuDump
{
    class Program
    {
        const string CldrUrl = "http://unicode.org/Public/cldr/36.1/cldr-common-36.1.zip";

        static async Task<int> Main(string[] args)
        {
            string outPath;
            if (args.Length == 0)
            {
                outPath = Directory.GetCurrentDirectory();
            }
            else if (args.Length == 1)
            {
                outPath = args[0];
                if (!Directory.Exists(outPath))
                {
                    Console.WriteLine("Directory does not exist: " + outPath);
                    return 2;
                }
            }
            else
            {
                Console.WriteLine("Expected zero or one argument with output directory");
                return 1;
            }

            var baseFileName = Path.GetFileName(CldrUrl);
            if (!File.Exists(baseFileName))
            {
                Console.WriteLine($"Downloading {CldrUrl}...");
                var httpClient = new HttpClient();
                var bytes = await httpClient.GetByteArrayAsync(CldrUrl);
                File.WriteAllBytes(baseFileName, bytes);
            }

            Console.WriteLine($"Reading {baseFileName}...");

            using (var zip = new ZipArchive(new FileStream(baseFileName, FileMode.Open, FileAccess.Read)))
            {
                InitializeCldr(zip, out var countryCultures, out var countryNames);

                Console.WriteLine($"Writing CountryNames.cs...");

                var result = new StringBuilder();
                result.AppendLine($"// Automatically generated from CLDR {CldrUrl}");
                result.AppendLine($"// http://cldr.unicode.org/");
                result.AppendLine();
                result.AppendLine("using System.Collections.Generic;");
                result.AppendLine();
                result.AppendLine("namespace ISO3166");
                result.AppendLine("{");
                result.AppendLine("    internal static class CountryNames");
                result.AppendLine("    {");

                SerializeCountryNames(countryNames, result);
                result.AppendLine();
                SerializeCultureCountryNameIndex(countryCultures, result);

                result.AppendLine("    }");
                result.AppendLine("}");

                File.WriteAllText(Path.Combine(outPath, "CountryNames.cs"), result.ToString());
            }

            Console.WriteLine($"Done!");

            return 0;
        }

        static void InitializeCldr(ZipArchive zip, out Dictionary<string, Dictionary<string, int>> countryCultures, out List<string> countryNames)
        {
            var countryCodes = ISO3166.Country.List.Select(l => l.TwoLetterCode).ToList(); // GetCountryCodes();
            countryCultures = new Dictionary<string, Dictionary<string, int>>();
            countryNames = new List<string>();

            // Temp index of country name -> index into `countryNames`
            var countryNameIndex = new Dictionary<string, int>();

            foreach (var zipEntry in zip.Entries)
            {
                if (!zipEntry.FullName.StartsWith("common/main/") || zipEntry.FullName.EndsWith("/"))
                {
                    continue;
                }

                using (var zipStrm = zipEntry.Open())
                {
                    var xml = new XmlDocument();
                    xml.Load(zipStrm);

                    var identityLanguageNode = (XmlElement)xml.DocumentElement.SelectSingleNode("identity/language");
                    var identityTerritoryNode = (XmlElement)xml.DocumentElement.SelectSingleNode("identity/territory");
                    var identityScriptNode = (XmlElement)xml.DocumentElement.SelectSingleNode("identity/script");
                    var identityVariantNode = (XmlElement)xml.DocumentElement.SelectSingleNode("identity/variant");

                    var territoryNodes = xml.DocumentElement.SelectNodes("localeDisplayNames/territories/territory");

                    var identityLanguageCode = identityLanguageNode.GetAttribute("type");
                    var identityCountryCode = identityTerritoryNode?.GetAttribute("type");
                    var identityScriptCode = identityScriptNode?.GetAttribute("type");
                    var identityVariantCode = identityVariantNode?.GetAttribute("type");

                    var loc = identityLanguageCode;
                    if (!string.IsNullOrEmpty(identityScriptCode))
                    {
                        loc += "_" + identityScriptCode;
                    }

                    if (!string.IsNullOrEmpty(identityCountryCode))
                    {
                        loc += "_" + identityCountryCode;
                    }

                    if (!string.IsNullOrEmpty(identityVariantCode))
                    {
                        loc += "_" + identityVariantCode;
                    }

                    if (loc == "root")
                    {
                        continue;
                    }

                    if (!IsValidDotNetLocale(loc))
                    {
                        continue;
                    }

                    var countryKeyIndex = new Dictionary<string, int>();
                    var cultureInfo = CultureInfo.GetCultureInfo(loc);

                    var locParts = loc.Split("_");

                    var isNeutral = locParts.Length == 1;
                    if (loc == "fa_AF")
                    {
                        // .NET normalizes "fa_AF" to "prs_AF", but retains "fa" -> "fa". Alias as neutral culture for "prs":
                        isNeutral = true;
                        countryCultures.Add("prs", countryKeyIndex);
                    }
                    else if (locParts[0] == "ckb" || locParts[0] == "zu")
                    {
                        // Skip "ckb", .NET overrides with "ku", which also exists in CLDR
                        // Skip "zu", the data is bogus (all names are just english prefixed with "i-")
                        continue;
                    }

                    var neutralCultureCode = cultureInfo.TwoLetterISOLanguageName;
                    var neutralCulture = !isNeutral ? countryCultures[neutralCultureCode] : null;

                    foreach (XmlElement territoryNode in territoryNodes)
                    {
                        var alt = territoryNode.GetAttribute("alt");
                        if (!string.IsNullOrEmpty(alt))
                        {
                            // Skip any alternate variations
                            continue;
                        }

                        var countryCode = territoryNode.GetAttribute("type");
                        if (!countryCodes.Contains(countryCode))
                        {
                            // Skip continents etc
                            continue;
                        }

                        var countryNameInLanguage = territoryNode.InnerText;
                        if (!countryNameIndex.TryGetValue(countryNameInLanguage, out var countryIndex))
                        {
                            countryIndex = countryNames.Count;
                            countryNames.Add(countryNameInLanguage);
                            countryNameIndex.Add(countryNameInLanguage, countryIndex);
                        }

                        // Omit if the name is the same in the neutral language
                        if (isNeutral || neutralCulture[countryCode] != countryIndex)
                        {
                            countryKeyIndex.Add(countryCode, countryIndex);
                        }
                    }

                    if (countryKeyIndex.Count > 0)
                    {
                        countryCultures.Add(cultureInfo.Name, countryKeyIndex);
                    }
                }
            }
        }

        static void SerializeCountryNames(List<string> countryNames, StringBuilder writer)
        {
            writer.Append("        public static List<string> CultureCountryNames { get; set; } = ");

            writer.AppendLine("new List<string>()");
            writer.AppendLine("        {");

            var itemsPerLine = 0;
            var maxItemsPerLine = 10;

            foreach (var item in countryNames)
            {
                if (itemsPerLine == 0)
                {
                    writer.Append("            ");
                }

                writer.Append($"\"{item}\"");
                writer.Append(",");

                itemsPerLine++;
                if (itemsPerLine == maxItemsPerLine)
                {
                    writer.AppendLine();
                    itemsPerLine = 0;
                }
                else
                {
                    writer.Append(" ");
                }
            }

            if (itemsPerLine < maxItemsPerLine)
            {
                writer.AppendLine();
            }

            writer.AppendLine("        };");
        }

        static void SerializeCultureCountryNameIndex(Dictionary<string, Dictionary<string, int>> countryCultures, StringBuilder result)
        {
            result.AppendLine("        public static Dictionary<string, Dictionary<string, int>> CultureCountryNameIndex { get; set; } = new Dictionary<string, Dictionary<string, int>>()");
            result.AppendLine("        {");

            foreach (var countryCulture in countryCultures)
            {
                result.AppendLine("            {");
                result.AppendLine($"                \"{countryCulture.Key}\", new Dictionary<string, int>()");
                result.AppendLine("                {");

                var itemsPerLine = 0;
                var maxItemsPerLine = 10;
                foreach (var cc in countryCulture.Value)
                {
                    if (itemsPerLine == 0)
                    {
                        result.Append("                    ");
                    }

                    result.Append($"{{ \"{cc.Key}\", {cc.Value} }},");
                    itemsPerLine++;
                    if (itemsPerLine == maxItemsPerLine)
                    {
                        result.AppendLine();
                        itemsPerLine = 0;
                    }
                    else
                    {
                        result.Append(" ");
                    }
                }

                if (itemsPerLine < maxItemsPerLine)
                {
                    result.AppendLine();
                }

                result.AppendLine("                }");
                result.AppendLine("            },");
            }
            result.AppendLine("        };");
        }

        static bool IsValidDotNetLocale(string locale)
        {
            try
            {
                CultureInfo.GetCultureInfo(locale);
                return true;
            }
            catch (CultureNotFoundException)
            {
            }

            return false;
        }
    }
}
