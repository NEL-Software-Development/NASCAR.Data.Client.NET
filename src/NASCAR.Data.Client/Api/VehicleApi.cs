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
        public interface IVehicleApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>VehicleDetails</returns>
        VehicleDetails Vehicle (int? id = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of VehicleDetails</returns>
        ApiResponse<VehicleDetails> VehicleWithHttpInfo (int? id = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>Collection&lt;RaceResultSummary&gt;</returns>
        Collection<RaceResultSummary> VehicleSeasonFinishes (int? season = null, int? seriesId = null, string vehicle = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>ApiResponse of Collection&lt;RaceResultSummary&gt;</returns>
        ApiResponse<Collection<RaceResultSummary>> VehicleSeasonFinishesWithHttpInfo (int? season = null, int? seriesId = null, string vehicle = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of VehicleDetails</returns>
        System.Threading.Tasks.Task<VehicleDetails> VehicleAsync (int? id = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of ApiResponse (VehicleDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<VehicleDetails>> VehicleAsyncWithHttpInfo (int? id = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>Task of Collection&lt;RaceResultSummary&gt;</returns>
        System.Threading.Tasks.Task<Collection<RaceResultSummary>> VehicleSeasonFinishesAsync (int? season = null, int? seriesId = null, string vehicle = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>Task of ApiResponse (Collection&lt;RaceResultSummary&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Collection<RaceResultSummary>>> VehicleSeasonFinishesAsyncWithHttpInfo (int? season = null, int? seriesId = null, string vehicle = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class VehicleApi : IVehicleApi
    {
        private NASCAR.Data.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VehicleApi(String basePath)
        {
            this.Configuration = new NASCAR.Data.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = NASCAR.Data.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleApi"/> class
        /// </summary>
        /// <returns></returns>
        public VehicleApi()
        {
            this.Configuration = NASCAR.Data.Client.Client.Configuration.Default;

            ExceptionFactory = NASCAR.Data.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VehicleApi(NASCAR.Data.Client.Client.Configuration configuration = null)
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
        /// <param name="id"> (optional)</param>
        /// <returns>VehicleDetails</returns>
        public VehicleDetails Vehicle (int? id = null)
        {
             ApiResponse<VehicleDetails> localVarResponse = VehicleWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of VehicleDetails</returns>
        public ApiResponse< VehicleDetails > VehicleWithHttpInfo (int? id = null)
        {

            var localVarPath = "/vehicle";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
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
                Exception exception = ExceptionFactory("Vehicle", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VehicleDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VehicleDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VehicleDetails)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of VehicleDetails</returns>
        public async System.Threading.Tasks.Task<VehicleDetails> VehicleAsync (int? id = null)
        {
             ApiResponse<VehicleDetails> localVarResponse = await VehicleAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>Task of ApiResponse (VehicleDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VehicleDetails>> VehicleAsyncWithHttpInfo (int? id = null)
        {

            var localVarPath = "/vehicle";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
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
                Exception exception = ExceptionFactory("Vehicle", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VehicleDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VehicleDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VehicleDetails)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>Collection&lt;RaceResultSummary&gt;</returns>
        public Collection<RaceResultSummary> VehicleSeasonFinishes (int? season = null, int? seriesId = null, string vehicle = null)
        {
             ApiResponse<Collection<RaceResultSummary>> localVarResponse = VehicleSeasonFinishesWithHttpInfo(season, seriesId, vehicle);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>ApiResponse of Collection&lt;RaceResultSummary&gt;</returns>
        public ApiResponse< Collection<RaceResultSummary> > VehicleSeasonFinishesWithHttpInfo (int? season = null, int? seriesId = null, string vehicle = null)
        {

            var localVarPath = "/vehicle/season-finishes";
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

            if (season != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "season", season)); // query parameter
            if (seriesId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "series_id", seriesId)); // query parameter
            if (vehicle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "vehicle", vehicle)); // query parameter
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
                Exception exception = ExceptionFactory("VehicleSeasonFinishes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Collection<RaceResultSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Collection<RaceResultSummary>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Collection<RaceResultSummary>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>Task of Collection&lt;RaceResultSummary&gt;</returns>
        public async System.Threading.Tasks.Task<Collection<RaceResultSummary>> VehicleSeasonFinishesAsync (int? season = null, int? seriesId = null, string vehicle = null)
        {
             ApiResponse<Collection<RaceResultSummary>> localVarResponse = await VehicleSeasonFinishesAsyncWithHttpInfo(season, seriesId, vehicle);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="NASCAR.Data.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="season"> (optional)</param>
        /// <param name="seriesId"> (optional)</param>
        /// <param name="vehicle"> (optional)</param>
        /// <returns>Task of ApiResponse (Collection&lt;RaceResultSummary&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Collection<RaceResultSummary>>> VehicleSeasonFinishesAsyncWithHttpInfo (int? season = null, int? seriesId = null, string vehicle = null)
        {

            var localVarPath = "/vehicle/season-finishes";
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

            if (season != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "season", season)); // query parameter
            if (seriesId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "series_id", seriesId)); // query parameter
            if (vehicle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "vehicle", vehicle)); // query parameter
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
                Exception exception = ExceptionFactory("VehicleSeasonFinishes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Collection<RaceResultSummary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Collection<RaceResultSummary>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Collection<RaceResultSummary>)));
        }

    }
}
