/* 
 * NASCAR.Data.API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace NASCAR.Data.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IERDPApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Collection&lt;NextGenDatapoint&gt;</returns>
        Collection<NextGenDatapoint> ErdpDatapointsGet ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Collection&lt;NextGenDatapoint&gt;</returns>
        ApiResponse<Collection<NextGenDatapoint>> ErdpDatapointsGetWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Collection&lt;NextGenSource&gt;</returns>
        Collection<NextGenSource> ErdpSourcesGet ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Collection&lt;NextGenSource&gt;</returns>
        ApiResponse<Collection<NextGenSource>> ErdpSourcesGetWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Collection&lt;NextGenDatapoint&gt;</returns>
        System.Threading.Tasks.Task<Collection<NextGenDatapoint>> ErdpDatapointsGetAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Collection&lt;NextGenDatapoint&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Collection<NextGenDatapoint>>> ErdpDatapointsGetAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Collection&lt;NextGenSource&gt;</returns>
        System.Threading.Tasks.Task<Collection<NextGenSource>> ErdpSourcesGetAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Collection&lt;NextGenSource&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Collection<NextGenSource>>> ErdpSourcesGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ERDPApi : IERDPApi
    {
        private NASCAR.Data.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ERDPApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ERDPApi(String basePath)
        {
            this.Configuration = new NASCAR.Data.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = NASCAR.Data.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ERDPApi"/> class
        /// </summary>
        /// <returns></returns>
        public ERDPApi()
        {
            this.Configuration = NASCAR.Data.Client.Client.Configuration.Default;

            ExceptionFactory = NASCAR.Data.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ERDPApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ERDPApi(NASCAR.Data.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = NASCAR.Data.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = NASCAR.Data.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public NASCAR.Data.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public NASCAR.Data.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Collection&lt;NextGenDatapoint&gt;</returns>
        public Collection<NextGenDatapoint> ErdpDatapointsGet ()
        {
             ApiResponse<Collection<NextGenDatapoint>> localVarResponse = ErdpDatapointsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Collection&lt;NextGenDatapoint&gt;</returns>
        public ApiResponse< Collection<NextGenDatapoint> > ErdpDatapointsGetWithHttpInfo ()
        {

            var localVarPath = "/erdp/datapoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (Bearer) required
            // bearer required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ErdpDatapointsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Collection<NextGenDatapoint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Collection<NextGenDatapoint>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Collection<NextGenDatapoint>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Collection&lt;NextGenDatapoint&gt;</returns>
        public async System.Threading.Tasks.Task<Collection<NextGenDatapoint>> ErdpDatapointsGetAsync ()
        {
             ApiResponse<Collection<NextGenDatapoint>> localVarResponse = await ErdpDatapointsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Collection&lt;NextGenDatapoint&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Collection<NextGenDatapoint>>> ErdpDatapointsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/erdp/datapoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (Bearer) required
            // bearer required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ErdpDatapointsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Collection<NextGenDatapoint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Collection<NextGenDatapoint>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Collection<NextGenDatapoint>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Collection&lt;NextGenSource&gt;</returns>
        public Collection<NextGenSource> ErdpSourcesGet ()
        {
             ApiResponse<Collection<NextGenSource>> localVarResponse = ErdpSourcesGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Collection&lt;NextGenSource&gt;</returns>
        public ApiResponse< Collection<NextGenSource> > ErdpSourcesGetWithHttpInfo ()
        {

            var localVarPath = "/erdp/sources";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (Bearer) required
            // bearer required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ErdpSourcesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Collection<NextGenSource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Collection<NextGenSource>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Collection<NextGenSource>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Collection&lt;NextGenSource&gt;</returns>
        public async System.Threading.Tasks.Task<Collection<NextGenSource>> ErdpSourcesGetAsync ()
        {
             ApiResponse<Collection<NextGenSource>> localVarResponse = await ErdpSourcesGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Collection&lt;NextGenSource&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Collection<NextGenSource>>> ErdpSourcesGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/erdp/sources";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (Bearer) required
            // bearer required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ErdpSourcesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Collection<NextGenSource>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Collection<NextGenSource>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Collection<NextGenSource>)));
        }

    }
}
