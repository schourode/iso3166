ISO 3166-1 Country List
=======================

[![Build status](https://ci.appveyor.com/api/projects/status/4llq6n8yywh4umes/branch/master?svg=true)](https://ci.appveyor.com/project/schourode/iso3166/branch/master)
[![NuGet Release](https://img.shields.io/nuget/v/ISO3166.svg)](https://www.nuget.org/packages/ISO3166)

## Install via NuGet

If you want to include ISO3166 in your project, you can [install it directly from NuGet](https://www.nuget.org/packages/ISO3166)

To install ISO3166, run the following command in the Package Manager Console

```
PM> Install-Package ISO3166
```

## Usage

```c#
Country[] countries = ISO3166.Country.List;
```

## Country Model

```c#
public string Name { get; private set; }
public string TwoLetterCode { get; private set; }
public string ThreeLetterCode { get; private set; }
public string NumericCode { get; private set; }

public static readonly Country[] List = new[] {...};
```

Last check against the official ISO 3166 as on https://www.iso.org/obp/ui/#search: 8th January 2020

License: MIT
