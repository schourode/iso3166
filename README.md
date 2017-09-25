ISO 3166-1 Country List
=======================
Usage:
```
Country[] countries = ISO3166.Country.List;
```

Country Model:
```
public string Name { get; private set; }
public string TwoLetterCode { get; private set; }
public string ThreeLetterCode { get; private set; }
public string NumericCode { get; private set; }

public static readonly Country[] List = new[] {...};
```

Data source: http://en.wikipedia.org/wiki/ISO_3166-1

License: CC BY-SA 3.0