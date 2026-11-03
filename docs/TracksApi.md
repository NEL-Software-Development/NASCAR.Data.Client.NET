# NASCAR.Data.Client.Api.TracksApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrackDetailsGet**](TracksApi.md#trackdetailsget) | **GET** /track-details | Retrieves detailed information about a specific track, including its history, notable events, and other relevant data, given the track&#x27;s unique identifier from /tracks.
[**TracksGet**](TracksApi.md#tracksget) | **GET** /tracks | Retrieves a list of all tracks in the NASCAR database, including basic information such as track name, location, and type.

<a name="trackdetailsget"></a>
# **TrackDetailsGet**
> TrackDetails TrackDetailsGet (int? trackId = null)

Retrieves detailed information about a specific track, including its history, notable events, and other relevant data, given the track's unique identifier from /tracks.

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
            var trackId = 56;  // int? | The unique identifier of the track. (optional) 

            try
            {
                // Retrieves detailed information about a specific track, including its history, notable events, and other relevant data, given the track's unique identifier from /tracks.
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
 **trackId** | **int?**| The unique identifier of the track. | [optional] 

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

Retrieves a list of all tracks in the NASCAR database, including basic information such as track name, location, and type.

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
                // Retrieves a list of all tracks in the NASCAR database, including basic information such as track name, location, and type.
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
