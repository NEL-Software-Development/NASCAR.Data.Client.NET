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

All URIs are relative to */api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**AccountRefreshTokenGet**](docs/AccountApi.md#accountrefreshtokenget) | **GET** /account/refresh-token | 
*CompanyApi* | [**CompanySearchGet**](docs/CompanyApi.md#companysearchget) | **GET** /company/search | 
*DriverApi* | [**DriverGet**](docs/DriverApi.md#driverget) | **GET** /driver | 
*DriverApi* | [**DriverSeasonFinishesGet**](docs/DriverApi.md#driverseasonfinishesget) | **GET** /driver/season-finishes | 
*DriverApi* | [**DriverSeasonGet**](docs/DriverApi.md#driverseasonget) | **GET** /driver/season | 
*DriverSummaryApi* | [**DriverSummaryGet**](docs/DriverSummaryApi.md#driversummaryget) | **GET** /driver-summary | 
*ERDPApi* | [**ErdpDatapointsGet**](docs/ERDPApi.md#erdpdatapointsget) | **GET** /erdp/datapoints | 
*ERDPApi* | [**ErdpSourcesGet**](docs/ERDPApi.md#erdpsourcesget) | **GET** /erdp/sources | 
*FeedbackApi* | [**FeedbackDevNotesGet**](docs/FeedbackApi.md#feedbackdevnotesget) | **GET** /feedback/dev-notes | 
*FeedbackApi* | [**FeedbackSubmitFeedbackPost**](docs/FeedbackApi.md#feedbacksubmitfeedbackpost) | **POST** /feedback/submit-feedback | 
*InspectionsApi* | [**InspectionsOssGet**](docs/InspectionsApi.md#inspectionsossget) | **GET** /inspections/oss | 
*InspectionsApi* | [**InspectionsVehicleWeightsGet**](docs/InspectionsApi.md#inspectionsvehicleweightsget) | **GET** /inspections/vehicle-weights | 
*OpticalTrackingApi* | [**OpticalTrackingUtmOffsetsGet**](docs/OpticalTrackingApi.md#opticaltrackingutmoffsetsget) | **GET** /optical-tracking/utm-offsets | 
*PointsApi* | [**PointsDriverPointsGet**](docs/PointsApi.md#pointsdriverpointsget) | **GET** /points/driver-points | 
*PointsApi* | [**PointsManufacturerPointsGet**](docs/PointsApi.md#pointsmanufacturerpointsget) | **GET** /points/manufacturer-points | 
*PointsApi* | [**PointsOwnerPointsGet**](docs/PointsApi.md#pointsownerpointsget) | **GET** /points/owner-points | 
*RaceApi* | [**RaceCautionsGet**](docs/RaceApi.md#racecautionsget) | **GET** /race/cautions | 
*RaceApi* | [**RaceDisciplineUpdatesGet**](docs/RaceApi.md#racedisciplineupdatesget) | **GET** /race/discipline-updates | 
*RaceApi* | [**RaceEntriesGet**](docs/RaceApi.md#raceentriesget) | **GET** /race/entries | 
*RaceApi* | [**RaceGet**](docs/RaceApi.md#raceget) | **GET** /race | 
*RaceApi* | [**RaceInfractionsGet**](docs/RaceApi.md#raceinfractionsget) | **GET** /race/infractions | 
*RaceApi* | [**RaceLapLeadersGet**](docs/RaceApi.md#racelapleadersget) | **GET** /race/lap-leaders | 
*RaceApi* | [**RaceLoopStatsGet**](docs/RaceApi.md#raceloopstatsget) | **GET** /race/loop-stats | 
*RaceApi* | [**RacePitstopsGet**](docs/RaceApi.md#racepitstopsget) | **GET** /race/pitstops | 
*RaceApi* | [**RacePracticeResultsGet**](docs/RaceApi.md#racepracticeresultsget) | **GET** /race/practice-results | 
*RaceApi* | [**RaceQualifyingResultsGet**](docs/RaceApi.md#racequalifyingresultsget) | **GET** /race/qualifying-results | 
*RaceApi* | [**RaceRaceResultsGet**](docs/RaceApi.md#raceraceresultsget) | **GET** /race/race-results | 
*RaceApi* | [**RaceRostersGet**](docs/RaceApi.md#racerostersget) | **GET** /race/rosters | 
*RaceApi* | [**RaceSeasonGet**](docs/RaceApi.md#raceseasonget) | **GET** /race/season | 
*RaceApi* | [**RaceStageResultsGet**](docs/RaceApi.md#racestageresultsget) | **GET** /race/stage-results | 
*RaceApi* | [**RaceViewmodelGet**](docs/RaceApi.md#raceviewmodelget) | **GET** /race/viewmodel | 
*RaceApi* | [**RaceWeekendScheduleGet**](docs/RaceApi.md#raceweekendscheduleget) | **GET** /race/weekend-schedule | 
*RaceWeekApi* | [**RaceWeekDetailsGet**](docs/RaceWeekApi.md#raceweekdetailsget) | **GET** /race-week/details | 
*RaceWeekApi* | [**RaceWeekLiveGet**](docs/RaceWeekApi.md#raceweekliveget) | **GET** /race-week/live | 
*RaceWeekApi* | [**RaceWeekSeasonGet**](docs/RaceWeekApi.md#raceweekseasonget) | **GET** /race-week/season | 
*SeriesApi* | [**SeriesGet**](docs/SeriesApi.md#seriesget) | **GET** /series | 
*VehicleApi* | [**VehicleGet**](docs/VehicleApi.md#vehicleget) | **GET** /vehicle | 
*VehicleApi* | [**VehicleSeasonFinishesGet**](docs/VehicleApi.md#vehicleseasonfinishesget) | **GET** /vehicle/season-finishes | 

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Caution](docs/Caution.md)
 - [Model.Company](docs/Company.md)
 - [Model.DevNote](docs/DevNote.md)
 - [Model.DisciplineUpdate](docs/DisciplineUpdate.md)
 - [Model.Driver](docs/Driver.md)
 - [Model.DriverPoint](docs/DriverPoint.md)
 - [Model.DriverSummary](docs/DriverSummary.md)
 - [Model.DriverSummaryByPrincipalRaceID](docs/DriverSummaryByPrincipalRaceID.md)
 - [Model.DriverSummaryBySeason](docs/DriverSummaryBySeason.md)
 - [Model.DriverSummaryByTrack](docs/DriverSummaryByTrack.md)
 - [Model.DriverSummaryByTrackType](docs/DriverSummaryByTrackType.md)
 - [Model.Feedback](docs/Feedback.md)
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
 - [Model.ProcessingState](docs/ProcessingState.md)
 - [Model.PublishState](docs/PublishState.md)
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
 - [Model.ScheduledActionSchedule](docs/ScheduledActionSchedule.md)
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
