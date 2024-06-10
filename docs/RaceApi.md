# NASCAR.Data.Client.Api.RaceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Cautions**](RaceApi.md#cautions) | **GET** /race/cautions | 
[**DisciplineUpdates**](RaceApi.md#disciplineupdates) | **GET** /race/discipline-updates | 
[**Entries**](RaceApi.md#entries) | **GET** /race/entries | 
[**Infractions**](RaceApi.md#infractions) | **GET** /race/infractions | 
[**LapLeaders**](RaceApi.md#lapleaders) | **GET** /race/lap-leaders | 
[**LoopStats**](RaceApi.md#loopstats) | **GET** /race/loop-stats | 
[**PitStops**](RaceApi.md#pitstops) | **GET** /race/pitstops | 
[**PracticeResults**](RaceApi.md#practiceresults) | **GET** /race/practice-results | 
[**QualifyingResults**](RaceApi.md#qualifyingresults) | **GET** /race/qualifying-results | 
[**Race**](RaceApi.md#race) | **GET** /race | 
[**RaceResults**](RaceApi.md#raceresults) | **GET** /race/race-results | 
[**RaceSeason**](RaceApi.md#raceseason) | **GET** /race/season | 
[**Rosters**](RaceApi.md#rosters) | **GET** /race/rosters | 
[**StageResults**](RaceApi.md#stageresults) | **GET** /race/stage-results | 
[**ViewModel**](RaceApi.md#viewmodel) | **GET** /race/viewmodel | 
[**WeekendSchedule**](RaceApi.md#weekendschedule) | **GET** /race/weekend-schedule | 

<a name="cautions"></a>
# **Cautions**
> Collection<Caution> Cautions (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class CautionsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Caution&gt; result = apiInstance.Cautions(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.Cautions: " + e.Message );
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
<a name="disciplineupdates"></a>
# **DisciplineUpdates**
> Collection<DisciplineUpdate> DisciplineUpdates (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DisciplineUpdatesExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;DisciplineUpdate&gt; result = apiInstance.DisciplineUpdates(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.DisciplineUpdates: " + e.Message );
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
<a name="entries"></a>
# **Entries**
> Collection<RunEntry> Entries (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class EntriesExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RunEntry&gt; result = apiInstance.Entries(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.Entries: " + e.Message );
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
<a name="infractions"></a>
# **Infractions**
> Collection<RaceInfraction> Infractions (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InfractionsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceInfraction&gt; result = apiInstance.Infractions(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.Infractions: " + e.Message );
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
<a name="lapleaders"></a>
# **LapLeaders**
> Collection<LapLeader> LapLeaders (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class LapLeadersExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;LapLeader&gt; result = apiInstance.LapLeaders(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.LapLeaders: " + e.Message );
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
<a name="loopstats"></a>
# **LoopStats**
> Collection<LoopStat> LoopStats (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class LoopStatsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;LoopStat&gt; result = apiInstance.LoopStats(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.LoopStats: " + e.Message );
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
<a name="pitstops"></a>
# **PitStops**
> Collection<Pitstop> PitStops (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class PitStopsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Pitstop&gt; result = apiInstance.PitStops(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.PitStops: " + e.Message );
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
<a name="practiceresults"></a>
# **PracticeResults**
> Collection<PracticeRunResults> PracticeResults (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class PracticeResultsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;PracticeRunResults&gt; result = apiInstance.PracticeResults(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.PracticeResults: " + e.Message );
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
<a name="qualifyingresults"></a>
# **QualifyingResults**
> Collection<QualifyingRunResults> QualifyingResults (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class QualifyingResultsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;QualifyingRunResults&gt; result = apiInstance.QualifyingResults(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.QualifyingResults: " + e.Message );
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
<a name="race"></a>
# **Race**
> RaceDetails Race (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                RaceDetails result = apiInstance.Race(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.Race: " + e.Message );
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
<a name="raceresults"></a>
# **RaceResults**
> Collection<RaceRunResults> RaceResults (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceResultsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceRunResults&gt; result = apiInstance.RaceResults(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceResults: " + e.Message );
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
<a name="raceseason"></a>
# **RaceSeason**
> Collection<Collection<Race>> RaceSeason (int? season = null, int? seriesId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceSeasonExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Collection&lt;Race&gt;&gt; result = apiInstance.RaceSeason(season, seriesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.RaceSeason: " + e.Message );
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
<a name="rosters"></a>
# **Rosters**
> Collection<TeamRoster> Rosters (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RostersExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;TeamRoster&gt; result = apiInstance.Rosters(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.Rosters: " + e.Message );
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
<a name="stageresults"></a>
# **StageResults**
> Collection<StageRunResults> StageResults (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class StageResultsExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;StageRunResults&gt; result = apiInstance.StageResults(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.StageResults: " + e.Message );
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
<a name="viewmodel"></a>
# **ViewModel**
> RaceViewModel ViewModel (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class ViewModelExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                RaceViewModel result = apiInstance.ViewModel(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.ViewModel: " + e.Message );
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
<a name="weekendschedule"></a>
# **WeekendSchedule**
> Collection<WeekendSchedule> WeekendSchedule (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class WeekendScheduleExample
    {
        public void main()
        {

            var apiInstance = new RaceApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;WeekendSchedule&gt; result = apiInstance.WeekendSchedule(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceApi.WeekendSchedule: " + e.Message );
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
