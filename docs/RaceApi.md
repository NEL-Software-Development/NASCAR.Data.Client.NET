# NASCAR.Data.Client.Api.RaceApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RaceCautionsGet**](RaceApi.md#racecautionsget) | **GET** /race/cautions | 
[**RaceDisciplineUpdatesGet**](RaceApi.md#racedisciplineupdatesget) | **GET** /race/discipline-updates | 
[**RaceEntriesGet**](RaceApi.md#raceentriesget) | **GET** /race/entries | 
[**RaceFastestLapsGet**](RaceApi.md#racefastestlapsget) | **GET** /race/fastest-laps | 
[**RaceGet**](RaceApi.md#raceget) | **GET** /race | 
[**RaceInfractionsGet**](RaceApi.md#raceinfractionsget) | **GET** /race/infractions | 
[**RaceLapChartGet**](RaceApi.md#racelapchartget) | **GET** /race/lap-chart | 
[**RaceLapLeadersGet**](RaceApi.md#racelapleadersget) | **GET** /race/lap-leaders | 
[**RaceLiveSessionGet**](RaceApi.md#racelivesessionget) | **GET** /race/live-session | 
[**RaceLookupGet**](RaceApi.md#racelookupget) | **GET** /race/lookup | 
[**RaceLoopStatsGet**](RaceApi.md#raceloopstatsget) | **GET** /race/loop-stats | 
[**RacePitstopsGet**](RaceApi.md#racepitstopsget) | **GET** /race/pitstops | 
[**RacePracticeResultsGet**](RaceApi.md#racepracticeresultsget) | **GET** /race/practice-results | 
[**RaceQualifyingResultsGet**](RaceApi.md#racequalifyingresultsget) | **GET** /race/qualifying-results | 
[**RaceRaceResultsGet**](RaceApi.md#raceraceresultsget) | **GET** /race/race-results | 
[**RaceReportGet**](RaceApi.md#racereportget) | **GET** /race/report | 
[**RaceResultsGet**](RaceApi.md#raceresultsget) | **GET** /race/results | 
[**RaceRostersGet**](RaceApi.md#racerostersget) | **GET** /race/rosters | 
[**RaceSeasonGet**](RaceApi.md#raceseasonget) | **GET** /race/season | 
[**RaceStageResultsGet**](RaceApi.md#racestageresultsget) | **GET** /race/stage-results | 
[**RaceStagesGet**](RaceApi.md#racestagesget) | **GET** /race/stages | 
[**RaceStatReportsGet**](RaceApi.md#racestatreportsget) | **GET** /race/stat-reports | 
[**RaceViewmodelGet**](RaceApi.md#raceviewmodelget) | **GET** /race/viewmodel | 
[**RaceWeekendScheduleGet**](RaceApi.md#raceweekendscheduleget) | **GET** /race/weekend-schedule | 

<a name="racecautionsget"></a>
# **RaceCautionsGet**
> Collection<Caution> RaceCautionsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceCautionsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Caution&gt; result = apiInstance.RaceCautionsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceCautionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<Caution>**](Caution.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racedisciplineupdatesget"></a>
# **RaceDisciplineUpdatesGet**
> Collection<DisciplineUpdate> RaceDisciplineUpdatesGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceDisciplineUpdatesGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;DisciplineUpdate&gt; result = apiInstance.RaceDisciplineUpdatesGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceDisciplineUpdatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<DisciplineUpdate>**](DisciplineUpdate.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceentriesget"></a>
# **RaceEntriesGet**
> Collection<RunEntry> RaceEntriesGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceEntriesGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RunEntry&gt; result = apiInstance.RaceEntriesGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceEntriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<RunEntry>**](RunEntry.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racefastestlapsget"></a>
# **RaceFastestLapsGet**
> FastestLapResult RaceFastestLapsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceFastestLapsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                FastestLapResult result = apiInstance.RaceFastestLapsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceFastestLapsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**FastestLapResult**](FastestLapResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceget"></a>
# **RaceGet**
> RaceDetails RaceGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                RaceDetails result = apiInstance.RaceGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**RaceDetails**](RaceDetails.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceinfractionsget"></a>
# **RaceInfractionsGet**
> Collection<RaceInfraction> RaceInfractionsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceInfractionsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceInfraction&gt; result = apiInstance.RaceInfractionsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceInfractionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<RaceInfraction>**](RaceInfraction.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racelapchartget"></a>
# **RaceLapChartGet**
> LapChartResult RaceLapChartGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceLapChartGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                LapChartResult result = apiInstance.RaceLapChartGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceLapChartGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**LapChartResult**](LapChartResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racelapleadersget"></a>
# **RaceLapLeadersGet**
> Collection<LapLeader> RaceLapLeadersGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceLapLeadersGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;LapLeader&gt; result = apiInstance.RaceLapLeadersGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceLapLeadersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<LapLeader>**](LapLeader.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racelivesessionget"></a>
# **RaceLiveSessionGet**
> ActiveRun RaceLiveSessionGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceLiveSessionGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();

            try
            {
                ActiveRun result = apiInstance.RaceLiveSessionGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceLiveSessionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ActiveRun**](ActiveRun.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racelookupget"></a>
# **RaceLookupGet**
> Collection<RaceDetails> RaceLookupGet (int? historyRaceId = null, DateTime? dateStart = null, DateTime? dateEnd = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceLookupGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var historyRaceId = 56;  // int? |  (optional) 
            var dateStart = 2013-10-20;  // DateTime? | enter date_start in yyyy-mm-dd format (optional) 
            var dateEnd = 2013-10-20;  // DateTime? | enter date_end in yyyy-mm-dd format (optional) 

            try
            {
                Collection&lt;RaceDetails&gt; result = apiInstance.RaceLookupGet(historyRaceId, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceLookupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historyRaceId** | **int?**|  | [optional] 
 **dateStart** | **DateTime?**| enter date_start in yyyy-mm-dd format | [optional] 
 **dateEnd** | **DateTime?**| enter date_end in yyyy-mm-dd format | [optional] 

### Return type

[**Collection<RaceDetails>**](RaceDetails.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceloopstatsget"></a>
# **RaceLoopStatsGet**
> Collection<LoopStat> RaceLoopStatsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceLoopStatsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;LoopStat&gt; result = apiInstance.RaceLoopStatsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceLoopStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<LoopStat>**](LoopStat.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racepitstopsget"></a>
# **RacePitstopsGet**
> Collection<Pitstop> RacePitstopsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RacePitstopsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Pitstop&gt; result = apiInstance.RacePitstopsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RacePitstopsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<Pitstop>**](Pitstop.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racepracticeresultsget"></a>
# **RacePracticeResultsGet**
> Collection<PracticeRunResults> RacePracticeResultsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RacePracticeResultsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;PracticeRunResults&gt; result = apiInstance.RacePracticeResultsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RacePracticeResultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<PracticeRunResults>**](PracticeRunResults.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racequalifyingresultsget"></a>
# **RaceQualifyingResultsGet**
> Collection<QualifyingRunResults> RaceQualifyingResultsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceQualifyingResultsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;QualifyingRunResults&gt; result = apiInstance.RaceQualifyingResultsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceQualifyingResultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<QualifyingRunResults>**](QualifyingRunResults.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceraceresultsget"></a>
# **RaceRaceResultsGet**
> Collection<RaceRunResults> RaceRaceResultsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceRaceResultsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceRunResults&gt; result = apiInstance.RaceRaceResultsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceRaceResultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<RaceRunResults>**](RaceRunResults.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racereportget"></a>
# **RaceReportGet**
> AvailableReports RaceReportGet (string key = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceReportGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var key = key_example;  // string |  (optional) 

            try
            {
                AvailableReports result = apiInstance.RaceReportGet(key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceReportGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**|  | [optional] 

### Return type

[**AvailableReports**](AvailableReports.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceresultsget"></a>
# **RaceResultsGet**
> RunResults RaceResultsGet (int? raceId = null, int? timingRunId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceResultsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 
            var timingRunId = 56;  // int? |  (optional) 

            try
            {
                RunResults result = apiInstance.RaceResultsGet(raceId, timingRunId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceResultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 
 **timingRunId** | **int?**|  | [optional] 

### Return type

[**RunResults**](RunResults.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racerostersget"></a>
# **RaceRostersGet**
> Collection<TeamRoster> RaceRostersGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceRostersGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;TeamRoster&gt; result = apiInstance.RaceRostersGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceRostersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<TeamRoster>**](TeamRoster.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceseasonget"></a>
# **RaceSeasonGet**
> Collection<Collection<Race>> RaceSeasonGet (int? season = null, int? seriesId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceSeasonGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Collection&lt;Race&gt;&gt; result = apiInstance.RaceSeasonGet(season, seriesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceSeasonGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **season** | **int?**|  | [optional] 
 **seriesId** | **int?**|  | [optional] 

### Return type

**Collection<Collection<Race>>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racestageresultsget"></a>
# **RaceStageResultsGet**
> Collection<StageRunResults> RaceStageResultsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceStageResultsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;StageRunResults&gt; result = apiInstance.RaceStageResultsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceStageResultsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<StageRunResults>**](StageRunResults.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racestagesget"></a>
# **RaceStagesGet**
> Collection<Stage> RaceStagesGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceStagesGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Stage&gt; result = apiInstance.RaceStagesGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceStagesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<Stage>**](Stage.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="racestatreportsget"></a>
# **RaceStatReportsGet**
> AvailableReports RaceStatReportsGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceStatReportsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                AvailableReports result = apiInstance.RaceStatReportsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceStatReportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**AvailableReports**](AvailableReports.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceviewmodelget"></a>
# **RaceViewmodelGet**
> RaceViewModel RaceViewmodelGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceViewmodelGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                RaceViewModel result = apiInstance.RaceViewmodelGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceViewmodelGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**RaceViewModel**](RaceViewModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceweekendscheduleget"></a>
# **RaceWeekendScheduleGet**
> Collection<WeekendSchedule> RaceWeekendScheduleGet (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceWeekendScheduleGetExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;WeekendSchedule&gt; result = apiInstance.RaceWeekendScheduleGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceWeekendScheduleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<WeekendSchedule>**](WeekendSchedule.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
