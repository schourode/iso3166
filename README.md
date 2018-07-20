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

```
Country[] countries = ISO3166.Country.List;
```

## Country Model

```
public string Name { get; private set; }
public string TwoLetterCode { get; private set; }
public string ThreeLetterCode { get; private set; }
public string NumericCode { get; private set; }

public static readonly Country[] List = new[] {...};
```

Data source: http://en.wikipedia.org/wiki/ISO_3166-1

License: CC BY-SA 3.0