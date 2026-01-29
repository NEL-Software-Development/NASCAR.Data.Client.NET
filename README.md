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
<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**AccountRefreshTokenGet**](docs/AccountApi.md#accountrefreshtokenget) | **GET** /account/refresh-token | 
*CompanyApi* | [**CompanyGet**](docs/CompanyApi.md#companyget) | **GET** /company | 
*CompanyApi* | [**CompanySearchGet**](docs/CompanyApi.md#companysearchget) | **GET** /company/search | 
*DriverApi* | [**DriverGet**](docs/DriverApi.md#driverget) | **GET** /driver | 
*DriverApi* | [**DriverSeasonFinishesGet**](docs/DriverApi.md#driverseasonfinishesget) | **GET** /driver/season-finishes | 
*DriverApi* | [**DriverSeasonGet**](docs/DriverApi.md#driverseasonget) | **GET** /driver/season | 
*DriverSummaryApi* | [**DriverSummaryGet**](docs/DriverSummaryApi.md#driversummaryget) | **GET** /driver-summary | 
*ERDPApi* | [**ErdpTopicsGet**](docs/ERDPApi.md#erdptopicsget) | **GET** /erdp/topics | Get a users erdp topics.
*InspectionsApi* | [**InspectionsOssGet**](docs/InspectionsApi.md#inspectionsossget) | **GET** /inspections/oss | 
*InspectionsApi* | [**InspectionsVehicleWeightsGet**](docs/InspectionsApi.md#inspectionsvehicleweightsget) | **GET** /inspections/vehicle-weights | 
*JournalFilesApi* | [**JournalGet**](docs/JournalFilesApi.md#journalget) | **GET** /journal | 
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
*RaceApi* | [**RaceLiveSessionGet**](docs/RaceApi.md#racelivesessionget) | **GET** /race/live-session | 
*RaceApi* | [**RaceLookupGet**](docs/RaceApi.md#racelookupget) | **GET** /race/lookup | 
*RaceApi* | [**RaceLoopStatsGet**](docs/RaceApi.md#raceloopstatsget) | **GET** /race/loop-stats | 
*RaceApi* | [**RacePitstopsGet**](docs/RaceApi.md#racepitstopsget) | **GET** /race/pitstops | 
*RaceApi* | [**RacePracticeResultsGet**](docs/RaceApi.md#racepracticeresultsget) | **GET** /race/practice-results | 
*RaceApi* | [**RaceQualifyingResultsGet**](docs/RaceApi.md#racequalifyingresultsget) | **GET** /race/qualifying-results | 
*RaceApi* | [**RaceRaceResultsGet**](docs/RaceApi.md#raceraceresultsget) | **GET** /race/race-results | 
*RaceApi* | [**RaceReportGet**](docs/RaceApi.md#racereportget) | **GET** /race/report | 
*RaceApi* | [**RaceResultsGet**](docs/RaceApi.md#raceresultsget) | **GET** /race/results | 
*RaceApi* | [**RaceRostersGet**](docs/RaceApi.md#racerostersget) | **GET** /race/rosters | 
*RaceApi* | [**RaceSeasonGet**](docs/RaceApi.md#raceseasonget) | **GET** /race/season | 
*RaceApi* | [**RaceStageResultsGet**](docs/RaceApi.md#racestageresultsget) | **GET** /race/stage-results | 
*RaceApi* | [**RaceStagesGet**](docs/RaceApi.md#racestagesget) | **GET** /race/stages | 
*RaceApi* | [**RaceStatReportsGet**](docs/RaceApi.md#racestatreportsget) | **GET** /race/stat-reports | 
*RaceApi* | [**RaceViewmodelGet**](docs/RaceApi.md#raceviewmodelget) | **GET** /race/viewmodel | 
*RaceApi* | [**RaceWeekendScheduleGet**](docs/RaceApi.md#raceweekendscheduleget) | **GET** /race/weekend-schedule | 
*RaceWeekApi* | [**RaceWeekDetailsGet**](docs/RaceWeekApi.md#raceweekdetailsget) | **GET** /race-week/details | 
*RaceWeekApi* | [**RaceWeekLiveGet**](docs/RaceWeekApi.md#raceweekliveget) | **GET** /race-week/live | 
*RaceWeekApi* | [**RaceWeekSeasonGet**](docs/RaceWeekApi.md#raceweekseasonget) | **GET** /race-week/season | 
*SeriesApi* | [**SeriesGet**](docs/SeriesApi.md#seriesget) | **GET** /series | 
*StatsApi* | [**StatsLoopStatsGet**](docs/StatsApi.md#statsloopstatsget) | **GET** /stats/loop-stats | 
*StatsApi* | [**StatsReportGet**](docs/StatsApi.md#statsreportget) | **GET** /stats/report | 
*StatsApi* | [**StatsReportsGet**](docs/StatsApi.md#statsreportsget) | **GET** /stats/reports | 
*StatsApi* | [**StatsSeasonGet**](docs/StatsApi.md#statsseasonget) | **GET** /stats/season | 
*TracksApi* | [**TrackDetailsGet**](docs/TracksApi.md#trackdetailsget) | **GET** /track-details | 
*TracksApi* | [**TracksGet**](docs/TracksApi.md#tracksget) | **GET** /tracks | 
*VehicleApi* | [**VehicleGet**](docs/VehicleApi.md#vehicleget) | **GET** /vehicle | 
*VehicleApi* | [**VehicleSeasonFinishesGet**](docs/VehicleApi.md#vehicleseasonfinishesget) | **GET** /vehicle/season-finishes | 
*VendorApi* | [**VendorCrlTestresultPost**](docs/VendorApi.md#vendorcrltestresultpost) | **POST** /vendor/crl_testresult | 
*VendorApi* | [**VendorTiresPost**](docs/VendorApi.md#vendortirespost) | **POST** /vendor/tires | 
*VendorApi* | [**VendorUtmOffsetsPost**](docs/VendorApi.md#vendorutmoffsetspost) | **POST** /vendor/utm_offsets | 
*VendorApi* | [**VendorWicketRequestPost**](docs/VendorApi.md#vendorwicketrequestpost) | **POST** /vendor/wicket_request | 

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ActiveRun](docs/ActiveRun.md)
 - [Model.AvailableReport](docs/AvailableReport.md)
 - [Model.AvailableReports](docs/AvailableReports.md)
 - [Model.Caution](docs/Caution.md)
 - [Model.ClientERDPDatapoint](docs/ClientERDPDatapoint.md)
 - [Model.ClientERDPSource](docs/ClientERDPSource.md)
 - [Model.ClientERDPTopic](docs/ClientERDPTopic.md)
 - [Model.Company](docs/Company.md)
 - [Model.CrlFormFoxResult](docs/CrlFormFoxResult.md)
 - [Model.DisciplineUpdate](docs/DisciplineUpdate.md)
 - [Model.Driver](docs/Driver.md)
 - [Model.DriverPointsSlim](docs/DriverPointsSlim.md)
 - [Model.DriverPointsView](docs/DriverPointsView.md)
 - [Model.DriverSummary](docs/DriverSummary.md)
 - [Model.DriverSummaryByPrincipalRaceID](docs/DriverSummaryByPrincipalRaceID.md)
 - [Model.DriverSummaryBySeason](docs/DriverSummaryBySeason.md)
 - [Model.DriverSummaryByTrack](docs/DriverSummaryByTrack.md)
 - [Model.DriverSummaryByTrackType](docs/DriverSummaryByTrackType.md)
 - [Model.FastestLapAwards](docs/FastestLapAwards.md)
 - [Model.Flag](docs/Flag.md)
 - [Model.LapLeader](docs/LapLeader.md)
 - [Model.LoopStat](docs/LoopStat.md)
 - [Model.ManufacturerPoint](docs/ManufacturerPoint.md)
 - [Model.OSSScan](docs/OSSScan.md)
 - [Model.OpticalTrackingUTMOffset](docs/OpticalTrackingUTMOffset.md)
 - [Model.OpticalTrackingUTMOffsetListETLSaveResult](docs/OpticalTrackingUTMOffsetListETLSaveResult.md)
 - [Model.OwnerPoint](docs/OwnerPoint.md)
 - [Model.PitPath](docs/PitPath.md)
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
 - [Model.Result](docs/Result.md)
 - [Model.RosterMember](docs/RosterMember.md)
 - [Model.RunDetails](docs/RunDetails.md)
 - [Model.RunEntry](docs/RunEntry.md)
 - [Model.RunResult](docs/RunResult.md)
 - [Model.RunResults](docs/RunResults.md)
 - [Model.RunState](docs/RunState.md)
 - [Model.RunType](docs/RunType.md)
 - [Model.SeasonStat](docs/SeasonStat.md)
 - [Model.Series](docs/Series.md)
 - [Model.Stage](docs/Stage.md)
 - [Model.StageResult](docs/StageResult.md)
 - [Model.StageRunResults](docs/StageRunResults.md)
 - [Model.Status](docs/Status.md)
 - [Model.TeamRoster](docs/TeamRoster.md)
 - [Model.Tire](docs/Tire.md)
 - [Model.TireListETLSaveResult](docs/TireListETLSaveResult.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.Track](docs/Track.md)
 - [Model.TrackConfiguration](docs/TrackConfiguration.md)
 - [Model.TrackDetails](docs/TrackDetails.md)
 - [Model.TrackPath](docs/TrackPath.md)
 - [Model.VehicleDetails](docs/VehicleDetails.md)
 - [Model.VehicleWeight](docs/VehicleWeight.md)
 - [Model.WeekendSchedule](docs/WeekendSchedule.md)
 - [Model.WicketAccountIds](docs/WicketAccountIds.md)
 - [Model.WicketRequest](docs/WicketRequest.md)
 - [Model.WicketResponse](docs/WicketResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer
