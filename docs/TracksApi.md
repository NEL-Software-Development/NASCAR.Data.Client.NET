# NASCAR.Data.Client.Api.TracksApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrackDetailsGet**](TracksApi.md#trackdetailsget) | **GET** /track-details | 
[**TracksGet**](TracksApi.md#tracksget) | **GET** /tracks | 

<a name="trackdetailsget"></a>
# **TrackDetailsGet**
> TrackDetails TrackDetailsGet (int? trackId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class TrackDetailsGetExample
    {
        public void main()
        {

            var apiInstance = new TracksApi();
            var trackId = 56;  // int? |  (optional) 

            try
            {
                TrackDetails result = apiInstance.TrackDetailsGet(trackId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TracksApi.TrackDetailsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trackId** | **int?**|  | [optional] 

### Return type

[**TrackDetails**](TrackDetails.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tracksget"></a>
# **TracksGet**
> Track TracksGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class TracksGetExample
    {
        public void main()
        {

            var apiInstance = new TracksApi();

            try
            {
                Track result = apiInstance.TracksGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TracksApi.TracksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Track**](Track.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
