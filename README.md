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
*CompanyApi* | [**CompanySearchGet**](docs/CompanyApi.md#companysearchget) | **GET** /company/search | 
*DataManagementApi* | [**DataManagementCautionsGet**](docs/DataManagementApi.md#datamanagementcautionsget) | **GET** /data-management/cautions | 
*DataManagementApi* | [**DataManagementCautionsPost**](docs/DataManagementApi.md#datamanagementcautionspost) | **POST** /data-management/cautions | 
*DataManagementApi* | [**DataManagementCompaniesGet**](docs/DataManagementApi.md#datamanagementcompaniesget) | **GET** /data-management/companies | 
*DataManagementApi* | [**DataManagementCompaniesPost**](docs/DataManagementApi.md#datamanagementcompaniespost) | **POST** /data-management/companies | 
*DataManagementApi* | [**DataManagementCrewchiefsGet**](docs/DataManagementApi.md#datamanagementcrewchiefsget) | **GET** /data-management/crewchiefs | 
*DataManagementApi* | [**DataManagementCrewchiefsPost**](docs/DataManagementApi.md#datamanagementcrewchiefspost) | **POST** /data-management/crewchiefs | 
*DataManagementApi* | [**DataManagementDisciplineUpdatesGet**](docs/DataManagementApi.md#datamanagementdisciplineupdatesget) | **GET** /data-management/discipline-updates | 
*DataManagementApi* | [**DataManagementDisciplineUpdatesPost**](docs/DataManagementApi.md#datamanagementdisciplineupdatespost) | **POST** /data-management/discipline-updates | 
*DataManagementApi* | [**DataManagementDriverPointsGet**](docs/DataManagementApi.md#datamanagementdriverpointsget) | **GET** /data-management/driver-points | 
*DataManagementApi* | [**DataManagementDriverPointsPost**](docs/DataManagementApi.md#datamanagementdriverpointspost) | **POST** /data-management/driver-points | 
*DataManagementApi* | [**DataManagementDriverSummariesByPrincipalRaceGet**](docs/DataManagementApi.md#datamanagementdriversummariesbyprincipalraceget) | **GET** /data-management/driver-summaries-by-principal-race | 
*DataManagementApi* | [**DataManagementDriverSummariesByPrincipalRacePost**](docs/DataManagementApi.md#datamanagementdriversummariesbyprincipalracepost) | **POST** /data-management/driver-summaries-by-principal-race | 
*DataManagementApi* | [**DataManagementDriverSummariesBySeasonGet**](docs/DataManagementApi.md#datamanagementdriversummariesbyseasonget) | **GET** /data-management/driver-summaries-by-season | 
*DataManagementApi* | [**DataManagementDriverSummariesBySeasonPost**](docs/DataManagementApi.md#datamanagementdriversummariesbyseasonpost) | **POST** /data-management/driver-summaries-by-season | 
*DataManagementApi* | [**DataManagementDriverSummariesByTrackGet**](docs/DataManagementApi.md#datamanagementdriversummariesbytrackget) | **GET** /data-management/driver-summaries-by-track | 
*DataManagementApi* | [**DataManagementDriverSummariesByTrackPost**](docs/DataManagementApi.md#datamanagementdriversummariesbytrackpost) | **POST** /data-management/driver-summaries-by-track | 
*DataManagementApi* | [**DataManagementDriverSummariesByTrackTypeGet**](docs/DataManagementApi.md#datamanagementdriversummariesbytracktypeget) | **GET** /data-management/driver-summaries-by-track-type | 
*DataManagementApi* | [**DataManagementDriverSummariesByTrackTypePost**](docs/DataManagementApi.md#datamanagementdriversummariesbytracktypepost) | **POST** /data-management/driver-summaries-by-track-type | 
*DataManagementApi* | [**DataManagementDriversGet**](docs/DataManagementApi.md#datamanagementdriversget) | **GET** /data-management/drivers | 
*DataManagementApi* | [**DataManagementDriversPost**](docs/DataManagementApi.md#datamanagementdriverspost) | **POST** /data-management/drivers | 
*DataManagementApi* | [**DataManagementErdpDatapointsGet**](docs/DataManagementApi.md#datamanagementerdpdatapointsget) | **GET** /data-management/erdp-datapoints | 
*DataManagementApi* | [**DataManagementErdpDatapointsPost**](docs/DataManagementApi.md#datamanagementerdpdatapointspost) | **POST** /data-management/erdp-datapoints | 
*DataManagementApi* | [**DataManagementErdpSourcesGet**](docs/DataManagementApi.md#datamanagementerdpsourcesget) | **GET** /data-management/erdp-sources | 
*DataManagementApi* | [**DataManagementErdpSourcesPost**](docs/DataManagementApi.md#datamanagementerdpsourcespost) | **POST** /data-management/erdp-sources | 
*DataManagementApi* | [**DataManagementEtlSchedulesGet**](docs/DataManagementApi.md#datamanagementetlschedulesget) | **GET** /data-management/etl-schedules | 
*DataManagementApi* | [**DataManagementEtlSchedulesPost**](docs/DataManagementApi.md#datamanagementetlschedulespost) | **POST** /data-management/etl-schedules | 
*DataManagementApi* | [**DataManagementFlagsGet**](docs/DataManagementApi.md#datamanagementflagsget) | **GET** /data-management/flags | 
*DataManagementApi* | [**DataManagementFlagsPost**](docs/DataManagementApi.md#datamanagementflagspost) | **POST** /data-management/flags | 
*DataManagementApi* | [**DataManagementInfractionsGet**](docs/DataManagementApi.md#datamanagementinfractionsget) | **GET** /data-management/infractions | 
*DataManagementApi* | [**DataManagementInfractionsPost**](docs/DataManagementApi.md#datamanagementinfractionspost) | **POST** /data-management/infractions | 
*DataManagementApi* | [**DataManagementLapleadersGet**](docs/DataManagementApi.md#datamanagementlapleadersget) | **GET** /data-management/lapleaders | 
*DataManagementApi* | [**DataManagementLapleadersPost**](docs/DataManagementApi.md#datamanagementlapleaderspost) | **POST** /data-management/lapleaders | 
*DataManagementApi* | [**DataManagementLoopstatsGet**](docs/DataManagementApi.md#datamanagementloopstatsget) | **GET** /data-management/loopstats | 
*DataManagementApi* | [**DataManagementLoopstatsPost**](docs/DataManagementApi.md#datamanagementloopstatspost) | **POST** /data-management/loopstats | 
*DataManagementApi* | [**DataManagementManufacturerPointsGet**](docs/DataManagementApi.md#datamanagementmanufacturerpointsget) | **GET** /data-management/manufacturer-points | 
*DataManagementApi* | [**DataManagementManufacturerPointsPost**](docs/DataManagementApi.md#datamanagementmanufacturerpointspost) | **POST** /data-management/manufacturer-points | 
*DataManagementApi* | [**DataManagementOpticalTrackingUtmoffsetsGet**](docs/DataManagementApi.md#datamanagementopticaltrackingutmoffsetsget) | **GET** /data-management/optical-tracking-utmoffsets | 
*DataManagementApi* | [**DataManagementOpticalTrackingUtmoffsetsPost**](docs/DataManagementApi.md#datamanagementopticaltrackingutmoffsetspost) | **POST** /data-management/optical-tracking-utmoffsets | 
*DataManagementApi* | [**DataManagementOrganizationsGet**](docs/DataManagementApi.md#datamanagementorganizationsget) | **GET** /data-management/organizations | 
*DataManagementApi* | [**DataManagementOrganizationsPost**](docs/DataManagementApi.md#datamanagementorganizationspost) | **POST** /data-management/organizations | 
*DataManagementApi* | [**DataManagementOssGet**](docs/DataManagementApi.md#datamanagementossget) | **GET** /data-management/oss | 
*DataManagementApi* | [**DataManagementOssPost**](docs/DataManagementApi.md#datamanagementosspost) | **POST** /data-management/oss | 
*DataManagementApi* | [**DataManagementOwnerPointsGet**](docs/DataManagementApi.md#datamanagementownerpointsget) | **GET** /data-management/owner-points | 
*DataManagementApi* | [**DataManagementOwnerPointsPost**](docs/DataManagementApi.md#datamanagementownerpointspost) | **POST** /data-management/owner-points | 
*DataManagementApi* | [**DataManagementOwnersGet**](docs/DataManagementApi.md#datamanagementownersget) | **GET** /data-management/owners | 
*DataManagementApi* | [**DataManagementOwnersPost**](docs/DataManagementApi.md#datamanagementownerspost) | **POST** /data-management/owners | 
*DataManagementApi* | [**DataManagementPitPathsGet**](docs/DataManagementApi.md#datamanagementpitpathsget) | **GET** /data-management/pit-paths | 
*DataManagementApi* | [**DataManagementPitPathsPost**](docs/DataManagementApi.md#datamanagementpitpathspost) | **POST** /data-management/pit-paths | 
*DataManagementApi* | [**DataManagementPitstopsGet**](docs/DataManagementApi.md#datamanagementpitstopsget) | **GET** /data-management/pitstops | 
*DataManagementApi* | [**DataManagementPitstopsPost**](docs/DataManagementApi.md#datamanagementpitstopspost) | **POST** /data-management/pitstops | 
*DataManagementApi* | [**DataManagementPracticeResultsGet**](docs/DataManagementApi.md#datamanagementpracticeresultsget) | **GET** /data-management/practice-results | 
*DataManagementApi* | [**DataManagementPracticeResultsPost**](docs/DataManagementApi.md#datamanagementpracticeresultspost) | **POST** /data-management/practice-results | 
*DataManagementApi* | [**DataManagementProcessingStateGet**](docs/DataManagementApi.md#datamanagementprocessingstateget) | **GET** /data-management/processing-state | 
*DataManagementApi* | [**DataManagementQualifyingResultsGet**](docs/DataManagementApi.md#datamanagementqualifyingresultsget) | **GET** /data-management/qualifying-results | 
*DataManagementApi* | [**DataManagementQualifyingResultsPost**](docs/DataManagementApi.md#datamanagementqualifyingresultspost) | **POST** /data-management/qualifying-results | 
*DataManagementApi* | [**DataManagementRaceDetailsGet**](docs/DataManagementApi.md#datamanagementracedetailsget) | **GET** /data-management/race-details | 
*DataManagementApi* | [**DataManagementRaceResultsGet**](docs/DataManagementApi.md#datamanagementraceresultsget) | **GET** /data-management/race-results | 
*DataManagementApi* | [**DataManagementRaceResultsPost**](docs/DataManagementApi.md#datamanagementraceresultspost) | **POST** /data-management/race-results | 
*DataManagementApi* | [**DataManagementRacesGet**](docs/DataManagementApi.md#datamanagementracesget) | **GET** /data-management/races | 
*DataManagementApi* | [**DataManagementRacesPost**](docs/DataManagementApi.md#datamanagementracespost) | **POST** /data-management/races | 
*DataManagementApi* | [**DataManagementRaceweeksGet**](docs/DataManagementApi.md#datamanagementraceweeksget) | **GET** /data-management/raceweeks | 
*DataManagementApi* | [**DataManagementRaceweeksPost**](docs/DataManagementApi.md#datamanagementraceweekspost) | **POST** /data-management/raceweeks | 
*DataManagementApi* | [**DataManagementRefreshTestingGet**](docs/DataManagementApi.md#datamanagementrefreshtestingget) | **GET** /data-management/refresh-testing | 
*DataManagementApi* | [**DataManagementRostersGet**](docs/DataManagementApi.md#datamanagementrostersget) | **GET** /data-management/rosters | 
*DataManagementApi* | [**DataManagementRostersPost**](docs/DataManagementApi.md#datamanagementrosterspost) | **POST** /data-management/rosters | 
*DataManagementApi* | [**DataManagementRunEntriesGet**](docs/DataManagementApi.md#datamanagementrunentriesget) | **GET** /data-management/run-entries | 
*DataManagementApi* | [**DataManagementRunEntriesPost**](docs/DataManagementApi.md#datamanagementrunentriespost) | **POST** /data-management/run-entries | 
*DataManagementApi* | [**DataManagementRunsGet**](docs/DataManagementApi.md#datamanagementrunsget) | **GET** /data-management/runs | 
*DataManagementApi* | [**DataManagementRunsPost**](docs/DataManagementApi.md#datamanagementrunspost) | **POST** /data-management/runs | 
*DataManagementApi* | [**DataManagementScheduledActivitiesGet**](docs/DataManagementApi.md#datamanagementscheduledactivitiesget) | **GET** /data-management/scheduled-activities | 
*DataManagementApi* | [**DataManagementScheduledActivitiesPost**](docs/DataManagementApi.md#datamanagementscheduledactivitiespost) | **POST** /data-management/scheduled-activities | 
*DataManagementApi* | [**DataManagementSeasonlistGet**](docs/DataManagementApi.md#datamanagementseasonlistget) | **GET** /data-management/seasonlist | 
*DataManagementApi* | [**DataManagementSeriesGet**](docs/DataManagementApi.md#datamanagementseriesget) | **GET** /data-management/series | 
*DataManagementApi* | [**DataManagementSeriesPost**](docs/DataManagementApi.md#datamanagementseriespost) | **POST** /data-management/series | 
*DataManagementApi* | [**DataManagementStageResultsGet**](docs/DataManagementApi.md#datamanagementstageresultsget) | **GET** /data-management/stage-results | 
*DataManagementApi* | [**DataManagementStageResultsPost**](docs/DataManagementApi.md#datamanagementstageresultspost) | **POST** /data-management/stage-results | 
*DataManagementApi* | [**DataManagementTrackConfigurationsGet**](docs/DataManagementApi.md#datamanagementtrackconfigurationsget) | **GET** /data-management/track-configurations | 
*DataManagementApi* | [**DataManagementTrackConfigurationsPost**](docs/DataManagementApi.md#datamanagementtrackconfigurationspost) | **POST** /data-management/track-configurations | 
*DataManagementApi* | [**DataManagementTrackPathsGet**](docs/DataManagementApi.md#datamanagementtrackpathsget) | **GET** /data-management/track-paths | 
*DataManagementApi* | [**DataManagementTrackPathsPost**](docs/DataManagementApi.md#datamanagementtrackpathspost) | **POST** /data-management/track-paths | 
*DataManagementApi* | [**DataManagementTracksGet**](docs/DataManagementApi.md#datamanagementtracksget) | **GET** /data-management/tracks | 
*DataManagementApi* | [**DataManagementTracksPost**](docs/DataManagementApi.md#datamanagementtrackspost) | **POST** /data-management/tracks | 
*DataManagementApi* | [**DataManagementVehicleWeightsGet**](docs/DataManagementApi.md#datamanagementvehicleweightsget) | **GET** /data-management/vehicle-weights | 
*DataManagementApi* | [**DataManagementVehicleWeightsPost**](docs/DataManagementApi.md#datamanagementvehicleweightspost) | **POST** /data-management/vehicle-weights | 
*DataManagementApi* | [**DataManagementVehiclesGet**](docs/DataManagementApi.md#datamanagementvehiclesget) | **GET** /data-management/vehicles | 
*DataManagementApi* | [**DataManagementVehiclesPost**](docs/DataManagementApi.md#datamanagementvehiclespost) | **POST** /data-management/vehicles | 
*DriverApi* | [**DriverGet**](docs/DriverApi.md#driverget) | **GET** /driver | 
*DriverApi* | [**DriverSeasonFinishesGet**](docs/DriverApi.md#driverseasonfinishesget) | **GET** /driver/season-finishes | 
*DriverApi* | [**DriverSeasonGet**](docs/DriverApi.md#driverseasonget) | **GET** /driver/season | 
*DriverSummaryApi* | [**DriverSummaryGet**](docs/DriverSummaryApi.md#driversummaryget) | **GET** /driver-summary | 
*ERDPApi* | [**ErdpTopicsGet**](docs/ERDPApi.md#erdptopicsget) | **GET** /erdp/topics | Get a users erdp topics.
*FeedbackApi* | [**FeedbackDevNotesGet**](docs/FeedbackApi.md#feedbackdevnotesget) | **GET** /feedback/dev-notes | 
*FeedbackApi* | [**FeedbackSubmitFeedbackPost**](docs/FeedbackApi.md#feedbacksubmitfeedbackpost) | **POST** /feedback/submit-feedback | 
*InspectionsApi* | [**InspectionsOssGet**](docs/InspectionsApi.md#inspectionsossget) | **GET** /inspections/oss | 
*InspectionsApi* | [**InspectionsVehicleWeightsGet**](docs/InspectionsApi.md#inspectionsvehicleweightsget) | **GET** /inspections/vehicle-weights | 
*InternalApi* | [**InternalErdpCompaniesGet**](docs/InternalApi.md#internalerdpcompaniesget) | **GET** /internal/erdp/companies | return list of company ids for erdp companies
*InternalApi* | [**InternalErdpDatapointsGet**](docs/InternalApi.md#internalerdpdatapointsget) | **GET** /internal/erdp/datapoints | Get ERDP Datapoints
*InternalApi* | [**InternalErdpDatapointsPost**](docs/InternalApi.md#internalerdpdatapointspost) | **POST** /internal/erdp/datapoints | Create ERDP Datapoints
*InternalApi* | [**InternalErdpIngestionDatapointsGet**](docs/InternalApi.md#internalerdpingestiondatapointsget) | **GET** /internal/erdp/ingestion_datapoints | Called by the ingestion service for publishing
*InternalApi* | [**InternalErdpIngestionSourcesGet**](docs/InternalApi.md#internalerdpingestionsourcesget) | **GET** /internal/erdp/ingestion_sources | Called by the ingestion service for publishing
*InternalApi* | [**InternalErdpSourcesGet**](docs/InternalApi.md#internalerdpsourcesget) | **GET** /internal/erdp/sources | Get ERDP Sources
*InternalApi* | [**InternalErdpSourcesPost**](docs/InternalApi.md#internalerdpsourcespost) | **POST** /internal/erdp/sources | Create ERDP Sources
*InternalApi* | [**InternalErdpSubscriptionsAuthServiceCompanyIdGet**](docs/InternalApi.md#internalerdpsubscriptionsauthservicecompanyidget) | **GET** /internal/erdp/subscriptions/auth_service/{companyId} | nats auth service calls with company id, returns the topics that the company is allowed to sub on
*InternalApi* | [**InternalErdpSubscriptionsCompanyIdGet**](docs/InternalApi.md#internalerdpsubscriptionscompanyidget) | **GET** /internal/erdp/subscriptions/{companyId} | Get Subscriptions by company id
*InternalApi* | [**InternalErdpSubscriptionsPost**](docs/InternalApi.md#internalerdpsubscriptionspost) | **POST** /internal/erdp/subscriptions | Create erdp subscriptions
*InternalApi* | [**InternalErdpTopicCompanyTypesCompanyTypeIdGet**](docs/InternalApi.md#internalerdptopiccompanytypescompanytypeidget) | **GET** /internal/erdp/topic_company_types/{company_type_id} | Get Topic Company Types by company id
*InternalApi* | [**InternalErdpTopicCompanyTypesGet**](docs/InternalApi.md#internalerdptopiccompanytypesget) | **GET** /internal/erdp/topic_company_types | Get Topic Company Types
*InternalApi* | [**InternalErdpTopicCompanyTypesPost**](docs/InternalApi.md#internalerdptopiccompanytypespost) | **POST** /internal/erdp/topic_company_types | Create Topic Company Types
*InternalApi* | [**InternalErdpTopicsGet**](docs/InternalApi.md#internalerdptopicsget) | **GET** /internal/erdp/topics | Get Topics
*InternalApi* | [**InternalErdpTopicsPost**](docs/InternalApi.md#internalerdptopicspost) | **POST** /internal/erdp/topics | Create Topic
*InternalApi* | [**InternalErdpVehicleSourcesGet**](docs/InternalApi.md#internalerdpvehiclesourcesget) | **GET** /internal/erdp/vehicle_sources | Get vehicle sources
*InternalApi* | [**InternalErdpVehicleSourcesPost**](docs/InternalApi.md#internalerdpvehiclesourcespost) | **POST** /internal/erdp/vehicle_sources | Create vehicle sources
*InternalApi* | [**InternalTiresGet**](docs/InternalApi.md#internaltiresget) | **GET** /internal/tires | tire service get tire data for enhanced tire data to nats
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
*TracksApi* | [**TrackDetailsGet**](docs/TracksApi.md#trackdetailsget) | **GET** /track-details | 
*TracksApi* | [**TracksGet**](docs/TracksApi.md#tracksget) | **GET** /tracks | 
*VehicleApi* | [**VehicleGet**](docs/VehicleApi.md#vehicleget) | **GET** /vehicle | 
*VehicleApi* | [**VehicleSeasonFinishesGet**](docs/VehicleApi.md#vehicleseasonfinishesget) | **GET** /vehicle/season-finishes | 
*VendorApi* | [**VendorCrlTestresultPost**](docs/VendorApi.md#vendorcrltestresultpost) | **POST** /vendor/crl_testresult | 
*VendorApi* | [**VendorTiresPost**](docs/VendorApi.md#vendortirespost) | **POST** /vendor/tires | 
*VendorApi* | [**VendorUtmOffsetsPost**](docs/VendorApi.md#vendorutmoffsetspost) | **POST** /vendor/utm_offsets | 

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Caution](docs/Caution.md)
 - [Model.CautionMapping](docs/CautionMapping.md)
 - [Model.CautionMappingListETLSaveResult](docs/CautionMappingListETLSaveResult.md)
 - [Model.ClientERDPDatapoint](docs/ClientERDPDatapoint.md)
 - [Model.ClientERDPSource](docs/ClientERDPSource.md)
 - [Model.ClientERDPTopic](docs/ClientERDPTopic.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyMapping](docs/CompanyMapping.md)
 - [Model.CompanyMappingListETLSaveResult](docs/CompanyMappingListETLSaveResult.md)
 - [Model.CreateSubscription](docs/CreateSubscription.md)
 - [Model.CreateSubscriptionListETLSaveResult](docs/CreateSubscriptionListETLSaveResult.md)
 - [Model.CreateTopic](docs/CreateTopic.md)
 - [Model.CreateTopicCompanyType](docs/CreateTopicCompanyType.md)
 - [Model.CreateTopicListETLSaveResult](docs/CreateTopicListETLSaveResult.md)
 - [Model.CrewChiefMapping](docs/CrewChiefMapping.md)
 - [Model.CrewChiefMappingListETLSaveResult](docs/CrewChiefMappingListETLSaveResult.md)
 - [Model.CrlFormFoxResult](docs/CrlFormFoxResult.md)
 - [Model.DMRaceDetails](docs/DMRaceDetails.md)
 - [Model.DevNote](docs/DevNote.md)
 - [Model.DisciplineUpdate](docs/DisciplineUpdate.md)
 - [Model.DisciplineUpdateMapping](docs/DisciplineUpdateMapping.md)
 - [Model.DisciplineUpdateMappingListETLSaveResult](docs/DisciplineUpdateMappingListETLSaveResult.md)
 - [Model.Driver](docs/Driver.md)
 - [Model.DriverMapping](docs/DriverMapping.md)
 - [Model.DriverMappingListETLSaveResult](docs/DriverMappingListETLSaveResult.md)
 - [Model.DriverPoint](docs/DriverPoint.md)
 - [Model.DriverPointMapping](docs/DriverPointMapping.md)
 - [Model.DriverPointMappingListETLSaveResult](docs/DriverPointMappingListETLSaveResult.md)
 - [Model.DriverSummary](docs/DriverSummary.md)
 - [Model.DriverSummaryByPrincipalRaceID](docs/DriverSummaryByPrincipalRaceID.md)
 - [Model.DriverSummaryByPrincipalRaceIDMapping](docs/DriverSummaryByPrincipalRaceIDMapping.md)
 - [Model.DriverSummaryByPrincipalRaceIDMappingListETLSaveResult](docs/DriverSummaryByPrincipalRaceIDMappingListETLSaveResult.md)
 - [Model.DriverSummaryBySeason](docs/DriverSummaryBySeason.md)
 - [Model.DriverSummaryBySeasonMapping](docs/DriverSummaryBySeasonMapping.md)
 - [Model.DriverSummaryBySeasonMappingListETLSaveResult](docs/DriverSummaryBySeasonMappingListETLSaveResult.md)
 - [Model.DriverSummaryByTrack](docs/DriverSummaryByTrack.md)
 - [Model.DriverSummaryByTrackMapping](docs/DriverSummaryByTrackMapping.md)
 - [Model.DriverSummaryByTrackMappingListETLSaveResult](docs/DriverSummaryByTrackMappingListETLSaveResult.md)
 - [Model.DriverSummaryByTrackType](docs/DriverSummaryByTrackType.md)
 - [Model.DriverSummaryByTrackTypeMapping](docs/DriverSummaryByTrackTypeMapping.md)
 - [Model.DriverSummaryByTrackTypeMappingListETLSaveResult](docs/DriverSummaryByTrackTypeMappingListETLSaveResult.md)
 - [Model.ERDPDatapoint](docs/ERDPDatapoint.md)
 - [Model.ERDPDatapointListETLSaveResult](docs/ERDPDatapointListETLSaveResult.md)
 - [Model.ERDPSource](docs/ERDPSource.md)
 - [Model.ERDPSourceListETLSaveResult](docs/ERDPSourceListETLSaveResult.md)
 - [Model.ERDPSourceVehicle](docs/ERDPSourceVehicle.md)
 - [Model.ERDPSourceVehicleListETLSaveResult](docs/ERDPSourceVehicleListETLSaveResult.md)
 - [Model.ERDPSubscription](docs/ERDPSubscription.md)
 - [Model.ERDPSubscriptionPaginatedResult](docs/ERDPSubscriptionPaginatedResult.md)
 - [Model.ERDPTopic](docs/ERDPTopic.md)
 - [Model.ERDPTopicCompanyType](docs/ERDPTopicCompanyType.md)
 - [Model.ERDPTopicCompanyTypeListETLSaveResult](docs/ERDPTopicCompanyTypeListETLSaveResult.md)
 - [Model.ERDPTopicCompanyTypePaginatedResult](docs/ERDPTopicCompanyTypePaginatedResult.md)
 - [Model.ERDPTopicPaginatedResult](docs/ERDPTopicPaginatedResult.md)
 - [Model.ERDPUserPermissions](docs/ERDPUserPermissions.md)
 - [Model.EditorCaution](docs/EditorCaution.md)
 - [Model.EditorCompany](docs/EditorCompany.md)
 - [Model.EditorCrewChief](docs/EditorCrewChief.md)
 - [Model.EditorDriver](docs/EditorDriver.md)
 - [Model.EditorDriverPoints](docs/EditorDriverPoints.md)
 - [Model.EditorDriverSummaryByPrincipalRaceID](docs/EditorDriverSummaryByPrincipalRaceID.md)
 - [Model.EditorDriverSummaryBySeason](docs/EditorDriverSummaryBySeason.md)
 - [Model.EditorDriverSummaryByTrack](docs/EditorDriverSummaryByTrack.md)
 - [Model.EditorDriverSummaryByTrackType](docs/EditorDriverSummaryByTrackType.md)
 - [Model.EditorFlag](docs/EditorFlag.md)
 - [Model.EditorInspectionDisciplineResult](docs/EditorInspectionDisciplineResult.md)
 - [Model.EditorLapLeader](docs/EditorLapLeader.md)
 - [Model.EditorLoopStat](docs/EditorLoopStat.md)
 - [Model.EditorManufacturerPoints](docs/EditorManufacturerPoints.md)
 - [Model.EditorNextGenDataPoint](docs/EditorNextGenDataPoint.md)
 - [Model.EditorNextGenSource](docs/EditorNextGenSource.md)
 - [Model.EditorOSSScan](docs/EditorOSSScan.md)
 - [Model.EditorOpticalTrackingUTMOffset](docs/EditorOpticalTrackingUTMOffset.md)
 - [Model.EditorOrganization](docs/EditorOrganization.md)
 - [Model.EditorOwner](docs/EditorOwner.md)
 - [Model.EditorOwnerPoints](docs/EditorOwnerPoints.md)
 - [Model.EditorPitPath](docs/EditorPitPath.md)
 - [Model.EditorPitstop](docs/EditorPitstop.md)
 - [Model.EditorPracticeResult](docs/EditorPracticeResult.md)
 - [Model.EditorQualifyingResult](docs/EditorQualifyingResult.md)
 - [Model.EditorRace](docs/EditorRace.md)
 - [Model.EditorRaceInfraction](docs/EditorRaceInfraction.md)
 - [Model.EditorRaceResult](docs/EditorRaceResult.md)
 - [Model.EditorRaceWeek](docs/EditorRaceWeek.md)
 - [Model.EditorRoster](docs/EditorRoster.md)
 - [Model.EditorRun](docs/EditorRun.md)
 - [Model.EditorRunEntry](docs/EditorRunEntry.md)
 - [Model.EditorSeries](docs/EditorSeries.md)
 - [Model.EditorStageResult](docs/EditorStageResult.md)
 - [Model.EditorTrack](docs/EditorTrack.md)
 - [Model.EditorTrackConfiguration](docs/EditorTrackConfiguration.md)
 - [Model.EditorTrackPath](docs/EditorTrackPath.md)
 - [Model.EditorVehicle](docs/EditorVehicle.md)
 - [Model.EditorVehicleWeight](docs/EditorVehicleWeight.md)
 - [Model.EditorWeekendSchedule](docs/EditorWeekendSchedule.md)
 - [Model.ExtendedRunEntry](docs/ExtendedRunEntry.md)
 - [Model.Feedback](docs/Feedback.md)
 - [Model.Flag](docs/Flag.md)
 - [Model.FlagMapping](docs/FlagMapping.md)
 - [Model.FlagMappingListETLSaveResult](docs/FlagMappingListETLSaveResult.md)
 - [Model.InfractionMapping](docs/InfractionMapping.md)
 - [Model.InfractionMappingListETLSaveResult](docs/InfractionMappingListETLSaveResult.md)
 - [Model.LapLeader](docs/LapLeader.md)
 - [Model.LapLeaderMapping](docs/LapLeaderMapping.md)
 - [Model.LapLeaderMappingListETLSaveResult](docs/LapLeaderMappingListETLSaveResult.md)
 - [Model.LoopStat](docs/LoopStat.md)
 - [Model.LoopStatMapping](docs/LoopStatMapping.md)
 - [Model.LoopStatMappingListETLSaveResult](docs/LoopStatMappingListETLSaveResult.md)
 - [Model.ManufacturerPoint](docs/ManufacturerPoint.md)
 - [Model.ManufacturerPointMapping](docs/ManufacturerPointMapping.md)
 - [Model.ManufacturerPointMappingListETLSaveResult](docs/ManufacturerPointMappingListETLSaveResult.md)
 - [Model.NextGenDatapointMapping](docs/NextGenDatapointMapping.md)
 - [Model.NextGenDatapointMappingListETLSaveResult](docs/NextGenDatapointMappingListETLSaveResult.md)
 - [Model.NextGenSourceMapping](docs/NextGenSourceMapping.md)
 - [Model.NextGenSourceMappingListETLSaveResult](docs/NextGenSourceMappingListETLSaveResult.md)
 - [Model.OSSMapping](docs/OSSMapping.md)
 - [Model.OSSMappingListETLSaveResult](docs/OSSMappingListETLSaveResult.md)
 - [Model.OSSScan](docs/OSSScan.md)
 - [Model.OpticalTrackingUTMOffset](docs/OpticalTrackingUTMOffset.md)
 - [Model.OpticalTrackingUTMOffsetListETLSaveResult](docs/OpticalTrackingUTMOffsetListETLSaveResult.md)
 - [Model.OpticalTrackingUTMOffsetMapping](docs/OpticalTrackingUTMOffsetMapping.md)
 - [Model.OpticalTrackingUTMOffsetMappingListETLSaveResult](docs/OpticalTrackingUTMOffsetMappingListETLSaveResult.md)
 - [Model.OrganizationMapping](docs/OrganizationMapping.md)
 - [Model.OrganizationMappingListETLSaveResult](docs/OrganizationMappingListETLSaveResult.md)
 - [Model.OwnerMapping](docs/OwnerMapping.md)
 - [Model.OwnerMappingListETLSaveResult](docs/OwnerMappingListETLSaveResult.md)
 - [Model.OwnerPoint](docs/OwnerPoint.md)
 - [Model.OwnerPointMapping](docs/OwnerPointMapping.md)
 - [Model.OwnerPointMappingListETLSaveResult](docs/OwnerPointMappingListETLSaveResult.md)
 - [Model.PitPath](docs/PitPath.md)
 - [Model.PitPathMapping](docs/PitPathMapping.md)
 - [Model.PitPathMappingListETLSaveResult](docs/PitPathMappingListETLSaveResult.md)
 - [Model.Pitstop](docs/Pitstop.md)
 - [Model.PitstopMapping](docs/PitstopMapping.md)
 - [Model.PitstopMappingListETLSaveResult](docs/PitstopMappingListETLSaveResult.md)
 - [Model.PracticeResultMapping](docs/PracticeResultMapping.md)
 - [Model.PracticeResultMappingListETLSaveResult](docs/PracticeResultMappingListETLSaveResult.md)
 - [Model.PracticeRunResults](docs/PracticeRunResults.md)
 - [Model.ProcessingState](docs/ProcessingState.md)
 - [Model.PublishState](docs/PublishState.md)
 - [Model.QualifyingResultMapping](docs/QualifyingResultMapping.md)
 - [Model.QualifyingResultMappingListETLSaveResult](docs/QualifyingResultMappingListETLSaveResult.md)
 - [Model.QualifyingRunResults](docs/QualifyingRunResults.md)
 - [Model.Race](docs/Race.md)
 - [Model.RaceDetails](docs/RaceDetails.md)
 - [Model.RaceInfraction](docs/RaceInfraction.md)
 - [Model.RaceMapping](docs/RaceMapping.md)
 - [Model.RaceMappingListETLSaveResult](docs/RaceMappingListETLSaveResult.md)
 - [Model.RaceResult](docs/RaceResult.md)
 - [Model.RaceResultMapping](docs/RaceResultMapping.md)
 - [Model.RaceResultMappingListETLSaveResult](docs/RaceResultMappingListETLSaveResult.md)
 - [Model.RaceResultSummary](docs/RaceResultSummary.md)
 - [Model.RaceRunResults](docs/RaceRunResults.md)
 - [Model.RaceViewModel](docs/RaceViewModel.md)
 - [Model.RaceWeek](docs/RaceWeek.md)
 - [Model.RaceWeekDetails](docs/RaceWeekDetails.md)
 - [Model.RaceWeekMapping](docs/RaceWeekMapping.md)
 - [Model.RaceWeekMappingListETLSaveResult](docs/RaceWeekMappingListETLSaveResult.md)
 - [Model.RosterMapping](docs/RosterMapping.md)
 - [Model.RosterMappingListETLSaveResult](docs/RosterMappingListETLSaveResult.md)
 - [Model.RosterMember](docs/RosterMember.md)
 - [Model.RunDetails](docs/RunDetails.md)
 - [Model.RunEntry](docs/RunEntry.md)
 - [Model.RunEntryMapping](docs/RunEntryMapping.md)
 - [Model.RunEntryMappingListETLSaveResult](docs/RunEntryMappingListETLSaveResult.md)
 - [Model.RunMapping](docs/RunMapping.md)
 - [Model.RunMappingListETLSaveResult](docs/RunMappingListETLSaveResult.md)
 - [Model.RunResult](docs/RunResult.md)
 - [Model.RunState](docs/RunState.md)
 - [Model.RunType](docs/RunType.md)
 - [Model.ScheduledActionSchedule](docs/ScheduledActionSchedule.md)
 - [Model.ScheduledActionScheduleListETLSaveResult](docs/ScheduledActionScheduleListETLSaveResult.md)
 - [Model.Series](docs/Series.md)
 - [Model.SeriesMapping](docs/SeriesMapping.md)
 - [Model.SeriesMappingListETLSaveResult](docs/SeriesMappingListETLSaveResult.md)
 - [Model.StageResult](docs/StageResult.md)
 - [Model.StageResultMapping](docs/StageResultMapping.md)
 - [Model.StageResultMappingListETLSaveResult](docs/StageResultMappingListETLSaveResult.md)
 - [Model.StageRunResults](docs/StageRunResults.md)
 - [Model.TeamRoster](docs/TeamRoster.md)
 - [Model.Tire](docs/Tire.md)
 - [Model.TireListETLSaveResult](docs/TireListETLSaveResult.md)
 - [Model.TokenResponse](docs/TokenResponse.md)
 - [Model.Track](docs/Track.md)
 - [Model.TrackConfiguration](docs/TrackConfiguration.md)
 - [Model.TrackConfigurationMapping](docs/TrackConfigurationMapping.md)
 - [Model.TrackConfigurationMappingListETLSaveResult](docs/TrackConfigurationMappingListETLSaveResult.md)
 - [Model.TrackDetails](docs/TrackDetails.md)
 - [Model.TrackMapping](docs/TrackMapping.md)
 - [Model.TrackMappingListETLSaveResult](docs/TrackMappingListETLSaveResult.md)
 - [Model.TrackPath](docs/TrackPath.md)
 - [Model.TrackPathMapping](docs/TrackPathMapping.md)
 - [Model.TrackPathMappingListETLSaveResult](docs/TrackPathMappingListETLSaveResult.md)
 - [Model.VehicleDetails](docs/VehicleDetails.md)
 - [Model.VehicleMapping](docs/VehicleMapping.md)
 - [Model.VehicleMappingListETLSaveResult](docs/VehicleMappingListETLSaveResult.md)
 - [Model.VehicleWeight](docs/VehicleWeight.md)
 - [Model.VehicleWeightMapping](docs/VehicleWeightMapping.md)
 - [Model.VehicleWeightMappingListETLSaveResult](docs/VehicleWeightMappingListETLSaveResult.md)
 - [Model.WeekendSchedule](docs/WeekendSchedule.md)
 - [Model.WeekendScheduleMapping](docs/WeekendScheduleMapping.md)
 - [Model.WeekendScheduleMappingListETLSaveResult](docs/WeekendScheduleMappingListETLSaveResult.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer
