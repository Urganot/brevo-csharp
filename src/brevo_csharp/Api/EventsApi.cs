/* 
 * Brevo API
 *
 * Brevo provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/brevo  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@brevo.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace brevo_csharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an event
        /// </summary>
        /// <remarks>
        /// Create an event to track a contact&#39;s interaction.
        /// </remarks>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns></returns>
        void CreateUnifiedEvent (ModelEvent _event);

        /// <summary>
        /// Create an event
        /// </summary>
        /// <remarks>
        /// Create an event to track a contact&#39;s interaction.
        /// </remarks>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CreateUnifiedEventWithHttpInfo (ModelEvent _event);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create an event
        /// </summary>
        /// <remarks>
        /// Create an event to track a contact&#39;s interaction.
        /// </remarks>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CreateUnifiedEventAsync (ModelEvent _event);

        /// <summary>
        /// Create an event
        /// </summary>
        /// <remarks>
        /// Create an event to track a contact&#39;s interaction.
        /// </remarks>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateUnifiedEventAsyncWithHttpInfo (ModelEvent _event);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventsApi : IEventsApi
    {
        private brevo_csharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
        {
            this.Configuration = new brevo_csharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = brevo_csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(brevo_csharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = brevo_csharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = brevo_csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.HttpClient.BaseAddress.ToString();
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
        public brevo_csharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public brevo_csharp.Client.ExceptionFactory ExceptionFactory
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
        /// Create an event Create an event to track a contact&#39;s interaction.
        /// </summary>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns></returns>
        public void CreateUnifiedEvent (ModelEvent _event)
        {
             CreateUnifiedEventWithHttpInfo(_event);
        }

        /// <summary>
        /// Create an event Create an event to track a contact&#39;s interaction.
        /// </summary>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> CreateUnifiedEventWithHttpInfo (ModelEvent _event)
        {
            // verify the required parameter '_event' is set
            if (_event == null)
                throw new ApiException(400, "Missing required parameter '_event' when calling EventsApi->CreateUnifiedEvent");

            var localVarPath = "./events";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, MultipartFormDataContent>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (_event != null && _event.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(_event); // http body (model) parameter
            }
            else
            {
                localVarPostBody = _event; // byte array
            }

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }
            // authentication (partner-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("partner-key")))
            {
                localVarHeaderParams["partner-key"] = this.Configuration.GetApiKeyWithPrefix("partner-key");
            }

            // make the HTTP request
            var localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                HttpMethod.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateUnifiedEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create an event Create an event to track a contact&#39;s interaction.
        /// </summary>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CreateUnifiedEventAsync (ModelEvent _event)
        {
             await CreateUnifiedEventAsyncWithHttpInfo(_event);

        }

        /// <summary>
        /// Create an event Create an event to track a contact&#39;s interaction.
        /// </summary>
        /// <exception cref="brevo_csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateUnifiedEventAsyncWithHttpInfo (ModelEvent _event)
        {
            // verify the required parameter '_event' is set
            if (_event == null)
                throw new ApiException(400, "Missing required parameter '_event' when calling EventsApi->CreateUnifiedEvent");

            var localVarPath = "./events";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, MultipartFormDataContent>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (_event != null && _event.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(_event); // http body (model) parameter
            }
            else
            {
                localVarPostBody = _event; // byte array
            }

            // authentication (api-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarHeaderParams["api-key"] = this.Configuration.GetApiKeyWithPrefix("api-key");
            }
            // authentication (partner-key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("partner-key")))
            {
                localVarHeaderParams["partner-key"] = this.Configuration.GetApiKeyWithPrefix("partner-key");
            }

            // make the HTTP request
            var localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                HttpMethod.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateUnifiedEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

    }
}
