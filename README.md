#ISO 3166-1 country codes
 
Data source: http://en.wikipedia.org/wiki/ISO_3166-1
License: http://creativecommons.org/licenses/by-sa/3.0/


##Example of usage:

```c#
Country[] allCountries = Country.List;
Console.WriteLine("{0};{1};{2};{3}",
  allCountries[0].TwoLetterCode,
  allCountries[0].ThreeLetterCode,
  allCountries[0].Name,
  allCountries[0].NumericCode);
Country greatBritain = Country.FindBy2Code("GB");
Country france = Country.FindBy3Code("FRA");
```

The output is:
```
AF;AFG;Afghanistan;004
```