# NASCAR.Data.Client.Api.StatsApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatsLapsGet**](StatsApi.md#statslapsget) | **GET** /stats/laps | Retrieves a bounded page of per-passing lap statistics using optional filters.
[**StatsLoopStatsGet**](StatsApi.md#statsloopstatsget) | **GET** /stats/loop-stats | Retrieves a list of driver loop statistics for a given race.
[**StatsRaceGet**](StatsApi.md#statsraceget) | **GET** /stats/race | Retrieves a bounded page of driver race statistics using optional filters.
[**StatsReportGet**](StatsApi.md#statsreportget) | **GET** /stats/report | Retrieves a specific statistical report file for a given key, which typically corresponds to a report path or identifier returned by /reports.
[**StatsReportsGet**](StatsApi.md#statsreportsget) | **GET** /stats/reports | Retrieves a list of available statistical report paths for a given race.
[**StatsSeasonGet**](StatsApi.md#statsseasonget) | **GET** /stats/season | Retrieves a list of driver season statistics for a given series and season.

<a name="statslapsget"></a>
# **StatsLapsGet**
> LapStatStatsPage StatsLapsGet (int? raceEventKey = null, int? runId = null, int? competitorId = null, int? lapFrom = null, int? lapTo = null, int? leaderLapFrom = null, int? leaderLapTo = null, int? flagState = null, int? raceRankFrom = null, int? raceRankTo = null, int? trackPositionFrom = null, int? trackPositionTo = null, int? laptimeMsFrom = null, int? laptimeMsTo = null, DateTimeOffset? dateFrom = null, DateTimeOffset? dateTo = null, int? page = null, int? pageSize = null, int? raceId = null, int? historyRaceId = null, int? seriesId = null, int? season = null, int? seasonFrom = null, int? seasonTo = null, int? driverId = null, string vehicleNumber = null, string firstName = null, string lastName = null, string driverName = null, int? trackId = null, string track = null)

Retrieves a bounded page of per-passing lap statistics using optional filters.

All filters are optional and combined with AND; no scope is required. Common filters behave as on /stats/race,  except that dates filter start_time (the race's scheduled start, denormalized onto every lap row; inclusive  UTC values) and finishing-position filters do not apply here (no reliable per-lap source; see /stats/race).  Additional filters cover race_event_key (source timing event), run_id, competitor_id, lap_count, leader_lap,  flag_state, race_rank, track_position and laptime_ms. Null source measurements do not match numeric bounds.  Rows are ordered by race_id, race_event_key, run_id, passing_id, not lap number, to preserve stable unique passing identities.  page defaults to 1; page_size defaults to 1000 (maximum 5000). Response: items, page, page_size, has_more.  No total count is computed. Pages can shift if an import completes between requests.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StatsLapsGetExample
    {
        public void main()
        {

            var apiInstance = new StatsApi();
            var raceEventKey = 56;  // int? | Source timing race-event key, independent of the NASCAR One/API race_id. (optional) 
            var runId = 56;  // int? | Source timing run identifier. (optional) 
            var competitorId = 56;  // int? | Source competitor identifier, not the API driver identifier. (optional) 
            var lapFrom = 56;  // int? | Inclusive minimum competitor lap_count (zero is allowed). (optional) 
            var lapTo = 56;  // int? | Inclusive maximum competitor lap_count (zero is allowed). (optional) 
            var leaderLapFrom = 56;  // int? | Inclusive minimum leader_lap (zero is allowed). (optional) 
            var leaderLapTo = 56;  // int? | Inclusive maximum leader_lap (zero is allowed). (optional) 
            var flagState = 56;  // int? | Exact source flag-state code (zero or greater). (optional) 
            var raceRankFrom = 56;  // int? | Inclusive minimum race rank (1 or greater). (optional) 
            var raceRankTo = 56;  // int? | Inclusive maximum race rank (1 or greater). (optional) 
            var trackPositionFrom = 56;  // int? | Inclusive minimum track position (1 or greater). (optional) 
            var trackPositionTo = 56;  // int? | Inclusive maximum track position (1 or greater). (optional) 
            var laptimeMsFrom = 56;  // int? | Inclusive minimum lap time in milliseconds (zero or greater). (optional) 
            var laptimeMsTo = 56;  // int? | Inclusive maximum lap time in milliseconds (zero or greater). (optional) 
            var dateFrom = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Inclusive lower UTC bound for start_time (the race's scheduled start, denormalized onto every lap row), year 1900-9999. Supply no source-local offset; this is UTC, unlike RaceStatsQuery.date_from. (optional) 
            var dateTo = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Inclusive upper UTC bound for start_time (the race's scheduled start, denormalized onto every lap row), year 1900-9999. A date without a time means midnight, not end of day. This is UTC, unlike RaceStatsQuery.date_to. (optional) 
            var page = 56;  // int? | One-based page number. The resulting offset must fit a signed 32-bit integer. (optional) 
            var pageSize = 56;  // int? | Rows per page: 1-5000; defaults to 1000. Pagination cannot be disabled. (optional) 
            var raceId = 56;  // int? | NASCAR One/API race identifier (not the History race identifier). (optional) 
            var historyRaceId = 56;  // int? | History race identifier, independent of race_id. (optional) 
            var seriesId = 56;  // int? | API series identifier. (optional) 
            var season = 56;  // int? | Exact season year (1900-9999). (optional) 
            var seasonFrom = 56;  // int? | Inclusive first season year (1900-9999). (optional) 
            var seasonTo = 56;  // int? | Inclusive last season year (1900-9999). (optional) 
            var driverId = 56;  // int? | API driver identifier. Records without a driver mapping cannot match this filter. (optional) 
            var vehicleNumber = vehicleNumber_example;  // string | Exact vehicle number as text; leading zeroes are significant. (optional) 
            var firstName = firstName_example;  // string | Substring of the driver's first name, using database collation. (optional) 
            var lastName = lastName_example;  // string | Substring of the driver's last name, using database collation. (optional) 
            var driverName = driverName_example;  // string | Substring of first name + space + last name, using database collation. (optional) 
            var trackId = 56;  // int? | NASCAR One/API track identifier. (optional) 
            var track = track_example;  // string | Substring of the track name, using database collation. (optional) 

            try
            {
                // Retrieves a bounded page of per-passing lap statistics using optional filters.
                LapStatStatsPage result = apiInstance.StatsLapsGet(raceEventKey, runId, competitorId, lapFrom, lapTo, leaderLapFrom, leaderLapTo, flagState, raceRankFrom, raceRankTo, trackPositionFrom, trackPositionTo, laptimeMsFrom, laptimeMsTo, dateFrom, dateTo, page, pageSize, raceId, historyRaceId, seriesId, season, seasonFrom, seasonTo, driverId, vehicleNumber, firstName, lastName, driverName, trackId, track);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsLapsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceEventKey** | **int?**| Source timing race-event key, independent of the NASCAR One/API race_id. | [optional] 
 **runId** | **int?**| Source timing run identifier. | [optional] 
 **competitorId** | **int?**| Source competitor identifier, not the API driver identifier. | [optional] 
 **lapFrom** | **int?**| Inclusive minimum competitor lap_count (zero is allowed). | [optional] 
 **lapTo** | **int?**| Inclusive maximum competitor lap_count (zero is allowed). | [optional] 
 **leaderLapFrom** | **int?**| Inclusive minimum leader_lap (zero is allowed). | [optional] 
 **leaderLapTo** | **int?**| Inclusive maximum leader_lap (zero is allowed). | [optional] 
 **flagState** | **int?**| Exact source flag-state code (zero or greater). | [optional] 
 **raceRankFrom** | **int?**| Inclusive minimum race rank (1 or greater). | [optional] 
 **raceRankTo** | **int?**| Inclusive maximum race rank (1 or greater). | [optional] 
 **trackPositionFrom** | **int?**| Inclusive minimum track position (1 or greater). | [optional] 
 **trackPositionTo** | **int?**| Inclusive maximum track position (1 or greater). | [optional] 
 **laptimeMsFrom** | **int?**| Inclusive minimum lap time in milliseconds (zero or greater). | [optional] 
 **laptimeMsTo** | **int?**| Inclusive maximum lap time in milliseconds (zero or greater). | [optional] 
 **dateFrom** | **DateTimeOffset?**| Inclusive lower UTC bound for start_time (the race&#x27;s scheduled start, denormalized onto every lap row), year 1900-9999. Supply no source-local offset; this is UTC, unlike RaceStatsQuery.date_from. | [optional] 
 **dateTo** | **DateTimeOffset?**| Inclusive upper UTC bound for start_time (the race&#x27;s scheduled start, denormalized onto every lap row), year 1900-9999. A date without a time means midnight, not end of day. This is UTC, unlike RaceStatsQuery.date_to. | [optional] 
 **page** | **int?**| One-based page number. The resulting offset must fit a signed 32-bit integer. | [optional] 
 **pageSize** | **int?**| Rows per page: 1-5000; defaults to 1000. Pagination cannot be disabled. | [optional] 
 **raceId** | **int?**| NASCAR One/API race identifier (not the History race identifier). | [optional] 
 **historyRaceId** | **int?**| History race identifier, independent of race_id. | [optional] 
 **seriesId** | **int?**| API series identifier. | [optional] 
 **season** | **int?**| Exact season year (1900-9999). | [optional] 
 **seasonFrom** | **int?**| Inclusive first season year (1900-9999). | [optional] 
 **seasonTo** | **int?**| Inclusive last season year (1900-9999). | [optional] 
 **driverId** | **int?**| API driver identifier. Records without a driver mapping cannot match this filter. | [optional] 
 **vehicleNumber** | **string**| Exact vehicle number as text; leading zeroes are significant. | [optional] 
 **firstName** | **string**| Substring of the driver&#x27;s first name, using database collation. | [optional] 
 **lastName** | **string**| Substring of the driver&#x27;s last name, using database collation. | [optional] 
 **driverName** | **string**| Substring of first name + space + last name, using database collation. | [optional] 
 **trackId** | **int?**| NASCAR One/API track identifier. | [optional] 
 **track** | **string**| Substring of the track name, using database collation. | [optional] 

### Return type

[**LapStatStatsPage**](LapStatStatsPage.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="statsloopstatsget"></a>
# **StatsLoopStatsGet**
> Collection<LoopStat> StatsLoopStatsGet (int? raceId = null)

Retrieves a list of driver loop statistics for a given race.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StatsLoopStatsGetExample
    {
        public void main()
        {

            var apiInstance = new StatsApi();
            var raceId = 56;  // int? | The unique identifier of the race. (optional) 

            try
            {
                // Retrieves a list of driver loop statistics for a given race.
                Collection&lt;LoopStat&gt; result = apiInstance.StatsLoopStatsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsLoopStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**| The unique identifier of the race. | [optional] 

### Return type

[**Collection<LoopStat>**](LoopStat.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="statsraceget"></a>
# **StatsRaceGet**
> RaceStatStatsPage StatsRaceGet (int? historyDriverId = null, int? finishPositionFrom = null, int? finishPositionTo = null, int? page = null, int? pageSize = null, int? raceId = null, int? historyRaceId = null, int? seriesId = null, int? season = null, int? seasonFrom = null, int? seasonTo = null, int? driverId = null, string vehicleNumber = null, string firstName = null, string lastName = null, string driverName = null, int? trackId = null, string track = null, DateTimeOffset? dateFrom = null, DateTimeOffset? dateTo = null)

Retrieves a bounded page of driver race statistics using optional filters.

All filters are optional and combined with AND. No race, season, series or driver scope is required.  IDs distinguish NASCAR One/API identities from History identities; unmapped driver_id values remain null.  Vehicle numbers retain leading zeroes. Name/track filters use substring matching and database collation.  Dates are inclusive source-local clock values without a UTC offset, using actual_date then scheduled_date.  Rows are ordered by race_id, history_driver_id. page defaults to 1; page_size defaults to 1000 (maximum 5000).  The response contains items, page, page_size and has_more; no total count is computed.  Pages reflect the current snapshot and can shift if an import completes between requests.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StatsRaceGetExample
    {
        public void main()
        {

            var apiInstance = new StatsApi();
            var historyDriverId = 56;  // int? | History driver identifier, independent of the nullable API driver_id. (optional) 
            var finishPositionFrom = 56;  // int? | Inclusive minimum finishing position (1 or greater). (optional) 
            var finishPositionTo = 56;  // int? | Inclusive maximum finishing position (1 or greater). (optional) 
            var page = 56;  // int? | One-based page number. The resulting offset must fit a signed 32-bit integer. (optional) 
            var pageSize = 56;  // int? | Rows per page: 1-5000; defaults to 1000. Pagination cannot be disabled. (optional) 
            var raceId = 56;  // int? | NASCAR One/API race identifier (not the History race identifier). (optional) 
            var historyRaceId = 56;  // int? | History race identifier, independent of race_id. (optional) 
            var seriesId = 56;  // int? | API series identifier. (optional) 
            var season = 56;  // int? | Exact season year (1900-9999). (optional) 
            var seasonFrom = 56;  // int? | Inclusive first season year (1900-9999). (optional) 
            var seasonTo = 56;  // int? | Inclusive last season year (1900-9999). (optional) 
            var driverId = 56;  // int? | API driver identifier. Records without a driver mapping cannot match this filter. (optional) 
            var vehicleNumber = vehicleNumber_example;  // string | Exact vehicle number as text; leading zeroes are significant. (optional) 
            var firstName = firstName_example;  // string | Substring of the driver's first name, using database collation. (optional) 
            var lastName = lastName_example;  // string | Substring of the driver's last name, using database collation. (optional) 
            var driverName = driverName_example;  // string | Substring of first name + space + last name, using database collation. (optional) 
            var trackId = 56;  // int? | NASCAR One/API track identifier. (optional) 
            var track = track_example;  // string | Substring of the track name, using database collation. (optional) 
            var dateFrom = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Inclusive lower source-local date/time bound, year 1900-9999, filtering actual_date (falling back to scheduled_date). Supply no UTC offset. See LapStatsQuery.date_from for the lap endpoint's UTC-based semantics. (optional) 
            var dateTo = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Inclusive upper source-local date/time bound, year 1900-9999, filtering actual_date (falling back to scheduled_date). A date without a time means midnight, not end of day. Supply no UTC offset. See LapStatsQuery.date_to for the lap endpoint's UTC-based semantics. (optional) 

            try
            {
                // Retrieves a bounded page of driver race statistics using optional filters.
                RaceStatStatsPage result = apiInstance.StatsRaceGet(historyDriverId, finishPositionFrom, finishPositionTo, page, pageSize, raceId, historyRaceId, seriesId, season, seasonFrom, seasonTo, driverId, vehicleNumber, firstName, lastName, driverName, trackId, track, dateFrom, dateTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsRaceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historyDriverId** | **int?**| History driver identifier, independent of the nullable API driver_id. | [optional] 
 **finishPositionFrom** | **int?**| Inclusive minimum finishing position (1 or greater). | [optional] 
 **finishPositionTo** | **int?**| Inclusive maximum finishing position (1 or greater). | [optional] 
 **page** | **int?**| One-based page number. The resulting offset must fit a signed 32-bit integer. | [optional] 
 **pageSize** | **int?**| Rows per page: 1-5000; defaults to 1000. Pagination cannot be disabled. | [optional] 
 **raceId** | **int?**| NASCAR One/API race identifier (not the History race identifier). | [optional] 
 **historyRaceId** | **int?**| History race identifier, independent of race_id. | [optional] 
 **seriesId** | **int?**| API series identifier. | [optional] 
 **season** | **int?**| Exact season year (1900-9999). | [optional] 
 **seasonFrom** | **int?**| Inclusive first season year (1900-9999). | [optional] 
 **seasonTo** | **int?**| Inclusive last season year (1900-9999). | [optional] 
 **driverId** | **int?**| API driver identifier. Records without a driver mapping cannot match this filter. | [optional] 
 **vehicleNumber** | **string**| Exact vehicle number as text; leading zeroes are significant. | [optional] 
 **firstName** | **string**| Substring of the driver&#x27;s first name, using database collation. | [optional] 
 **lastName** | **string**| Substring of the driver&#x27;s last name, using database collation. | [optional] 
 **driverName** | **string**| Substring of first name + space + last name, using database collation. | [optional] 
 **trackId** | **int?**| NASCAR One/API track identifier. | [optional] 
 **track** | **string**| Substring of the track name, using database collation. | [optional] 
 **dateFrom** | **DateTimeOffset?**| Inclusive lower source-local date/time bound, year 1900-9999, filtering actual_date (falling back to scheduled_date). Supply no UTC offset. See LapStatsQuery.date_from for the lap endpoint&#x27;s UTC-based semantics. | [optional] 
 **dateTo** | **DateTimeOffset?**| Inclusive upper source-local date/time bound, year 1900-9999, filtering actual_date (falling back to scheduled_date). A date without a time means midnight, not end of day. Supply no UTC offset. See LapStatsQuery.date_to for the lap endpoint&#x27;s UTC-based semantics. | [optional] 

### Return type

[**RaceStatStatsPage**](RaceStatStatsPage.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="statsreportget"></a>
# **StatsReportGet**
> byte[] StatsReportGet (string key = null)

Retrieves a specific statistical report file for a given key, which typically corresponds to a report path or identifier returned by /reports.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StatsReportGetExample
    {
        public void main()
        {

            var apiInstance = new StatsApi();
            var key = key_example;  // string | The key or identifier of the statistical report. (optional) 

            try
            {
                // Retrieves a specific statistical report file for a given key, which typically corresponds to a report path or identifier returned by /reports.
                byte[] result = apiInstance.StatsReportGet(key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsReportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key or identifier of the statistical report. | [optional] 

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="statsreportsget"></a>
# **StatsReportsGet**
> AvailableReports StatsReportsGet (int? raceId = null)

Retrieves a list of available statistical report paths for a given race.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StatsReportsGetExample
    {
        public void main()
        {

            var apiInstance = new StatsApi();
            var raceId = 56;  // int? | The unique identifier of the race. (optional) 

            try
            {
                // Retrieves a list of available statistical report paths for a given race.
                AvailableReports result = apiInstance.StatsReportsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsReportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**| The unique identifier of the race. | [optional] 

### Return type

[**AvailableReports**](AvailableReports.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="statsseasonget"></a>
# **StatsSeasonGet**
> Collection<SeasonStat> StatsSeasonGet (int? seriesId = null, int? season = null)

Retrieves a list of driver season statistics for a given series and season.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StatsSeasonGetExample
    {
        public void main()
        {

            var apiInstance = new StatsApi();
            var seriesId = 56;  // int? | The unique identifier of the series. (optional) 
            var season = 56;  // int? | The season for which to retrieve statistics. (optional) 

            try
            {
                // Retrieves a list of driver season statistics for a given series and season.
                Collection&lt;SeasonStat&gt; result = apiInstance.StatsSeasonGet(seriesId, season);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StatsApi.StatsSeasonGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| The unique identifier of the series. | [optional] 
 **season** | **int?**| The season for which to retrieve statistics. | [optional] 

### Return type

[**Collection<SeasonStat>**](SeasonStat.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
