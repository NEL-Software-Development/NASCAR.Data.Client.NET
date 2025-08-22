# NASCAR.Data.Client.Api.ERDPApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ErdpTopicsGet**](ERDPApi.md#erdptopicsget) | **GET** /erdp/topics | Get a users erdp topics.

<a name="erdptopicsget"></a>
# **ErdpTopicsGet**
> Collection<ClientERDPTopic> ErdpTopicsGet ()

Get a users erdp topics.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class ErdpTopicsGetExample
    {
        public void main()
        {

            var apiInstance = new ERDPApi();

            try
            {
                // Get a users erdp topics.
                Collection&lt;ClientERDPTopic&gt; result = apiInstance.ErdpTopicsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ERDPApi.ErdpTopicsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<ClientERDPTopic>**](ClientERDPTopic.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
