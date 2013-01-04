using System;
using System.Collections.Generic;
using System.Text;

namespace ISO3166
{
    public class Subdivision
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        private Subdivision(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        /// Source: http://en.wikipedia.org/wiki/ISO_3166-2:US
        internal static readonly Subdivision[] UnitedStatesSubdivisions = new[]
        {
            new Subdivision("US-AL", "Alabama"), 
            new Subdivision("US-AK", "Alaska"), 
            new Subdivision("US-AZ", "Arizona"), 
            new Subdivision("US-AR", "Arkansas"), 
            new Subdivision("US-CA", "California"), 
            new Subdivision("US-CO", "Colorado"), 
            new Subdivision("US-CT", "Connecticut"), 
            new Subdivision("US-DE", "Delaware"), 
            new Subdivision("US-FL", "Florida"), 
            new Subdivision("US-GA", "Georgia"), 
            new Subdivision("US-HI", "Hawaii"), 
            new Subdivision("US-ID", "Idaho"), 
            new Subdivision("US-IL", "Illinois"), 
            new Subdivision("US-IN", "Indiana"), 
            new Subdivision("US-IA", "Iowa"), 
            new Subdivision("US-KS", "Kansas"), 
            new Subdivision("US-KY", "Kentucky"), 
            new Subdivision("US-LA", "Louisiana"), 
            new Subdivision("US-ME", "Maine"), 
            new Subdivision("US-MD", "Maryland"), 
            new Subdivision("US-MA", "Massachusetts"), 
            new Subdivision("US-MI", "Michigan"), 
            new Subdivision("US-MN", "Minnesota"), 
            new Subdivision("US-MS", "Mississippi"), 
            new Subdivision("US-MO", "Missouri"), 
            new Subdivision("US-MT", "Montana"), 
            new Subdivision("US-NE", "Nebraska"), 
            new Subdivision("US-NV", "Nevada"), 
            new Subdivision("US-NH", "New Hampshire"), 
            new Subdivision("US-NJ", "New Jersey"), 
            new Subdivision("US-NM", "New Mexico"), 
            new Subdivision("US-NY", "New York"), 
            new Subdivision("US-NC", "North Carolina"), 
            new Subdivision("US-ND", "North Dakota"), 
            new Subdivision("US-OH", "Ohio"), 
            new Subdivision("US-OK", "Oklahoma"), 
            new Subdivision("US-OR", "Oregon"), 
            new Subdivision("US-PA", "Pennsylvania"), 
            new Subdivision("US-RI", "Rhode Island"), 
            new Subdivision("US-SC", "South Carolina"), 
            new Subdivision("US-SD", "South Dakota"), 
            new Subdivision("US-TN", "Tennessee"), 
            new Subdivision("US-TX", "Texas"), 
            new Subdivision("US-UT", "Utah"), 
            new Subdivision("US-VT", "Vermont"), 
            new Subdivision("US-VA", "Virginia"), 
            new Subdivision("US-WA", "Washington"), 
            new Subdivision("US-WV", "West Virginia"), 
            new Subdivision("US-WI", "Wisconsin"), 
            new Subdivision("US-WY", "Wyoming"), 
            new Subdivision("US-DC", "District of Columbia"), 
            new Subdivision("US-AS", "American Samoa"), 
            new Subdivision("US-GU", "Guam"), 
            new Subdivision("US-MP", "Northern Mariana Islands"), 
            new Subdivision("US-PR", "Puerto Rico"), 
            new Subdivision("US-UM", "United States Minor Outlying Islands"), 
            new Subdivision("US-VI", "Virgin Islands, U.S.")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:CA
        internal static readonly Subdivision[] CanadaSubdivisions = new[]
        {
            new Subdivision("CA-AB", "Alberta"), 
            new Subdivision("CA-BC", "British Columbia"), 
            new Subdivision("CA-MB", "Manitoba"), 
            new Subdivision("CA-NB", "New Brunswick"), 
            new Subdivision("CA-NL", "Newfoundland and Labrador"), 
            new Subdivision("CA-NS", "Nova Scotia"), 
            new Subdivision("CA-ON", "Ontario"), 
            new Subdivision("CA-PE", "Prince Edward Island"), 
            new Subdivision("CA-QC", "Quebec"), 
            new Subdivision("CA-SK", "Saskatchewan"), 
            new Subdivision("CA-NT", "Northwest Territories"), 
            new Subdivision("CA-NU", "Nunavut"), 
            new Subdivision("CA-YT", "Yukon Territory")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:AU
        internal static readonly Subdivision[] AustraliaSubdivisions = new[]
        {
            new Subdivision("AU-NSW", "New South Wales"),
            new Subdivision("AU-QLD", "Queensland"),
            new Subdivision("AU-SA", "South Australia"),
            new Subdivision("AU-TAS", "Tasmania"),
            new Subdivision("AU-VIC", "Victoria"),
            new Subdivision("AU-WA", "Western Australia"),
            new Subdivision("AU-ACT", "Australian Capital Territory"),
            new Subdivision("AU-NT", "Northern Territory")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:AT
        internal static readonly Subdivision[] AustriaSubdivisions = new[]
        {
            new Subdivision("AT-1", "Burgenland"),
            new Subdivision("AT-2", "Kärnten"),
            new Subdivision("AT-3", "Niederösterreich"),
            new Subdivision("AT-4", "Oberösterreich"),
            new Subdivision("AT-5", "Salzburg"),
            new Subdivision("AT-6", "Steiermark"),
            new Subdivision("AT-7", "Tirol"),
            new Subdivision("AT-8", "Vorarlberg"),
            new Subdivision("AT-9", "Wien")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:BE
        internal static readonly Subdivision[] BelgiumSubdivisions = new[]
        {
            new Subdivision("BE-BRU", "Brussels Hoofdstedelijk Gewest"),
            new Subdivision("BE-VLG", "Vlaamse Gewest"),
            new Subdivision("BE-WAL", "wallonne, Région")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:BR
        internal static readonly Subdivision[] BrazilSubdivisions = new[]
        {
            new Subdivision("BR-DF", "Distrito Federal"),
            new Subdivision("BR-AC", "Acre"),
            new Subdivision("BR-AL", "Alagoas"),
            new Subdivision("BR-AP", "Amapá"),
            new Subdivision("BR-AM", "Amazonas"),
            new Subdivision("BR-BA", "Bahia"),
            new Subdivision("BR-CE", "Ceará"),
            new Subdivision("BR-ES", "Espírito Santo"),
            new Subdivision("BR-GO", "Goiás"),
            new Subdivision("BR-MA", "Maranhão"),
            new Subdivision("BR-MT", "Mato Grosso"),
            new Subdivision("BR-MS", "Mato Grosso do Sul"),
            new Subdivision("BR-MG", "Minas Gerais"),
            new Subdivision("BR-PA", "Pará"),
            new Subdivision("BR-PB", "Paraíba"),
            new Subdivision("BR-PR", "Paraná"),
            new Subdivision("BR-PE", "Pernambuco"),
            new Subdivision("BR-PI", "Piauí"),
            new Subdivision("BR-RJ", "Rio de Janeiro"),
            new Subdivision("BR-RN", "Rio Grande do Norte"),
            new Subdivision("BR-RS", "Rio Grande do Sul"),
            new Subdivision("BR-RO", "Rondônia"),
            new Subdivision("BR-RR", "Roraima"),
            new Subdivision("BR-SC", "Santa Catarina"),
            new Subdivision("BR-SP", "São Paulo"),
            new Subdivision("BR-SE", "Sergipe"),
            new Subdivision("BR-TO", "Tocantins")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:CZ
        internal static readonly Subdivision[] CzechRepublicSubdivisions = new[]
        {
            new Subdivision("CZ-JC", "Jihočeský kraj"),
            new Subdivision("CZ-JM", "Jihomoravský kraj"),
            new Subdivision("CZ-KA", "Karlovarský kraj"),
            new Subdivision("CZ-KR", "Královéhradecký kraj"),
            new Subdivision("CZ-LI", "Liberecký kraj"),
            new Subdivision("CZ-MO", "Moravskoslezský kraj"),
            new Subdivision("CZ-OL", "Olomoucký kraj"),
            new Subdivision("CZ-PA", "Pardubický kraj"),
            new Subdivision("CZ-PL", "Plzeňský kraj"),
            new Subdivision("CZ-PR", "Praha, hlavní město"),
            new Subdivision("CZ-ST", "Středočeský kraj"),
            new Subdivision("CZ-US", "Ústecký kraj"),
            new Subdivision("CZ-VY", "Vysočina"),
            new Subdivision("CZ-ZL", "Zlínský kraj")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:FR
        internal static readonly Subdivision[] FranceSubdivisions = new[]
        {
            new Subdivision("FR-A", "Alsace"),
            new Subdivision("FR-B", "Aquitaine"),
            new Subdivision("FR-C", "Auvergne"),
            new Subdivision("FR-P", "Basse-Normandie"),
            new Subdivision("FR-D", "Bourgogne"),
            new Subdivision("FR-E", "Bretagne"),
            new Subdivision("FR-F", "Centre"),
            new Subdivision("FR-G", "Champagne-Ardenne"),
            new Subdivision("FR-H", "Corse"),
            new Subdivision("FR-I", "Franche-Comté"),
            new Subdivision("FR-Q", "Haute-Normandie"),
            new Subdivision("FR-J", "Île-de-France"),
            new Subdivision("FR-K", "Languedoc-Roussillon"),
            new Subdivision("FR-L", "Limousin"),
            new Subdivision("FR-M", "Lorraine"),
            new Subdivision("FR-N", "Midi-Pyrénées"),
            new Subdivision("FR-O", "Nord-Pas-de-Calais"),
            new Subdivision("FR-R", "Pays de la Loire"),
            new Subdivision("FR-S", "Picardie"),
            new Subdivision("FR-T", "Poitou-Charentes"),
            new Subdivision("FR-U", "Provence-Alpes-Côte d'Azur"),
            new Subdivision("FR-V", "Rhône-Alpes"),
            new Subdivision("FR-GP", "Guadeloupe"),
            new Subdivision("FR-GF", "Guyane (française)"),
            new Subdivision("FR-MQ", "Martinique"),
            new Subdivision("FR-YT", "Mayotte"),
            new Subdivision("FR-RE", "La Réunion")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:DE
        internal static readonly Subdivision[] GermanySubdivisions = new[]
        {
            new Subdivision("DE-BW", "Baden-Württemberg"),
            new Subdivision("DE-BY", "Bayern"),
            new Subdivision("DE-BE", "Berlin"),
            new Subdivision("DE-BB", "Brandenburg"),
            new Subdivision("DE-HB", "Bremen"),
            new Subdivision("DE-HH", "Hamburg"),
            new Subdivision("DE-HE", "Hessen"),
            new Subdivision("DE-MV", "Mecklenburg-Vorpommern"),
            new Subdivision("DE-NI", "Niedersachsen"),
            new Subdivision("DE-NW", "Nordrhein-Westfalen"),
            new Subdivision("DE-RP", "Rheinland-Pfalz"),
            new Subdivision("DE-SL", "Saarland"),
            new Subdivision("DE-SN", "Sachsen"),
            new Subdivision("DE-ST", "Sachsen-Anhalt"),
            new Subdivision("DE-SH", "Schleswig-Holstein"),
            new Subdivision("DE-TH", "Thüringen")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:HU
        internal static readonly Subdivision[] HungarySubdivisions = new[]
        {
            new Subdivision("HU-BU", "Budapest"),
            new Subdivision("HU-BK", "Bács-Kiskun"),
            new Subdivision("HU-BA", "Baranya"),
            new Subdivision("HU-BE", "Békés"),
            new Subdivision("HU-BZ", "Borsod-Abaúj-Zemplén"),
            new Subdivision("HU-CS", "Csongrád"),
            new Subdivision("HU-FE", "Fejér"),
            new Subdivision("HU-GS", "Győr-Moson-Sopron"),
            new Subdivision("HU-HB", "Hajdú-Bihar"),
            new Subdivision("HU-HE", "Heves"),
            new Subdivision("HU-JN", "Jász-Nagykun-Szolnok"),
            new Subdivision("HU-KE", "Komárom-Esztergom"),
            new Subdivision("HU-NO", "Nógrád"),
            new Subdivision("HU-PE", "Pest"),
            new Subdivision("HU-SO", "Somogy"),
            new Subdivision("HU-SZ", "Szabolcs-Szatmár-Bereg"),
            new Subdivision("HU-TO", "Tolna"),
            new Subdivision("HU-VA", "Vas"),
            new Subdivision("HU-VE", "Veszprém"),
            new Subdivision("HU-ZA", "Zala"),
            new Subdivision("HU-BC", "Békéscsaba"),
            new Subdivision("HU-DE", "Debrecen"),
            new Subdivision("HU-DU", "Dunaújváros"),
            new Subdivision("HU-EG", "Eger"),
            new Subdivision("HU-ER", "Érd"),
            new Subdivision("HU-GY", "Győr"),
            new Subdivision("HU-HV", "Hódmezővásárhely"),
            new Subdivision("HU-KV", "Kaposvár"),
            new Subdivision("HU-KM", "Kecskemét"),
            new Subdivision("HU-MI", "Miskolc"),
            new Subdivision("HU-NK", "Nagykanizsa"),
            new Subdivision("HU-NY", "Nyíregyháza"),
            new Subdivision("HU-PS", "Pécs"),
            new Subdivision("HU-ST", "Salgótarján"),
            new Subdivision("HU-SN", "Sopron"),
            new Subdivision("HU-SD", "Szeged"),
            new Subdivision("HU-SF", "Székesfehérvár"),
            new Subdivision("HU-SS", "Szekszárd"),
            new Subdivision("HU-SK", "Szolnok"),
            new Subdivision("HU-SH", "Szombathely"),
            new Subdivision("HU-TB", "Tatabánya"),
            new Subdivision("HU-VM", "Veszprém"),
            new Subdivision("HU-ZE", "Zalaegerszeg")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:IE
        internal static readonly Subdivision[] IrelandSubdivisions = new[]
        {
            new Subdivision("IE-C", "Connaught"),
            new Subdivision("IE-L", "Leinster"),
            new Subdivision("IE-M", "Munster"),
            new Subdivision("IE-U", "Ulster")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:IT
        internal static readonly Subdivision[] ItalySubdivisions = new[]
        {
            new Subdivision("IT-65", "Abruzzo"),
            new Subdivision("IT-77", "Basilicata"),
            new Subdivision("IT-78", "Calabria"),
            new Subdivision("IT-72", "Campania"),
            new Subdivision("IT-45", "Emilia-Romagna"),
            new Subdivision("IT-36", "Friuli-Venezia Giulia"),
            new Subdivision("IT-62", "Lazio"),
            new Subdivision("IT-42", "Liguria"),
            new Subdivision("IT-25", "Lombardia"),
            new Subdivision("IT-57", "Marche"),
            new Subdivision("IT-67", "Molise"),
            new Subdivision("IT-21", "Piemonte"),
            new Subdivision("IT-75", "Puglia"),
            new Subdivision("IT-88", "Sardegna"),
            new Subdivision("IT-82", "Sicilia"),
            new Subdivision("IT-52", "Toscana"),
            new Subdivision("IT-32", "Trentino-Alto Adige, Trentino-Südtirol"),
            new Subdivision("IT-55", "Umbria"),
            new Subdivision("IT-23", "Valle d'Aosta, Vallée d'Aoste"),
            new Subdivision("IT-34", "Veneto")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:JP
        internal static readonly Subdivision[] JapanSubdivisions = new[]
        {
            new Subdivision("JP-23", "Aiti"),
            new Subdivision("JP-05", "Akita"),
            new Subdivision("JP-02", "Aomori"),
            new Subdivision("JP-38", "Ehime"),
            new Subdivision("JP-21", "Gihu"),
            new Subdivision("JP-10", "Gunma"),
            new Subdivision("JP-34", "Hirosima"),
            new Subdivision("JP-01", "Hokkaidô"),
            new Subdivision("JP-18", "Hukui"),
            new Subdivision("JP-40", "Hukuoka"),
            new Subdivision("JP-07", "Hukusima"),
            new Subdivision("JP-28", "Hyôgo"),
            new Subdivision("JP-08", "Ibaraki"),
            new Subdivision("JP-17", "Isikawa"),
            new Subdivision("JP-03", "Iwate"),
            new Subdivision("JP-37", "Kagawa"),
            new Subdivision("JP-46", "Kagosima"),
            new Subdivision("JP-14", "Kanagawa"),
            new Subdivision("JP-39", "Kôti"),
            new Subdivision("JP-43", "Kumamoto"),
            new Subdivision("JP-26", "Kyôto"),
            new Subdivision("JP-24", "Mie"),
            new Subdivision("JP-04", "Miyagi"),
            new Subdivision("JP-45", "Miyazaki"),
            new Subdivision("JP-20", "Nagano"),
            new Subdivision("JP-42", "Nagasaki"),
            new Subdivision("JP-29", "Nara"),
            new Subdivision("JP-15", "Niigata"),
            new Subdivision("JP-44", "Ôita"),
            new Subdivision("JP-33", "Okayama"),
            new Subdivision("JP-47", "Okinawa"),
            new Subdivision("JP-27", "Ôsaka"),
            new Subdivision("JP-41", "Saga"),
            new Subdivision("JP-11", "Saitama"),
            new Subdivision("JP-25", "Siga"),
            new Subdivision("JP-32", "Simane"),
            new Subdivision("JP-22", "Sizuoka"),
            new Subdivision("JP-12", "Tiba"),
            new Subdivision("JP-09", "Totigi"),
            new Subdivision("JP-36", "Tokusima"),
            new Subdivision("JP-13", "Tôkyô"),
            new Subdivision("JP-31", "Tottori"),
            new Subdivision("JP-16", "Toyama"),
            new Subdivision("JP-30", "Wakayama"),
            new Subdivision("JP-06", "Yamagata"),
            new Subdivision("JP-35", "Yamaguti"),
            new Subdivision("JP-19", "Yamanasi")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:MX
        internal static readonly Subdivision[] MexicoSubdivisions = new[]
        {
            new Subdivision("MX-DIF", "Distrito Federal"),
            new Subdivision("MX-AGU", "Aguascalientes"),
            new Subdivision("MX-BCN", "Baja California"),
            new Subdivision("MX-BCS", "Baja California Sur"),
            new Subdivision("MX-CAM", "Campeche"),
            new Subdivision("MX-COA", "Coahuila"),
            new Subdivision("MX-COL", "Colima"),
            new Subdivision("MX-CHP", "Chiapas"),
            new Subdivision("MX-CHH", "Chihuahua"),
            new Subdivision("MX-DUR", "Durango"),
            new Subdivision("MX-GUA", "Guanajuato"),
            new Subdivision("MX-GRO", "Guerrero"),
            new Subdivision("MX-HID", "Hidalgo"),
            new Subdivision("MX-JAL", "Jalisco"),
            new Subdivision("MX-MEX", "México"),
            new Subdivision("MX-MIC", "Michoacán"),
            new Subdivision("MX-MOR", "Morelos"),
            new Subdivision("MX-NAY", "Nayarit"),
            new Subdivision("MX-NLE", "Nuevo León"),
            new Subdivision("MX-OAX", "Oaxaca"),
            new Subdivision("MX-PUE", "Puebla"),
            new Subdivision("MX-QUE", "Querétaro"),
            new Subdivision("MX-ROO", "Quintana Roo"),
            new Subdivision("MX-SLP", "San Luis Potosí"),
            new Subdivision("MX-SIN", "Sinaloa"),
            new Subdivision("MX-SON", "Sonora"),
            new Subdivision("MX-TAB", "Tabasco"),
            new Subdivision("MX-TAM", "Tamaulipas"),
            new Subdivision("MX-TLA", "Tlaxcala"),
            new Subdivision("MX-VER", "Veracruz"),
            new Subdivision("MX-YUC", "Yucatán"),
            new Subdivision("MX-ZAC", "Zacatecas")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:NL
        internal static readonly Subdivision[] NetherlandsSubdivisions = new[]
        {
            new Subdivision("NL-DR", "Drenthe"),
            new Subdivision("NL-FL", "Flevoland"),
            new Subdivision("NL-FR", "Fryslân"),
            new Subdivision("NL-GE", "Gelderland"),
            new Subdivision("NL-GR", "Groningen"),
            new Subdivision("NL-LI", "Limburg"),
            new Subdivision("NL-NB", "Noord-Braban"),
            new Subdivision("NL-NH", "Noord-Hollan"),
            new Subdivision("NL-OV", "Overijssel"),
            new Subdivision("NL-UT", "Utrecht"),
            new Subdivision("NL-ZE", "Zeeland"),
            new Subdivision("NL-ZH", "Zuid-Holland")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:NZ
        internal static readonly Subdivision[] NewZealandSubdivisions = new[]
        {
            new Subdivision("NZ-N", "North Island"),
            new Subdivision("NZ-S", "South Island")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:NO
        internal static readonly Subdivision[] NorwaySubdivisions = new[]
        {
            new Subdivision("NO-02", "Akershus"),
            new Subdivision("NO-09", "Aust-Agder"),
            new Subdivision("NO-06", "Buskerud"),
            new Subdivision("NO-20", "Finnmark"),
            new Subdivision("NO-04", "Hedmark"),
            new Subdivision("NO-12", "Hordaland"),
            new Subdivision("NO-15", "Møre og Romsdal"),
            new Subdivision("NO-18", "Nordland"),
            new Subdivision("NO-17", "Nord-Trøndelag"),
            new Subdivision("NO-05", "Oppland"),
            new Subdivision("NO-03", "Oslo"),
            new Subdivision("NO-11", "Rogaland"),
            new Subdivision("NO-14", "Sogn og Fjordane"),
            new Subdivision("NO-16", "Sør-Trøndelag"),
            new Subdivision("NO-08", "Telemark"),
            new Subdivision("NO-19", "Troms"),
            new Subdivision("NO-10", "Vest-Agder"),
            new Subdivision("NO-07", "Vestfold"),
            new Subdivision("NO-01", "Østfold"),
            new Subdivision("NO-22", "Jan Mayen"),
            new Subdivision("NO-21", "Svalbard")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:PL
        internal static readonly Subdivision[] PolandSubdivisions = new[]
        {
            new Subdivision("PL-DS", "Dolnośląskie"),
            new Subdivision("PL-KP", "Kujawsko-pomorskie"),
            new Subdivision("PL-LU", "Lubelskie"),
            new Subdivision("PL-LB", "Lubuskie"),
            new Subdivision("PL-LD", "Łódzkie"),
            new Subdivision("PL-MA", "Małopolskie"),
            new Subdivision("PL-MZ", "Mazowieckie"),
            new Subdivision("PL-OP", "Opolskie"),
            new Subdivision("PL-PK", "Podkarpackie"),
            new Subdivision("PL-PD", "Podlaskie"),
            new Subdivision("PL-PM", "Pomorskie"),
            new Subdivision("PL-SL", "Śląskie"),
            new Subdivision("PL-SK", "Świętokrzyskie"),
            new Subdivision("PL-WN", "Warmińsko-mazurskie"),
            new Subdivision("PL-WP", "Wielkopolskie"),
            new Subdivision("PL-ZP", "Zachodniopomorskie")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:PT
        internal static readonly Subdivision[] PortugalSubdivisions = new[]
        {
            new Subdivision("PT-01", "Aveiro"),
            new Subdivision("PT-02", "Beja"),
            new Subdivision("PT-03", "Braga"),
            new Subdivision("PT-04", "Bragança"),
            new Subdivision("PT-05", "Castelo Branco"),
            new Subdivision("PT-06", "Coimbra"),
            new Subdivision("PT-07", "Évora"),
            new Subdivision("PT-08", "Faro"),
            new Subdivision("PT-09", "Guarda"),
            new Subdivision("PT-10", "Leiria"),
            new Subdivision("PT-11", "Lisboa"),
            new Subdivision("PT-12", "Portalegre"),
            new Subdivision("PT-13", "Porto"),
            new Subdivision("PT-14", "Santarém"),
            new Subdivision("PT-15", "Setúbal"),
            new Subdivision("PT-16", "Viana do Castelo"),
            new Subdivision("PT-17", "Vila Real"),
            new Subdivision("PT-18", "Viseu"),
            new Subdivision("PT-20", "Região Autónoma dos Açores"),
            new Subdivision("PT-30", "Região Autónoma da Madeira")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:SK
        internal static readonly Subdivision[] SlovakiaSubdivisions = new[]
        {
            new Subdivision("SK-BC", "Banskobystrický kraj"),
            new Subdivision("SK-BL", "Bratislavský kraj"),
            new Subdivision("SK-KI", "Košický kraj"),
            new Subdivision("SK-NI", "Nitriansky kraj"),
            new Subdivision("SK-PV", "Prešovský kraj"),
            new Subdivision("SK-TC", "Trenčiansky kraj"),
            new Subdivision("SK-TA", "Trnavský kraj"),
            new Subdivision("SK-ZI", "Žilinský kraj")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:ZA
        internal static readonly Subdivision[] SouthAfricaSubdivisions = new[]
        {
            new Subdivision("ZA-EC", "Eastern Cape"),
            new Subdivision("ZA-FS", "Free State"),
            new Subdivision("ZA-GP", "Gauteng"),
            new Subdivision("ZA-ZN", "KwaZulu-Natal"),
            new Subdivision("ZA-LP", "Limpopo"),
            new Subdivision("ZA-MP", "Mpumalanga"),
            new Subdivision("ZA-NC", "Northern Cape"),
            new Subdivision("ZA-NW", "North West"),
            new Subdivision("ZA-WC", "Western Cape")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:KR
        internal static readonly Subdivision[] SouthKoreaSubdivisions = new[]
        {
            new Subdivision("KR-11", "Seoul Teugbyeolsi"),
            new Subdivision("KR-26", "Busan Gwang'yeogsi"),
            new Subdivision("KR-27", "Daegu Gwang'yeogsi"),
            new Subdivision("KR-30", "Daejeon Gwang'yeogsi"),
            new Subdivision("KR-29", "Gwangju Gwang'yeogsi"),
            new Subdivision("KR-28", "Incheon Gwang'yeogsi"),
            new Subdivision("KR-31", "Ulsan Gwang'yeogsi"),
            new Subdivision("KR-43", "Chungcheongbugdo"),
            new Subdivision("KR-44", "Chungcheongnamdo"),
            new Subdivision("KR-42", "Gang'weondo"),
            new Subdivision("KR-41", "Gyeonggido"),
            new Subdivision("KR-47", "Gyeongsangbugdo"),
            new Subdivision("KR-48", "Gyeongsangnamdo"),
            new Subdivision("KR-49", "Jejudo"),
            new Subdivision("KR-45", "Jeonrabugdo"),
            new Subdivision("KR-46", "Jeonranamdo")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:ES
        internal static readonly Subdivision[] SpainSubdivisions = new[]
        {
            new Subdivision("ES-AN", "Andalucía"),
            new Subdivision("ES-AR", "Aragón"),
            new Subdivision("ES-AS", "Asturias, Principado de"),
            new Subdivision("ES-CN", "Canarias"),
            new Subdivision("ES-CB", "Cantabria"),
            new Subdivision("ES-CM", "Castilla-La Mancha"),
            new Subdivision("ES-CL", "Castilla y León"),
            new Subdivision("ES-CT", "Catalunya"),
            new Subdivision("ES-EX", "Extremadura"),
            new Subdivision("ES-GA", "Galicia"),
            new Subdivision("ES-IB", "Illes Balears"),
            new Subdivision("ES-RI", "La Rioja"),
            new Subdivision("ES-MD", "Madrid, Comunidad de"),
            new Subdivision("ES-MC", "Murcia, Región de"),
            new Subdivision("ES-NC", "Navarra, Comunidad Foral de"),
            new Subdivision("ES-PV", "País Vasco"),
            new Subdivision("ES-VC", "Valenciana, Comunidad"),
            new Subdivision("ES-CE", "Ceuta"),
            new Subdivision("ES-ML", "Melilla")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:SE
        internal static readonly Subdivision[] SwedenSubdivisions = new[]
        {
            new Subdivision("SE-K", "Blekinge län"),
            new Subdivision("SE-W", "Dalarnas län"),
            new Subdivision("SE-I", "Gotlands län"),
            new Subdivision("SE-X", "Gävleborgs län"),
            new Subdivision("SE-N", "Hallands län"),
            new Subdivision("SE-Z", "Jämtlands län"),
            new Subdivision("SE-F", "Jönköpings län"),
            new Subdivision("SE-H", "Kalmar län"),
            new Subdivision("SE-G", "Kronobergs län"),
            new Subdivision("SE-BD","Norrbottens län"),
            new Subdivision("SE-M", "Skåne län"),
            new Subdivision("SE-AB","Stockholms län"),
            new Subdivision("SE-D", "Södermanlands län"),
            new Subdivision("SE-C", "Uppsala län"),
            new Subdivision("SE-S", "Värmlands län"),
            new Subdivision("SE-AC","Västerbottens län"),
            new Subdivision("SE-Y", "Västernorrlands län"),
            new Subdivision("SE-U", "Västmanlands län"),
            new Subdivision("SE-O", "Västra Götalands län"),
            new Subdivision("SE-T", "Örebro län"),
            new Subdivision("SE-E", "Östergötlands län")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:CH
        internal static readonly Subdivision[] SwitzerlandSubdivisions = new[]
        {
            new Subdivision("CH-AG", "Aargau"),
            new Subdivision("CH-AR", "Appenzell Ausserrhoden"),
            new Subdivision("CH-AI", "Appenzell Innerrhoden"),
            new Subdivision("CH-BL", "Basel-Landschaft"),
            new Subdivision("CH-BS", "Basel-Stadt"),
            new Subdivision("CH-BE", "Bern"),
            new Subdivision("CH-FR", "Fribourg"),
            new Subdivision("CH-GE", "Genève"),
            new Subdivision("CH-GL", "Glarus"),
            new Subdivision("CH-GR", "Graubünden"),
            new Subdivision("CH-JU", "Jura"),
            new Subdivision("CH-LU", "Luzern"),
            new Subdivision("CH-NE", "Neuchâtel"),
            new Subdivision("CH-NW", "Nidwalden"),
            new Subdivision("CH-OW", "Obwalden"),
            new Subdivision("CH-SG", "Sankt Gallen"),
            new Subdivision("CH-SH", "Schaffhausen"),
            new Subdivision("CH-SZ", "Schwyz"),
            new Subdivision("CH-SO", "Solothurn"),
            new Subdivision("CH-TG", "Thurgau"),
            new Subdivision("CH-TI", "Ticino"),
            new Subdivision("CH-UR", "Uri"),
            new Subdivision("CH-VS", "Valais"),
            new Subdivision("CH-VD", "Vaud"),
            new Subdivision("CH-ZG", "Zug"),
            new Subdivision("CH-ZH", "Zürich")
        };

        // Source: http://en.wikipedia.org/wiki/ISO_3166-2:GB
        internal static readonly Subdivision[] UnitedKingdomSubdivisions = new[]
        {
            new Subdivision("ENG", "England"),
            new Subdivision("NIR", "Northern Ireland"),
            new Subdivision("SCT", "Scotland"),
            new Subdivision("WLS", "Wales")
        };
    }
}
