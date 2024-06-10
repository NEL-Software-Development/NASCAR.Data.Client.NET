# NASCAR.Data.Client - the C# library for the NASCAR.Data.API


- API version: 1.0
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace NASCAR.Data.Client.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Configuration _config = new Configuration()
            {
                AccessToken = "..."
            };

            CompanyApi _companies = new CompanyApi(_config);
            DriverApi _drivers = new DriverApi(_config);

            Collection<Company> companyResult = _companies.FindCompany("NASCAR");
            Collection<Driver> driverResult = _drivers.BySeason(season: 2023, seriesId: 1);


            Console.WriteLine("Found " + companyResult.Count() + " companies.");
            Console.WriteLine("Found " + driverResult.Count() + " drivers.");
            Console.ReadLine();
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**RefreshToken**](docs/AccountApi.md#refreshtoken) | **GET** /account/refresh-token | 
*CompanyApi* | [**FindCompany**](docs/CompanyApi.md#findcompany) | **GET** /company/search | 
*DriverApi* | [**BySeason**](docs/DriverApi.md#byseason) | **GET** /driver/season | 
*DriverApi* | [**Driver**](docs/DriverApi.md#driver) | **GET** /driver | 
*DriverApi* | [**DriverSeasonFinishes**](docs/DriverApi.md#driverseasonfinishes) | **GET** /driver/season-finishes | 
*DriverSummaryApi* | [**DriverSummary**](docs/DriverSummaryApi.md#driversummary) | **GET** /driver-summary | 
*InspectionsApi* | [**OSS**](docs/InspectionsApi.md#oss) | **GET** /inspections/oss | 
*InspectionsApi* | [**VehicleWeights**](docs/InspectionsApi.md#vehicleweights) | **GET** /inspections/vehicle-weights | 
*NextGenApi* | [**DataPoints**](docs/NextGenApi.md#datapoints) | **GET** /nextgen-datapoints | 
*NextGenApi* | [**Sources**](docs/NextGenApi.md#sources) | **GET** /nextgen-sources | 
*OpticalTrackingApi* | [**UtmOffsets**](docs/OpticalTrackingApi.md#utmoffsets) | **GET** /utm-offsets | 
*PointsApi* | [**DriverPoints**](docs/PointsApi.md#driverpoints) | **GET** /points/driver-points | 
*PointsApi* | [**ManufacturerPoints**](docs/PointsApi.md#manufacturerpoints) | **GET** /points/manufacturer-points | 
*PointsApi* | [**OwnerPoints**](docs/PointsApi.md#ownerpoints) | **GET** /points/owner-points | 
*RaceApi* | [**Cautions**](docs/RaceApi.md#cautions) | **GET** /race/cautions | 
*RaceApi* | [**DisciplineUpdates**](docs/RaceApi.md#disciplineupdates) | **GET** /race/discipline-updates | 
*RaceApi* | [**Entries**](docs/RaceApi.md#entries) | **GET** /race/entries | 
*RaceApi* | [**Infractions**](docs/RaceApi.md#infractions) | **GET** /race/infractions | 
*RaceApi* | [**LapLeaders**](docs/RaceApi.md#lapleaders) | **GET** /race/lap-leaders | 
*RaceApi* | [**LoopStats**](docs/RaceApi.md#loopstats) | **GET** /race/loop-stats | 
*RaceApi* | [**PitStops**](docs/RaceApi.md#pitstops) | **GET** /race/pitstops | 
*RaceApi* | [**PracticeResults**](docs/RaceApi.md#practiceresults) | **GET** /race/practice-results | 
*RaceApi* | [**QualifyingResults**](docs/RaceApi.md#qualifyingresults) | **GET** /race/qualifying-results | 
*RaceApi* | [**Race**](docs/RaceApi.md#race) | **GET** /race | 
*RaceApi* | [**RaceResults**](docs/RaceApi.md#raceresults) | **GET** /race/race-results | 
*RaceApi* | [**RaceSeason**](docs/RaceApi.md#raceseason) | **GET** /race/season | 
*RaceApi* | [**Rosters**](docs/RaceApi.md#rosters) | **GET** /race/rosters | 
*RaceApi* | [**StageResults**](docs/RaceApi.md#stageresults) | **GET** /race/stage-results | 
*RaceApi* | [**ViewModel**](docs/RaceApi.md#viewmodel) | **GET** /race/viewmodel | 
*RaceApi* | [**WeekendSchedule**](docs/RaceApi.md#weekendschedule) | **GET** /race/weekend-schedule | 
*RaceWeekApi* | [**Details**](docs/RaceWeekApi.md#details) | **GET** /race-week/details | 
*RaceWeekApi* | [**Live**](docs/RaceWeekApi.md#live) | **GET** /race-week/live | 
*RaceWeekApi* | [**Season**](docs/RaceWeekApi.md#season) | **GET** /race-week/season | 
*SeriesApi* | [**Series**](docs/SeriesApi.md#series) | **GET** /series | 
*VehicleApi* | [**Vehicle**](docs/VehicleApi.md#vehicle) | **GET** /vehicle | 
*VehicleApi* | [**VehicleSeasonFinishes**](docs/VehicleApi.md#vehicleseasonfinishes) | **GET** /vehicle/season-finishes | 

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Caution](docs/Caution.md)
 - [Model.Company](docs/Company.md)
 - [Model.DisciplineUpdate](docs/DisciplineUpdate.md)
 - [Model.Driver](docs/Driver.md)
 - [Model.DriverPoint](docs/DriverPoint.md)
 - [Model.DriverSummary](docs/DriverSummary.md)
 - [Model.DriverSummaryByPrincipalRaceID](docs/DriverSummaryByPrincipalRaceID.md)
 - [Model.DriverSummaryBySeason](docs/DriverSummaryBySeason.md)
 - [Model.DriverSummaryByTrack](docs/DriverSummaryByTrack.md)
 - [Model.DriverSummaryByTrackType](docs/DriverSummaryByTrackType.md)
 - [Model.Flag](docs/Flag.md)
 - [Model.LapLeader](docs/LapLeader.md)
 - [Model.LoopStat](docs/LoopStat.md)
 - [Model.ManufacturerPoint](docs/ManufacturerPoint.md)
 - [Model.NextGenDatapoint](docs/NextGenDatapoint.md)
 - [Model.NextGenSource](docs/NextGenSource.md)
 - [Model.OSSScan](docs/OSSScan.md)
 - [Model.OpticalTrackingUTMOffset](docs/OpticalTrackingUTMOffset.md)
 - [Model.OwnerPoint](docs/OwnerPoint.md)
 - [Model.Pitstop](docs/Pitstop.md)
 - [Model.PracticeRunResults](docs/PracticeRunResults.md)
 - [Model.QualifyingRunResults](docs/QualifyingRunResults.md)
 - [Model.Race](docs/Race.md)
 - [Model.RaceDetails](docs/RaceDetails.md)
 - [Model.RaceInfraction](docs/RaceInfraction.md)
 - [Model.RaceResult](docs/RaceResult.md)
 - [Model.RaceResultSummary](docs/RaceResultSummary.md)
 - [Model.RaceRunResults](docs/RaceRunResults.md)
 - [Model.RaceViewModel](docs/RaceViewModel.md)
 - [Model.RaceWeek](docs/RaceWeek.md)
 - [Model.RaceWeekDetails](docs/RaceWeekDetails.md)
 - [Model.RosterMember](docs/RosterMember.md)
 - [Model.RunDetails](docs/RunDetails.md)
 - [Model.RunEntry](docs/RunEntry.md)
 - [Model.RunResult](docs/RunResult.md)
 - [Model.RunState](docs/RunState.md)
 - [Model.RunType](docs/RunType.md)
 - [Model.Series](docs/Series.md)
 - [Model.StageResult](docs/StageResult.md)
 - [Model.StageRunResults](docs/StageRunResults.md)
 - [Model.TeamRoster](docs/TeamRoster.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.VehicleDetails](docs/VehicleDetails.md)
 - [Model.VehicleWeight](docs/VehicleWeight.md)
 - [Model.WeekendSchedule](docs/WeekendSchedule.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer


