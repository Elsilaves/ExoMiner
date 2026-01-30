# ExoMiner

ExoMiner is a C# console application for exploring real exoplanet data from NASA’s Exoplanet Archive (TESS discoveries).  
It parses a CSV dataset into structured objects and lets you run astronomy-focused queries from a console menu.

Data source:  
https://exoplanetarchive.ipac.caltech.edu/cgi-bin/TblView/nph-tblView?app=ExoTbls&config=PS&constraint=default_flag=1&constraint=disc_facility+like+%27%25TESS%25%27

# Project Structure

```
Models/
└── Exoplanet.cs

Services/
├── CsvReader.cs
└── Queries/
    └── <QueryGroupName>/ (partial classes)
        ├── <QueryGroupName>.cs
        ├── <QueryName1>.cs
        ├── <QueryName2>.cs
        └── ... (more queries)

Utilities/
├── AddHeader.cs
└── AddTitle.cs

Data/
└── csv/
    └── <dataset>.csv

Program.cs
```


## Requirements

- .NET 10 SDK
- Windows / macOS / Linux
- Terminal / console

## Run

Place the CSV file into:

    Data/csv/

Run the application:

    dotnet run

## Purpose

A small .NET console project to play with real-world data using NASA’s exoplanet dataset and spend some time experimenting with LINQ.
