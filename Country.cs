﻿/*
 * ISO 3166-1 country codes
 * 
 * Data source: http://en.wikipedia.org/wiki/ISO_3166-1
 * License: http://creativecommons.org/licenses/by-sa/3.0/
 */
namespace ISO3166
{
    public class Country
    {
        public string Name { get; private set; }
        public string TwoLetterCode { get; private set; }
        public string ThreeLetterCode { get; private set; }
        public string NumericCode { get; private set; }
        public Subdivision[] Subdivisions { get; private set; }

        private Country(string name, string twoLetterCode, string threeLetterCode, string numericCode)
            : this(name, twoLetterCode, threeLetterCode, numericCode, new Subdivision[0])
        {
        }

        private Country(string name, string twoLetterCode, string threeLetterCode, string numericCode, Subdivision[] subdivisions)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
            ThreeLetterCode = threeLetterCode;
            NumericCode = numericCode;
            this.Subdivisions = subdivisions;
        }

        public static readonly Country[] List = new[]
        {
            new Country("Afghanistan", "AF", "AFG", "004"),
            new Country("Åland Islands", "AX", "ALA", "248"),
            new Country("Albania", "AL", "ALB", "008"),
            new Country("Algeria", "DZ", "DZA", "012"),
            new Country("American Samoa", "AS", "ASM", "016"),
            new Country("Andorra", "AD", "AND", "020"),
            new Country("Angola", "AO", "AGO", "024"),
            new Country("Anguilla", "AI", "AIA", "660"),
            new Country("Antarctica", "AQ", "ATA", "010"),
            new Country("Antigua and Barbuda", "AG", "ATG", "028"),
            new Country("Argentina", "AR", "ARG", "032"),
            new Country("Armenia", "AM", "ARM", "051"),
            new Country("Aruba", "AW", "ABW", "533"),
            new Country("Australia", "AU", "AUS", "036", Subdivision.AustraliaSubdivisions),
            new Country("Austria", "AT", "AUT", "040", Subdivision.AustriaSubdivisions),
            new Country("Azerbaijan", "AZ", "AZE", "031"),
            new Country("Bahamas", "BS", "BHS", "044"),
            new Country("Bahrain", "BH", "BHR", "048"),
            new Country("Bangladesh", "BD", "BGD", "050"),
            new Country("Barbados", "BB", "BRB", "052"),
            new Country("Belarus", "BY", "BLR", "112"),
            new Country("Belgium", "BE", "BEL", "056", Subdivision.BelgiumSubdivisions),
            new Country("Belize", "BZ", "BLZ", "084"),
            new Country("Benin", "BJ", "BEN", "204"),
            new Country("Bermuda", "BM", "BMU", "060"),
            new Country("Bhutan", "BT", "BTN", "064"),
            new Country("Bolivia, Plurinational State of", "BO", "BOL", "068"),
            new Country("Bonaire, Sint Eustatius and Saba", "BQ", "BES", "535"),
            new Country("Bosnia and Herzegovina", "BA", "BIH", "070"),
            new Country("Botswana", "BW", "BWA", "072"),
            new Country("Bouvet Island", "BV", "BVT", "074"),
            new Country("Brazil", "BR", "BRA", "076", Subdivision.BrazilSubdivisions),
            new Country("British Indian Ocean Territory", "IO", "IOT", "086"),
            new Country("Brunei Darussalam", "BN", "BRN", "096"),
            new Country("Bulgaria", "BG", "BGR", "100"),
            new Country("Burkina Faso", "BF", "BFA", "854"),
            new Country("Burundi", "BI", "BDI", "108"),
            new Country("Cambodia", "KH", "KHM", "116"),
            new Country("Cameroon", "CM", "CMR", "120"),
            new Country("Canada", "CA", "CAN", "124", Subdivision.CanadaSubdivisions),
            new Country("Cape Verde", "CV", "CPV", "132"),
            new Country("Cayman Islands", "KY", "CYM", "136"),
            new Country("Central African Republic", "CF", "CAF", "140"),
            new Country("Chad", "TD", "TCD", "148"),
            new Country("Chile", "CL", "CHL", "152"),
            new Country("China", "CN", "CHN", "156"),
            new Country("Christmas Island", "CX", "CXR", "162"),
            new Country("Cocos (Keeling) Islands", "CC", "CCK", "166"),
            new Country("Colombia", "CO", "COL", "170"),
            new Country("Comoros", "KM", "COM", "174"),
            new Country("Congo", "CG", "COG", "178"),
            new Country("Congo, the Democratic Republic of the", "CD", "COD", "180"),
            new Country("Cook Islands", "CK", "COK", "184"),
            new Country("Costa Rica", "CR", "CRI", "188"),
            new Country("Côte d'Ivoire", "CI", "CIV", "384"),
            new Country("Croatia", "HR", "HRV", "191"),
            new Country("Cuba", "CU", "CUB", "192"),
            new Country("Curaçao", "CW", "CUW", "531"),
            new Country("Cyprus", "CY", "CYP", "196"),
            new Country("Czech Republic", "CZ", "CZE", "203", Subdivision.CzechRepublicSubdivisions),
            new Country("Denmark", "DK", "DNK", "208"),
            new Country("Djibouti", "DJ", "DJI", "262"),
            new Country("Dominica", "DM", "DMA", "212"),
            new Country("Dominican Republic", "DO", "DOM", "214"),
            new Country("Ecuador", "EC", "ECU", "218"),
            new Country("Egypt", "EG", "EGY", "818"),
            new Country("El Salvador", "SV", "SLV", "222"),
            new Country("Equatorial Guinea", "GQ", "GNQ", "226"),
            new Country("Eritrea", "ER", "ERI", "232"),
            new Country("Estonia", "EE", "EST", "233"),
            new Country("Ethiopia", "ET", "ETH", "231"),
            new Country("Falkland Islands (Malvinas)", "FK", "FLK", "238"),
            new Country("Faroe Islands", "FO", "FRO", "234"),
            new Country("Fiji", "FJ", "FJI", "242"),
            new Country("Finland", "FI", "FIN", "246"),
            new Country("France", "FR", "FRA", "250", Subdivision.FranceSubdivisions),
            new Country("French Guiana", "GF", "GUF", "254"),
            new Country("French Polynesia", "PF", "PYF", "258"),
            new Country("French Southern Territories", "TF", "ATF", "260"),
            new Country("Gabon", "GA", "GAB", "266"),
            new Country("Gambia", "GM", "GMB", "270"),
            new Country("Georgia", "GE", "GEO", "268"),
            new Country("Germany", "DE", "DEU", "276", Subdivision.GermanySubdivisions),
            new Country("Ghana", "GH", "GHA", "288"),
            new Country("Gibraltar", "GI", "GIB", "292"),
            new Country("Greece", "GR", "GRC", "300"),
            new Country("Greenland", "GL", "GRL", "304"),
            new Country("Grenada", "GD", "GRD", "308"),
            new Country("Guadeloupe", "GP", "GLP", "312"),
            new Country("Guam", "GU", "GUM", "316"),
            new Country("Guatemala", "GT", "GTM", "320"),
            new Country("Guernsey", "GG", "GGY", "831"),
            new Country("Guinea", "GN", "GIN", "324"),
            new Country("Guinea-Bissau", "GW", "GNB", "624"),
            new Country("Guyana", "GY", "GUY", "328"),
            new Country("Haiti", "HT", "HTI", "332"),
            new Country("Heard Island and McDonald Islands", "HM", "HMD", "334"),
            new Country("Holy See (Vatican City State)", "VA", "VAT", "336"),
            new Country("Honduras", "HN", "HND", "340"),
            new Country("Hong Kong", "HK", "HKG", "344"),
            new Country("Hungary", "HU", "HUN", "348", Subdivision.HungarySubdivisions),
            new Country("Iceland", "IS", "ISL", "352", Subdivision.IrelandSubdivisions),
            new Country("India", "IN", "IND", "356"),
            new Country("Indonesia", "ID", "IDN", "360"),
            new Country("Iran, Islamic Republic of", "IR", "IRN", "364"),
            new Country("Iraq", "IQ", "IRQ", "368"),
            new Country("Ireland", "IE", "IRL", "372"),
            new Country("Isle of Man", "IM", "IMN", "833"),
            new Country("Israel", "IL", "ISR", "376"),
            new Country("Italy", "IT", "ITA", "380", Subdivision.ItalySubdivisions),
            new Country("Jamaica", "JM", "JAM", "388"),
            new Country("Japan", "JP", "JPN", "392", Subdivision.JapanSubdivisions),
            new Country("Jersey", "JE", "JEY", "832"),
            new Country("Jordan", "JO", "JOR", "400"),
            new Country("Kazakhstan", "KZ", "KAZ", "398"),
            new Country("Kenya", "KE", "KEN", "404"),
            new Country("Kiribati", "KI", "KIR", "296"),
            new Country("Korea, Democratic People's Republic of", "KP", "PRK", "408"),
            new Country("Korea, Republic of", "KR", "KOR", "410", Subdivision.SouthKoreaSubdivisions),
            new Country("Kuwait", "KW", "KWT", "414"),
            new Country("Kyrgyzstan", "KG", "KGZ", "417"),
            new Country("Lao People's Democratic Republic", "LA", "LAO", "418"),
            new Country("Latvia", "LV", "LVA", "428"),
            new Country("Lebanon", "LB", "LBN", "422"),
            new Country("Lesotho", "LS", "LSO", "426"),
            new Country("Liberia", "LR", "LBR", "430"),
            new Country("Libya", "LY", "LBY", "434"),
            new Country("Liechtenstein", "LI", "LIE", "438"),
            new Country("Lithuania", "LT", "LTU", "440"),
            new Country("Luxembourg", "LU", "LUX", "442"),
            new Country("Macao", "MO", "MAC", "446"),
            new Country("Macedonia, the former Yugoslav Republic of", "MK", "MKD", "807"),
            new Country("Madagascar", "MG", "MDG", "450"),
            new Country("Malawi", "MW", "MWI", "454"),
            new Country("Malaysia", "MY", "MYS", "458"),
            new Country("Maldives", "MV", "MDV", "462"),
            new Country("Mali", "ML", "MLI", "466"),
            new Country("Malta", "MT", "MLT", "470"),
            new Country("Marshall Islands", "MH", "MHL", "584"),
            new Country("Martinique", "MQ", "MTQ", "474"),
            new Country("Mauritania", "MR", "MRT", "478"),
            new Country("Mauritius", "MU", "MUS", "480"),
            new Country("Mayotte", "YT", "MYT", "175"),
            new Country("Mexico", "MX", "MEX", "484", Subdivision.MexicoSubdivisions),
            new Country("Micronesia, Federated States of", "FM", "FSM", "583"),
            new Country("Moldova, Republic of", "MD", "MDA", "498"),
            new Country("Monaco", "MC", "MCO", "492"),
            new Country("Mongolia", "MN", "MNG", "496"),
            new Country("Montenegro", "ME", "MNE", "499"),
            new Country("Montserrat", "MS", "MSR", "500"),
            new Country("Morocco", "MA", "MAR", "504"),
            new Country("Mozambique", "MZ", "MOZ", "508"),
            new Country("Myanmar", "MM", "MMR", "104"),
            new Country("Namibia", "NA", "NAM", "516"),
            new Country("Nauru", "NR", "NRU", "520"),
            new Country("Nepal", "NP", "NPL", "524"),
            new Country("Netherlands", "NL", "NLD", "528", Subdivision.NetherlandsSubdivisions),
            new Country("New Caledonia", "NC", "NCL", "540"),
            new Country("New Zealand", "NZ", "NZL", "554", Subdivision.NewZealandSubdivisions),
            new Country("Nicaragua", "NI", "NIC", "558"),
            new Country("Niger", "NE", "NER", "562"),
            new Country("Nigeria", "NG", "NGA", "566"),
            new Country("Niue", "NU", "NIU", "570"),
            new Country("Norfolk Island", "NF", "NFK", "574"),
            new Country("Northern Mariana Islands", "MP", "MNP", "580"),
            new Country("Norway", "NO", "NOR", "578", Subdivision.NorwaySubdivisions),
            new Country("Oman", "OM", "OMN", "512"),
            new Country("Pakistan", "PK", "PAK", "586"),
            new Country("Palau", "PW", "PLW", "585"),
            new Country("Palestinian Territory, Occupied", "PS", "PSE", "275"),
            new Country("Panama", "PA", "PAN", "591"),
            new Country("Papua New Guinea", "PG", "PNG", "598"),
            new Country("Paraguay", "PY", "PRY", "600"),
            new Country("Peru", "PE", "PER", "604"),
            new Country("Philippines", "PH", "PHL", "608"),
            new Country("Pitcairn", "PN", "PCN", "612"),
            new Country("Poland", "PL", "POL", "616", Subdivision.PolandSubdivisions),
            new Country("Portugal", "PT", "PRT", "620", Subdivision.PortugalSubdivisions),
            new Country("Puerto Rico", "PR", "PRI", "630"),
            new Country("Qatar", "QA", "QAT", "634"),
            new Country("Réunion", "RE", "REU", "638"),
            new Country("Romania", "RO", "ROU", "642"),
            new Country("Russian Federation", "RU", "RUS", "643"),
            new Country("Rwanda", "RW", "RWA", "646"),
            new Country("Saint Barthélemy", "BL", "BLM", "652"),
            new Country("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN", "654"),
            new Country("Saint Kitts and Nevis", "KN", "KNA", "659"),
            new Country("Saint Lucia", "LC", "LCA", "662"),
            new Country("Saint Martin (French part)", "MF", "MAF", "663"),
            new Country("Saint Pierre and Miquelon", "PM", "SPM", "666"),
            new Country("Saint Vincent and the Grenadines", "VC", "VCT", "670"),
            new Country("Samoa", "WS", "WSM", "882"),
            new Country("San Marino", "SM", "SMR", "674"),
            new Country("Sao Tome and Principe", "ST", "STP", "678"),
            new Country("Saudi Arabia", "SA", "SAU", "682"),
            new Country("Senegal", "SN", "SEN", "686"),
            new Country("Serbia", "RS", "SRB", "688"),
            new Country("Seychelles", "SC", "SYC", "690"),
            new Country("Sierra Leone", "SL", "SLE", "694"),
            new Country("Singapore", "SG", "SGP", "702"),
            new Country("Sint Maarten (Dutch part)", "SX", "SXM", "534"),
            new Country("Slovakia", "SK", "SVK", "703", Subdivision.SlovakiaSubdivisions),
            new Country("Slovenia", "SI", "SVN", "705"),
            new Country("Solomon Islands", "SB", "SLB", "090"),
            new Country("Somalia", "SO", "SOM", "706"),
            new Country("South Africa", "ZA", "ZAF", "710", Subdivision.SouthAfricaSubdivisions),
            new Country("South Georgia and the South Sandwich Islands", "GS", "SGS", "239"),
            new Country("South Sudan", "SS", "SSD", "728"),
            new Country("Spain", "ES", "ESP", "724", Subdivision.SpainSubdivisions),
            new Country("Sri Lanka", "LK", "LKA", "144"),
            new Country("Sudan", "SD", "SDN", "729"),
            new Country("Suriname", "SR", "SUR", "740"),
            new Country("Svalbard and Jan Mayen", "SJ", "SJM", "744"),
            new Country("Swaziland", "SZ", "SWZ", "748"),
            new Country("Sweden", "SE", "SWE", "752", Subdivision.SwedenSubdivisions),
            new Country("Switzerland", "CH", "CHE", "756", Subdivision.SwitzerlandSubdivisions),
            new Country("Syrian Arab Republic", "SY", "SYR", "760"),
            new Country("Taiwan, Province of China", "TW", "TWN", "158"),
            new Country("Tajikistan", "TJ", "TJK", "762"),
            new Country("Tanzania, United Republic of", "TZ", "TZA", "834"),
            new Country("Thailand", "TH", "THA", "764"),
            new Country("Timor-Leste", "TL", "TLS", "626"),
            new Country("Togo", "TG", "TGO", "768"),
            new Country("Tokelau", "TK", "TKL", "772"),
            new Country("Tonga", "TO", "TON", "776"),
            new Country("Trinidad and Tobago", "TT", "TTO", "780"),
            new Country("Tunisia", "TN", "TUN", "788"),
            new Country("Turkey", "TR", "TUR", "792"),
            new Country("Turkmenistan", "TM", "TKM", "795"),
            new Country("Turks and Caicos Islands", "TC", "TCA", "796"),
            new Country("Tuvalu", "TV", "TUV", "798"),
            new Country("Uganda", "UG", "UGA", "800"),
            new Country("Ukraine", "UA", "UKR", "804"),
            new Country("United Arab Emirates", "AE", "ARE", "784"),
            new Country("United Kingdom", "GB", "GBR", "826", Subdivision.UnitedKingdomSubdivisions),
            new Country("United States", "US", "USA", "840", Subdivision.UnitedStatesSubdivisions),
            new Country("United States Minor Outlying Islands", "UM", "UMI", "581"),
            new Country("Uruguay", "UY", "URY", "858"),
            new Country("Uzbekistan", "UZ", "UZB", "860"),
            new Country("Vanuatu", "VU", "VUT", "548"),
            new Country("Venezuela, Bolivarian Republic of", "VE", "VEN", "862"),
            new Country("Viet Nam", "VN", "VNM", "704"),
            new Country("Virgin Islands, British", "VG", "VGB", "092"),
            new Country("Virgin Islands, U.S.", "VI", "VIR", "850"),
            new Country("Wallis and Futuna", "WF", "WLF", "876"),
            new Country("Western Sahara", "EH", "ESH", "732"),
            new Country("Yemen", "YE", "YEM", "887"),
            new Country("Zambia", "ZM", "ZMB", "894"),
            new Country("Zimbabwe", "ZW", "ZWE", "716"),
        };
    }
}