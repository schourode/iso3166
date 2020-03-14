/*
 * ISO 3166-1 country codes
 *
 * Last check against the official ISO 3166 as on https://www.iso.org/obp/ui/#search: 8th January 2020.
 */
using System;
using System.Globalization;

namespace ISO3166
{
    public partial class Country
    {
        /// <summary>
        /// Gets the localized country name in the specified culture. Or, if the country name was not translated to the specified culture,
        /// returns the default english name. This method always returns something.
        /// </summary>
        public string GetCountryName(CultureInfo cultureInfo)
        {
            if (TryGetCountryName(cultureInfo, out var result))
            {
                return result;
            }

            return Name;
        }

        /// <summary>
        /// Tries to get the localized country name in the specified culture.
        /// Returns true and sets the result out parameter if the country name was translated,
        /// otherwise returns false.
        /// </summary>
        public bool TryGetCountryName(CultureInfo cultureInfo, out string result)
        {
            if (string.IsNullOrEmpty(cultureInfo.Name))
            {
                // Invariant culture
                result = Name;
                return true;
            }

            var cultureCode = cultureInfo.Name.Replace("-", "_");
            if (CountryNames.CultureCountryNameIndex.TryGetValue(cultureCode, out var countryNameIndex))
            {
                if (countryNameIndex.TryGetValue(TwoLetterCode, out var countryIndex))
                {
                    result = CountryNames.CultureCountryNames[countryIndex];
                    return true;
                }
            }

            if (CountryNames.CultureCountryNameIndex.TryGetValue(cultureInfo.TwoLetterISOLanguageName, out var neutralCountryNameIndex))
            {
                if (neutralCountryNameIndex.TryGetValue(TwoLetterCode, out var countryIndex))
                {
                    result = CountryNames.CultureCountryNames[countryIndex];
                    return true;
                }
            }

            result = null;
            return false;
        }
    }
}
