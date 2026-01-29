# NASCAR.Data.Client.Api.JournalFilesApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JournalGet**](JournalFilesApi.md#journalget) | **GET** /journal | 

<a name="journalget"></a>
# **JournalGet**
> byte[] JournalGet (string historicalRaceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class JournalGetExample
    {
        public void main()
        {

            var apiInstance = new JournalFilesApi();
            var historicalRaceId = historicalRaceId_example;  // string |  (optional) 

            try
            {
                byte[] result = apiInstance.JournalGet(historicalRaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JournalFilesApi.JournalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historicalRaceId** | **string**|  | [optional] 

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/zip

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
