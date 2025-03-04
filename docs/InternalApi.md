# NASCAR.Data.Client.Api.InternalApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InternalErdpCompaniesGet**](InternalApi.md#internalerdpcompaniesget) | **GET** /internal/erdp/companies | return list of company ids for erdp companies
[**InternalErdpDatapointsGet**](InternalApi.md#internalerdpdatapointsget) | **GET** /internal/erdp/datapoints | Get ERDP Datapoints
[**InternalErdpDatapointsPost**](InternalApi.md#internalerdpdatapointspost) | **POST** /internal/erdp/datapoints | Create ERDP Datapoints
[**InternalErdpIngestionDatapointsGet**](InternalApi.md#internalerdpingestiondatapointsget) | **GET** /internal/erdp/ingestion_datapoints | Called by the ingestion service for publishing
[**InternalErdpIngestionSourcesGet**](InternalApi.md#internalerdpingestionsourcesget) | **GET** /internal/erdp/ingestion_sources | Called by the ingestion service for publishing
[**InternalErdpSourcesGet**](InternalApi.md#internalerdpsourcesget) | **GET** /internal/erdp/sources | Get ERDP Sources
[**InternalErdpSourcesPost**](InternalApi.md#internalerdpsourcespost) | **POST** /internal/erdp/sources | Create ERDP Sources
[**InternalErdpSubscriptionsAuthServiceCompanyIdGet**](InternalApi.md#internalerdpsubscriptionsauthservicecompanyidget) | **GET** /internal/erdp/subscriptions/auth_service/{companyId} | nats auth service calls with company id, returns the topics that the company is allowed to sub on
[**InternalErdpSubscriptionsCompanyIdGet**](InternalApi.md#internalerdpsubscriptionscompanyidget) | **GET** /internal/erdp/subscriptions/{companyId} | Get Subscriptions by company id
[**InternalErdpSubscriptionsPost**](InternalApi.md#internalerdpsubscriptionspost) | **POST** /internal/erdp/subscriptions | Create erdp subscriptions
[**InternalErdpTopicCompanyTypesCompanyTypeIdGet**](InternalApi.md#internalerdptopiccompanytypescompanytypeidget) | **GET** /internal/erdp/topic_company_types/{company_type_id} | Get Topic Company Types by company id
[**InternalErdpTopicCompanyTypesGet**](InternalApi.md#internalerdptopiccompanytypesget) | **GET** /internal/erdp/topic_company_types | Get Topic Company Types
[**InternalErdpTopicCompanyTypesPost**](InternalApi.md#internalerdptopiccompanytypespost) | **POST** /internal/erdp/topic_company_types | Create Topic Company Types
[**InternalErdpTopicsGet**](InternalApi.md#internalerdptopicsget) | **GET** /internal/erdp/topics | Get Topics
[**InternalErdpTopicsPost**](InternalApi.md#internalerdptopicspost) | **POST** /internal/erdp/topics | Create Topic
[**InternalErdpVehicleSourcesGet**](InternalApi.md#internalerdpvehiclesourcesget) | **GET** /internal/erdp/vehicle_sources | Get vehicle sources
[**InternalErdpVehicleSourcesPost**](InternalApi.md#internalerdpvehiclesourcespost) | **POST** /internal/erdp/vehicle_sources | Create vehicle sources
[**InternalTiresGet**](InternalApi.md#internaltiresget) | **GET** /internal/tires | tire service get tire data for enhanced tire data to nats

<a name="internalerdpcompaniesget"></a>
# **InternalErdpCompaniesGet**
> Collection<int?> InternalErdpCompaniesGet ()

return list of company ids for erdp companies

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpCompaniesGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();

            try
            {
                // return list of company ids for erdp companies
                Collection&lt;int?&gt; result = apiInstance.InternalErdpCompaniesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpCompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Collection<int?>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpdatapointsget"></a>
# **InternalErdpDatapointsGet**
> Collection<ERDPDatapoint> InternalErdpDatapointsGet ()

Get ERDP Datapoints

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpDatapointsGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();

            try
            {
                // Get ERDP Datapoints
                Collection&lt;ERDPDatapoint&gt; result = apiInstance.InternalErdpDatapointsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpDatapointsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<ERDPDatapoint>**](ERDPDatapoint.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpdatapointspost"></a>
# **InternalErdpDatapointsPost**
> ERDPDatapointListETLSaveResult InternalErdpDatapointsPost (Collection<ERDPDatapoint> body = null)

Create ERDP Datapoints

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpDatapointsPostExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var body = new Collection<ERDPDatapoint>(); // Collection<ERDPDatapoint> |  (optional) 

            try
            {
                // Create ERDP Datapoints
                ERDPDatapointListETLSaveResult result = apiInstance.InternalErdpDatapointsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpDatapointsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;ERDPDatapoint&gt;**](ERDPDatapoint.md)|  | [optional] 

### Return type

[**ERDPDatapointListETLSaveResult**](ERDPDatapointListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpingestiondatapointsget"></a>
# **InternalErdpIngestionDatapointsGet**
> Collection<ERDPDatapoint> InternalErdpIngestionDatapointsGet (bool? includeNotActive = null)

Called by the ingestion service for publishing

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpIngestionDatapointsGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var includeNotActive = true;  // bool? |  (optional) 

            try
            {
                // Called by the ingestion service for publishing
                Collection&lt;ERDPDatapoint&gt; result = apiInstance.InternalErdpIngestionDatapointsGet(includeNotActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpIngestionDatapointsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeNotActive** | **bool?**|  | [optional] 

### Return type

[**Collection<ERDPDatapoint>**](ERDPDatapoint.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpingestionsourcesget"></a>
# **InternalErdpIngestionSourcesGet**
> Collection<ERDPSource> InternalErdpIngestionSourcesGet (bool? includeNotActive = null)

Called by the ingestion service for publishing

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpIngestionSourcesGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var includeNotActive = true;  // bool? |  (optional) 

            try
            {
                // Called by the ingestion service for publishing
                Collection&lt;ERDPSource&gt; result = apiInstance.InternalErdpIngestionSourcesGet(includeNotActive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpIngestionSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeNotActive** | **bool?**|  | [optional] 

### Return type

[**Collection<ERDPSource>**](ERDPSource.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpsourcesget"></a>
# **InternalErdpSourcesGet**
> Collection<ERDPSource> InternalErdpSourcesGet ()

Get ERDP Sources

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpSourcesGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();

            try
            {
                // Get ERDP Sources
                Collection&lt;ERDPSource&gt; result = apiInstance.InternalErdpSourcesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<ERDPSource>**](ERDPSource.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpsourcespost"></a>
# **InternalErdpSourcesPost**
> ERDPSourceListETLSaveResult InternalErdpSourcesPost (Collection<ERDPSource> body = null)

Create ERDP Sources

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpSourcesPostExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var body = new Collection<ERDPSource>(); // Collection<ERDPSource> |  (optional) 

            try
            {
                // Create ERDP Sources
                ERDPSourceListETLSaveResult result = apiInstance.InternalErdpSourcesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpSourcesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;ERDPSource&gt;**](ERDPSource.md)|  | [optional] 

### Return type

[**ERDPSourceListETLSaveResult**](ERDPSourceListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpsubscriptionsauthservicecompanyidget"></a>
# **InternalErdpSubscriptionsAuthServiceCompanyIdGet**
> ERDPUserPermissions InternalErdpSubscriptionsAuthServiceCompanyIdGet (int? companyId)

nats auth service calls with company id, returns the topics that the company is allowed to sub on

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpSubscriptionsAuthServiceCompanyIdGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var companyId = 56;  // int? | 

            try
            {
                // nats auth service calls with company id, returns the topics that the company is allowed to sub on
                ERDPUserPermissions result = apiInstance.InternalErdpSubscriptionsAuthServiceCompanyIdGet(companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpSubscriptionsAuthServiceCompanyIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int?**|  | 

### Return type

[**ERDPUserPermissions**](ERDPUserPermissions.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpsubscriptionscompanyidget"></a>
# **InternalErdpSubscriptionsCompanyIdGet**
> ERDPSubscriptionPaginatedResult InternalErdpSubscriptionsCompanyIdGet (int? companyId, int? offset = null, int? count = null, string filter = null, bool? allowed = null)

Get Subscriptions by company id

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpSubscriptionsCompanyIdGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var companyId = 56;  // int? | 
            var offset = 56;  // int? |  (optional) 
            var count = 56;  // int? |  (optional) 
            var filter = filter_example;  // string |  (optional) 
            var allowed = true;  // bool? |  (optional) 

            try
            {
                // Get Subscriptions by company id
                ERDPSubscriptionPaginatedResult result = apiInstance.InternalErdpSubscriptionsCompanyIdGet(companyId, offset, count, filter, allowed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpSubscriptionsCompanyIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **int?**|  | 
 **offset** | **int?**|  | [optional] 
 **count** | **int?**|  | [optional] 
 **filter** | **string**|  | [optional] 
 **allowed** | **bool?**|  | [optional] 

### Return type

[**ERDPSubscriptionPaginatedResult**](ERDPSubscriptionPaginatedResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpsubscriptionspost"></a>
# **InternalErdpSubscriptionsPost**
> CreateSubscriptionListETLSaveResult InternalErdpSubscriptionsPost (Collection<CreateSubscription> body = null)

Create erdp subscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpSubscriptionsPostExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var body = new Collection<CreateSubscription>(); // Collection<CreateSubscription> |  (optional) 

            try
            {
                // Create erdp subscriptions
                CreateSubscriptionListETLSaveResult result = apiInstance.InternalErdpSubscriptionsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpSubscriptionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;CreateSubscription&gt;**](CreateSubscription.md)|  | [optional] 

### Return type

[**CreateSubscriptionListETLSaveResult**](CreateSubscriptionListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdptopiccompanytypescompanytypeidget"></a>
# **InternalErdpTopicCompanyTypesCompanyTypeIdGet**
> Collection<ERDPTopic> InternalErdpTopicCompanyTypesCompanyTypeIdGet (int? companyTypeId)

Get Topic Company Types by company id

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpTopicCompanyTypesCompanyTypeIdGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var companyTypeId = 56;  // int? | 

            try
            {
                // Get Topic Company Types by company id
                Collection&lt;ERDPTopic&gt; result = apiInstance.InternalErdpTopicCompanyTypesCompanyTypeIdGet(companyTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpTopicCompanyTypesCompanyTypeIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyTypeId** | **int?**|  | 

### Return type

[**Collection<ERDPTopic>**](ERDPTopic.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdptopiccompanytypesget"></a>
# **InternalErdpTopicCompanyTypesGet**
> ERDPTopicCompanyTypePaginatedResult InternalErdpTopicCompanyTypesGet (int? count = null, int? offset = null, string filter = null)

Get Topic Company Types

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpTopicCompanyTypesGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var count = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Get Topic Company Types
                ERDPTopicCompanyTypePaginatedResult result = apiInstance.InternalErdpTopicCompanyTypesGet(count, offset, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpTopicCompanyTypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **filter** | **string**|  | [optional] 

### Return type

[**ERDPTopicCompanyTypePaginatedResult**](ERDPTopicCompanyTypePaginatedResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdptopiccompanytypespost"></a>
# **InternalErdpTopicCompanyTypesPost**
> ERDPTopicCompanyTypeListETLSaveResult InternalErdpTopicCompanyTypesPost (Collection<CreateTopicCompanyType> body = null)

Create Topic Company Types

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpTopicCompanyTypesPostExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var body = new Collection<CreateTopicCompanyType>(); // Collection<CreateTopicCompanyType> |  (optional) 

            try
            {
                // Create Topic Company Types
                ERDPTopicCompanyTypeListETLSaveResult result = apiInstance.InternalErdpTopicCompanyTypesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpTopicCompanyTypesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;CreateTopicCompanyType&gt;**](CreateTopicCompanyType.md)|  | [optional] 

### Return type

[**ERDPTopicCompanyTypeListETLSaveResult**](ERDPTopicCompanyTypeListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdptopicsget"></a>
# **InternalErdpTopicsGet**
> ERDPTopicPaginatedResult InternalErdpTopicsGet (int? count = null, int? offset = null, string filter = null)

Get Topics

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpTopicsGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var count = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Get Topics
                ERDPTopicPaginatedResult result = apiInstance.InternalErdpTopicsGet(count, offset, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpTopicsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **filter** | **string**|  | [optional] 

### Return type

[**ERDPTopicPaginatedResult**](ERDPTopicPaginatedResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdptopicspost"></a>
# **InternalErdpTopicsPost**
> CreateTopicListETLSaveResult InternalErdpTopicsPost (Collection<CreateTopic> body = null)

Create Topic

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpTopicsPostExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var body = new Collection<CreateTopic>(); // Collection<CreateTopic> |  (optional) 

            try
            {
                // Create Topic
                CreateTopicListETLSaveResult result = apiInstance.InternalErdpTopicsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpTopicsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;CreateTopic&gt;**](CreateTopic.md)|  | [optional] 

### Return type

[**CreateTopicListETLSaveResult**](CreateTopicListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpvehiclesourcesget"></a>
# **InternalErdpVehicleSourcesGet**
> Collection<ERDPSourceVehicle> InternalErdpVehicleSourcesGet ()

Get vehicle sources

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpVehicleSourcesGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();

            try
            {
                // Get vehicle sources
                Collection&lt;ERDPSourceVehicle&gt; result = apiInstance.InternalErdpVehicleSourcesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpVehicleSourcesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<ERDPSourceVehicle>**](ERDPSourceVehicle.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internalerdpvehiclesourcespost"></a>
# **InternalErdpVehicleSourcesPost**
> ERDPSourceVehicleListETLSaveResult InternalErdpVehicleSourcesPost (Collection<ERDPSourceVehicle> body = null)

Create vehicle sources

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalErdpVehicleSourcesPostExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();
            var body = new Collection<ERDPSourceVehicle>(); // Collection<ERDPSourceVehicle> |  (optional) 

            try
            {
                // Create vehicle sources
                ERDPSourceVehicleListETLSaveResult result = apiInstance.InternalErdpVehicleSourcesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalErdpVehicleSourcesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;ERDPSourceVehicle&gt;**](ERDPSourceVehicle.md)|  | [optional] 

### Return type

[**ERDPSourceVehicleListETLSaveResult**](ERDPSourceVehicleListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="internaltiresget"></a>
# **InternalTiresGet**
> Collection<Tire> InternalTiresGet ()

tire service get tire data for enhanced tire data to nats

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InternalTiresGetExample
    {
        public void main()
        {

            var apiInstance = new InternalApi();

            try
            {
                // tire service get tire data for enhanced tire data to nats
                Collection&lt;Tire&gt; result = apiInstance.InternalTiresGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InternalApi.InternalTiresGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<Tire>**](Tire.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
