# NASCAR.Data.Client.Api.RaceWeekApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Details**](RaceWeekApi.md#details) | **GET** /race-week/details | 
[**Live**](RaceWeekApi.md#live) | **GET** /race-week/live | 
[**Season**](RaceWeekApi.md#season) | **GET** /race-week/season | 

<a name="details"></a>
# **Details**
> RaceWeekDetails Details (int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DetailsExample
    {
        public void main()
        {

            var apiInstance = new RaceWeekApi();
            var id = 56;  // int? |  (optional) 

            try
            {
                RaceWeekDetails result = apiInstance.Details(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceWeekApi.Details: " + e.Message );
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
<a name="live"></a>
# **Live**
> Collection<RaceWeek> Live ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class LiveExample
    {
        public void main()
        {

            var apiInstance = new RaceWeekApi();

            try
            {
                Collection&lt;RaceWeek&gt; result = apiInstance.Live();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceWeekApi.Live: " + e.Message );
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
<a name="season"></a>
# **Season**
> Collection<RaceWeek> Season (int? season = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class SeasonExample
    {
        public void main()
        {

            var apiInstance = new RaceWeekApi();
            var season = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceWeek&gt; result = apiInstance.Season(season);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RaceWeekApi.Season: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **season** | **int?**|  | [optional] 

### Return type

[**Collection<RaceWeek>**](RaceWeek.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
