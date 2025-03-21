# NASCAR.Data.Client.Api.RaceApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RaceCautionsGet**](RaceApi.md#racecautionsget) | **GET** /race/cautions | 
[**RaceDisciplineUpdatesGet**](RaceApi.md#racedisciplineupdatesget) | **GET** /race/discipline-updates | 
[**RaceEntriesGet**](RaceApi.md#raceentriesget) | **GET** /race/entries | 
[**RaceGet**](RaceApi.md#raceget) | **GET** /race | 
[**RaceInfractionsGet**](RaceApi.md#raceinfractionsget) | **GET** /race/infractions | 
[**RaceLapLeadersGet**](RaceApi.md#racelapleadersget) | **GET** /race/lap-leaders | 
[**RaceLoopStatsGet**](RaceApi.md#raceloopstatsget) | **GET** /race/loop-stats | 
[**RacePitstopsGet**](RaceApi.md#racepitstopsget) | **GET** /race/pitstops | 
[**RacePracticeResultsGet**](RaceApi.md#racepracticeresultsget) | **GET** /race/practice-results | 
[**RaceQualifyingResultsGet**](RaceApi.md#racequalifyingresultsget) | **GET** /race/qualifying-results | 
[**RaceRaceResultsGet**](RaceApi.md#raceraceresultsget) | **GET** /race/race-results | 
[**RaceRostersGet**](RaceApi.md#racerostersget) | **GET** /race/rosters | 
[**RaceSeasonGet**](RaceApi.md#raceseasonget) | **GET** /race/season | 
[**RaceStageResultsGet**](RaceApi.md#racestageresultsget) | **GET** /race/stage-results | 
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
