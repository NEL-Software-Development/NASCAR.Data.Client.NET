# NASCAR.Data.Client.Api.FeedbackApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FeedbackDevNotesGet**](FeedbackApi.md#feedbackdevnotesget) | **GET** /feedback/dev-notes | 
[**FeedbackSubmitFeedbackPost**](FeedbackApi.md#feedbacksubmitfeedbackpost) | **POST** /feedback/submit-feedback | 

<a name="feedbackdevnotesget"></a>
# **FeedbackDevNotesGet**
> Collection<DevNote> FeedbackDevNotesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class FeedbackDevNotesGetExample
    {
        public void main()
        {

            var apiInstance = new FeedbackApi();

            try
            {
                Collection&lt;DevNote&gt; result = apiInstance.FeedbackDevNotesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbackDevNotesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<DevNote>**](DevNote.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="feedbacksubmitfeedbackpost"></a>
# **FeedbackSubmitFeedbackPost**
> void FeedbackSubmitFeedbackPost (Feedback body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class FeedbackSubmitFeedbackPostExample
    {
        public void main()
        {

            var apiInstance = new FeedbackApi();
            var body = new Feedback(); // Feedback |  (optional) 

            try
            {
                apiInstance.FeedbackSubmitFeedbackPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeedbackApi.FeedbackSubmitFeedbackPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Feedback**](Feedback.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
