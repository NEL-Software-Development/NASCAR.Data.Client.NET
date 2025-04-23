# NASCAR.Data.Client.Api.OpticalTrackingApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OpticalTrackingUtmOffsetsGet**](OpticalTrackingApi.md#opticaltrackingutmoffsetsget) | **GET** /optical-tracking/utm-offsets | 

<a name="opticaltrackingutmoffsetsget"></a>
# **OpticalTrackingUtmOffsetsGet**
> Collection<OpticalTrackingUTMOffset> OpticalTrackingUtmOffsetsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class OpticalTrackingUtmOffsetsGetExample
    {
        public void main()
        {

            var apiInstance = new OpticalTrackingApi();

            try
            {
                Collection&lt;OpticalTrackingUTMOffset&gt; result = apiInstance.OpticalTrackingUtmOffsetsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpticalTrackingApi.OpticalTrackingUtmOffsetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<OpticalTrackingUTMOffset>**](OpticalTrackingUTMOffset.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
