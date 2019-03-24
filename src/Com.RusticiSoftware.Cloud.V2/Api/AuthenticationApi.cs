/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0 beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Com.RusticiSoftware.Cloud.V2.Client;
using Com.RusticiSoftware.Cloud.V2.Model;

namespace Com.RusticiSoftware.Cloud.V2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authenticates for a oauth token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>ApplicationToken</returns>
        ApplicationToken GetAppToken (string scope, int? expiration = null);

        /// <summary>
        /// Authenticates for a oauth token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>ApiResponse of ApplicationToken</returns>
        ApiResponse<ApplicationToken> GetAppTokenWithHttpInfo (string scope, int? expiration = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Authenticates for a oauth token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>Task of ApplicationToken</returns>
        System.Threading.Tasks.Task<ApplicationToken> GetAppTokenAsync (string scope, int? expiration = null);

        /// <summary>
        /// Authenticates for a oauth token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>Task of ApiResponse (ApplicationToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationToken>> GetAppTokenAsyncWithHttpInfo (string scope, int? expiration = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthenticationApi : IAuthenticationApi
    {
        private Com.RusticiSoftware.Cloud.V2.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Com.RusticiSoftware.Cloud.V2.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Com.RusticiSoftware.Cloud.V2.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.RusticiSoftware.Cloud.V2.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Authenticates for a oauth token 
        /// </summary>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>ApplicationToken</returns>
        public ApplicationToken GetAppToken (string scope, int? expiration = null)
        {
             ApiResponse<ApplicationToken> localVarResponse = GetAppTokenWithHttpInfo(scope, expiration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticates for a oauth token 
        /// </summary>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>ApiResponse of ApplicationToken</returns>
        public ApiResponse< ApplicationToken > GetAppTokenWithHttpInfo (string scope, int? expiration = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling AuthenticationApi->GetAppToken");

            var localVarPath = "/oauth/authenticate/application/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scope != null) localVarFormParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // form parameter
            if (expiration != null) localVarFormParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // form parameter

            // authentication (APP_NORMAL) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAppToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApplicationToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApplicationToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApplicationToken)));
            
        }

        /// <summary>
        /// Authenticates for a oauth token 
        /// </summary>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>Task of ApplicationToken</returns>
        public async System.Threading.Tasks.Task<ApplicationToken> GetAppTokenAsync (string scope, int? expiration = null)
        {
             ApiResponse<ApplicationToken> localVarResponse = await GetAppTokenAsyncWithHttpInfo(scope, expiration);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authenticates for a oauth token 
        /// </summary>
        /// <exception cref="Com.RusticiSoftware.Cloud.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="expiration"> (optional, default to 300)</param>
        /// <returns>Task of ApiResponse (ApplicationToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApplicationToken>> GetAppTokenAsyncWithHttpInfo (string scope, int? expiration = null)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling AuthenticationApi->GetAppToken");

            var localVarPath = "/oauth/authenticate/application/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (scope != null) localVarFormParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); // form parameter
            if (expiration != null) localVarFormParams.Add("expiration", Configuration.ApiClient.ParameterToString(expiration)); // form parameter

            // authentication (APP_NORMAL) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAppToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApplicationToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApplicationToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApplicationToken)));
            
        }

    }
}
