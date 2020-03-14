ISO 3166-1 Country List
=======================

[![Build status](https://ci.appveyor.com/api/projects/status/ta4hrrhat5fburmo/branch/master?svg=true)](https://ci.appveyor.com/project/andersnm/iso3166/branch/master)

## Install via NuGet

If you want to include ISO3166 in your project, you can [install it directly from NuGet](https://www.nuget.org/packages/ISO3166)

To install ISO3166, run the following command in the Package Manager Console

```
PM> Install-Package ISO3166
```

## Usage

```c#
Country[] countries = ISO3166.Country.List;

// Print the English and Norwegian nynorsk name of every country:
foreach (var country in countries) {
    Console.WriteLine($"{country.Name} {country.GetCountryName(CultureInfo.GetCulture("nn-NO"))}");
}
```

## Country Model

```c#
public string Name { get; private set; }
public string TwoLetterCode { get; private set; }
public string ThreeLetterCode { get; private set; }
public string NumericCode { get; private set; }

public string GetCountryName(CultureInfo cultureInfo);
public bool TryGetCountryName(CultureInfo cultureInfo, out string result);

public static readonly Country[] List = new[] {...};
```

Last check against the official ISO 3166 as on https://www.iso.org/obp/ui/#search: 8th January 2020

Localized country names from CLDR v36.1 http://cldr.unicode.org/

License: MIT
