# NASCAR.Data.Client.Api.RaceWeekApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RaceWeekDetailsGet**](RaceWeekApi.md#raceweekdetailsget) | **GET** /race-week/details | Retrieves details for a specific race week event given its unique identifier.
[**RaceWeekLiveGet**](RaceWeekApi.md#raceweekliveget) | **GET** /race-week/live | Retrieves a list of live race events
[**RaceWeekSeasonGet**](RaceWeekApi.md#raceweekseasonget) | **GET** /race-week/season | Retrieves all race week events for a given season, ordered by start date. This includes both past and upcoming events within the specified season.

<a name="raceweekdetailsget"></a>
# **RaceWeekDetailsGet**
> RaceWeekDetails RaceWeekDetailsGet (int? id = null)

Retrieves details for a specific race week event given its unique identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceWeekDetailsGetExample
    {
        public void main()
        {

            var apiInstance = new RaceWeekApi();
            var id = 56;  // int? |  (optional) 

            try
            {
                // Retrieves details for a specific race week event given its unique identifier.
                RaceWeekDetails result = apiInstance.RaceWeekDetailsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceWeekApi.RaceWeekDetailsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | [optional] 

### Return type

[**RaceWeekDetails**](RaceWeekDetails.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceweekliveget"></a>
# **RaceWeekLiveGet**
> Collection<RaceWeek> RaceWeekLiveGet ()

Retrieves a list of live race events

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceWeekLiveGetExample
    {
        public void main()
        {

            var apiInstance = new RaceWeekApi();

            try
            {
                // Retrieves a list of live race events
                Collection&lt;RaceWeek&gt; result = apiInstance.RaceWeekLiveGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceWeekApi.RaceWeekLiveGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<RaceWeek>**](RaceWeek.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="raceweekseasonget"></a>
# **RaceWeekSeasonGet**
> Collection<RaceWeek> RaceWeekSeasonGet (int? season = null)

Retrieves all race week events for a given season, ordered by start date. This includes both past and upcoming events within the specified season.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RaceWeekSeasonGetExample
    {
        public void main()
        {

            var apiInstance = new RaceWeekApi();
            var season = 56;  // int? | The season for which to retrieve race week events. (optional) 

            try
            {
                // Retrieves all race week events for a given season, ordered by start date. This includes both past and upcoming events within the specified season.
                Collection&lt;RaceWeek&gt; result = apiInstance.RaceWeekSeasonGet(season);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceWeekApi.RaceWeekSeasonGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **season** | **int?**| The season for which to retrieve race week events. | [optional] 

### Return type

[**Collection<RaceWeek>**](RaceWeek.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
