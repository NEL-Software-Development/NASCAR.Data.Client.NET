# NASCAR.Data.Client.Api.DriverApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BySeason**](DriverApi.md#byseason) | **GET** /driver/season | 
[**Driver**](DriverApi.md#driver) | **GET** /driver | 
[**DriverSeasonFinishes**](DriverApi.md#driverseasonfinishes) | **GET** /driver/season-finishes | 

<a name="byseason"></a>
# **BySeason**
> Collection<Driver> BySeason (int? season = null, int? seriesId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class BySeasonExample
    {
        public void main()
        {

            var apiInstance = new DriverApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Driver&gt; result = apiInstance.BySeason(season, seriesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverApi.BySeason: " + e.Message );
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

[**Collection<Driver>**](Driver.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="driver"></a>
# **Driver**
> Driver Driver (int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverExample
    {
        public void main()
        {

            var apiInstance = new DriverApi();
            var id = 56;  // int? |  (optional) 

            try
            {
                Driver result = apiInstance.Driver(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverApi.Driver: " + e.Message );
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

[**Driver**](Driver.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="driverseasonfinishes"></a>
# **DriverSeasonFinishes**
> Collection<RaceResultSummary> DriverSeasonFinishes (int? id = null, int? season = null, int? seriesId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverSeasonFinishesExample
    {
        public void main()
        {

            var apiInstance = new DriverApi();
            var id = 56;  // int? |  (optional) 
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceResultSummary&gt; result = apiInstance.DriverSeasonFinishes(id, season, seriesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverApi.DriverSeasonFinishes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | [optional] 
 **season** | **int?**|  | [optional] 
 **seriesId** | **int?**|  | [optional] 

### Return type

[**Collection<RaceResultSummary>**](RaceResultSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
