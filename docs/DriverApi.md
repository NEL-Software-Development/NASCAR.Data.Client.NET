# NASCAR.Data.Client.Api.DriverApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DriverGet**](DriverApi.md#driverget) | **GET** /driver | 
[**DriverSeasonFinishesGet**](DriverApi.md#driverseasonfinishesget) | **GET** /driver/season-finishes | 
[**DriverSeasonGet**](DriverApi.md#driverseasonget) | **GET** /driver/season | 

<a name="driverget"></a>
# **DriverGet**
> Driver DriverGet (int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverGetExample
    {
        public void main()
        {

            var apiInstance = new DriverApi();
            var id = 56;  // int? |  (optional) 

            try
            {
                Driver result = apiInstance.DriverGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverApi.DriverGet: " + e.Message );
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
<a name="driverseasonfinishesget"></a>
# **DriverSeasonFinishesGet**
> Collection<RaceResultSummary> DriverSeasonFinishesGet (int? id = null, int? season = null, int? seriesId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverSeasonFinishesGetExample
    {
        public void main()
        {

            var apiInstance = new DriverApi();
            var id = 56;  // int? |  (optional) 
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;RaceResultSummary&gt; result = apiInstance.DriverSeasonFinishesGet(id, season, seriesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverApi.DriverSeasonFinishesGet: " + e.Message );
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
<a name="driverseasonget"></a>
# **DriverSeasonGet**
> Collection<Driver> DriverSeasonGet (int? season = null, int? seriesId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverSeasonGetExample
    {
        public void main()
        {

            var apiInstance = new DriverApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;Driver&gt; result = apiInstance.DriverSeasonGet(season, seriesId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverApi.DriverSeasonGet: " + e.Message );
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
