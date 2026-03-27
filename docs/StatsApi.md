# NASCAR.Data.Client.Api.StatsApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatsLoopStatsGet**](StatsApi.md#statsloopstatsget) | **GET** /stats/loop-stats | 
[**StatsReportGet**](StatsApi.md#statsreportget) | **GET** /stats/report | 
[**StatsReportsGet**](StatsApi.md#statsreportsget) | **GET** /stats/reports | 
[**StatsSeasonGet**](StatsApi.md#statsseasonget) | **GET** /stats/season | 

<a name="statsloopstatsget"></a>
# **StatsLoopStatsGet**
> Collection<LoopStat> StatsLoopStatsGet (int? raceId = null)



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
            var raceId = 56;  // int? |  (optional) 

            try
            {
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
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<LoopStat>**](LoopStat.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="statsreportget"></a>
# **StatsReportGet**
> byte[] StatsReportGet (string key = null)



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
            var key = key_example;  // string |  (optional) 

            try
            {
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
 **key** | **string**|  | [optional] 

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
            var raceId = 56;  // int? |  (optional) 

            try
            {
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
 **raceId** | **int?**|  | [optional] 

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
            var seriesId = 56;  // int? |  (optional) 
            var season = 56;  // int? |  (optional) 

            try
            {
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
 **seriesId** | **int?**|  | [optional] 
 **season** | **int?**|  | [optional] 

### Return type

[**Collection<SeasonStat>**](SeasonStat.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
