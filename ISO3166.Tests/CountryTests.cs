using System;
using System.Globalization;
using NUnit.Framework;

namespace ISO3166.Tests
{
    [TestFixture]
    public class CountryTests
    {
        [Test]
        public void CountryListNonBogus()
        {
            Assert.IsNotNull(Country.List.Length, "Country list is non-null");
            Assert.Greater(Country.List.Length, 50, "Country list is non-empty");

            foreach (var country in Country.List)
            {
                Assert.IsNotNull(country.Name);
                Assert.IsNotNull(country.NumericCode);
                Assert.IsNotNull(country.ThreeLetterCode);
                Assert.IsNotNull(country.TwoLetterCode);

                Assert.IsNotEmpty(country.Name);
                Assert.IsNotEmpty(country.NumericCode);
                Assert.IsNotEmpty(country.ThreeLetterCode);
                Assert.IsNotEmpty(country.TwoLetterCode);
            }
        }

        [Test]
        public void AllCulturesNotNullOrEmpty()
        {
            // This prints any missing country localizations to the test runner log
            foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                foreach (var country in Country.List)
                {
                    if (!country.TryGetCountryName(culture, out var countryName))
                    {
                        Console.WriteLine($"{country.TwoLetterCode} {country.Name} does not exist in culture {culture.Name}");
                        continue;
                    }

                    Assert.False(string.IsNullOrEmpty(countryName), $"{country.Name} should not be null or empty in culture {culture.Name}");
                }
            }
        }

        [Test]
        public void AllCulturesWithFallback()
        {
            foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                foreach (var country in Country.List)
                {
                    var countryName = country.GetCountryName(culture);
                    Assert.False(string.IsNullOrEmpty(countryName), "countryName should not be empty");
                }
            }
        }
    }
}
