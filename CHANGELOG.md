# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [1.0.5] - 2025-03-3

### Added 
 - Support for .NET 8.0
 - Verified and Incorporated updates from the [ISO 3166-1](https://www.iso.org/committee/48750.html?t=3V3rukDb61p05Wd6ojyTRvE0S3Yg_fZgUjrLjHWcd9-mDmTKHOGjbX3nEJ3SqHar&view=documents#section-isodocuments-top):
   - 2024-02-29 Corrections of inconsistencies in short names upper case
     - [Bolivia](https://www.iso.org/obp/ui/#iso:code:3166:BO) short name of Bolivia (Plurinational State of)
     - [Micronesia](https://www.iso.org/obp/ui/#iso:code:3166:FM) short name of Micronesia (Federated States of)
     - [Iran](https://www.iso.org/obp/ui/#iso:code:3166:IR)  short name of Iran (Islamic Republic of)
     - [North Korea)](https://www.iso.org/obp/ui/#iso:code:3166:KP) short name of Korea (Democratic People's Republic of)
     - [Venezuela](https://www.iso.org/obp/ui/#iso:code:3166:VE) short name of Venezuela (Bolivarian Republic of)
   - 2023-04-04  
     - [Netherlands](https://www.iso.org/obp/ui/#iso:code:3166:NL) (short name changed to "Netherlands (Kingdom of the)" )
   - 2022-11-21
     - [Iceland](https://www.iso.org/obp/ui/#iso:code:3166:IS) (no impact: the municipalities were updated along with full name, but those are not present in the library)
   - 2022-09-02
     - [Côte d'Ivoire](https://www.iso.org/obp/ui/#iso:code:3166:CI) (no impact, the French name was changed)
   - 2022-07-11
     - [Türkiye](https://www.iso.org/obp/ui/#iso:code:3166:TR) (name change from Turkey)
   - 2021-01-20
     - [Nepal](https://www.iso.org/obp/ui/#iso:code:3166:NP) (no impact, full name was changed but that's not present in the library)
   - 2020-03-02 
     -  [Czechia](https://www.iso.org/obp/ui/#iso:code:3166:CZ) (no impact: the subdivisions were updated, but that's not present in the library)
     -  [Greece](https://www.iso.org/obp/ui/#iso:code:3166:GR) (no impact: Correction of the Code Source, but that's not present in the library)
     -  [North Macedonia](https://www.iso.org/obp/ui/#iso:code:3166:MK) (no impact: the full name was changed along with some subdivisions, but those are not present in the library)
     -  [South Africa](https://www.iso.org/obp/ui/#iso:code:3166:ZA) (no impact: the subdivisions and code source were updated, but those are not present in the library)
     
## [1.0.4] - 2022-05-19

### Added
- Direct .NET Standard 2 support - zero dependencies for platforms that are supporting .NET Standard 2 [#24]
- Sourcelink and deterministic build [#25]


