/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFakeClassnameTags123Api
    {
        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> TestClassnameWithHttpInfoAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ModelClient> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ModelClient?)</returns>
        System.Threading.Tasks.Task<ModelClient?> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FakeClassnameTags123Api : IFakeClassnameTags123Api
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeClassnameTags123Api"/> class.
        /// </summary>
        /// <returns></returns>
        public FakeClassnameTags123Api(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Returns the token to be used in the api query
        /// </summary>
        public Func<System.Threading.Tasks.ValueTask<string>>? GetTokenAsync { get; set; }  


        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateTestClassnameRequestAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null)
        {
            Org.OpenAPITools.Client.ApiResponse<ModelClient> result = await TestClassnameWithHttpInfoAsync(modelClient, cancellationToken).ConfigureAwait(false);
            return result.Data ?? throw new NullReferenceException();
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient?> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null)
        {
            Org.OpenAPITools.Client.ApiResponse<ModelClient> result = await TestClassnameWithHttpInfoAsync(modelClient, cancellationToken).ConfigureAwait(false);
            
            return result.IsSuccessStatusCode
                ? result.Data
                : null;
        } 

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<ModelClient>> TestClassnameWithHttpInfoAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (modelClient == null)
                throw new ArgumentNullException(nameof(modelClient)); 

            await ValidateTestClassnameRequestAsync(modelClient, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/fake_classname_test";


            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");



            // todo localVarRequestOptions.Data = modelClient;

            // authentication (api_key_query) required
                        //todo if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key_query")))
                //todo localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "api_key_query", this.Configuration.GetApiKeyWithPrefix("api_key_query")));

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string[] contentTypes = new string[] {
                "application/json"
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<ModelClient> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelClient>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }
    }
}