using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TheSharpFactory.Web.Client
{
    /// <summary>
    /// Manages the http client requests and responses.
    /// </summary>
    internal static class WebApiManager
    {
        //private const string _requestHeaderBearer = "Bearer";
        private const string _responseFormat = "application/json";

        private static readonly HttpClient _client;

        static WebApiManager()
        {

            // Setup the client as singleton.  The service uri normally would be configurable.
            _client = new HttpClient { BaseAddress = new Uri("http://localhost:5500/api/"), Timeout = new TimeSpan(0, 0, 0, 0, -1) };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_responseFormat));

            // Add the API Bearer token identifier for this application.
            //_client.DefaultRequestHeaders.Add(RequestHeaderBearer, "bearer token goes here");       
        }

        #region GET
        public static async Task<T> Get<T>(string path, QueryStringParameters queryParams = null)
        {
            var response = _client.GetAsync(CreateEndpointUrl(path, queryParams));

            return await ProcessResponse<T>(response);
        }
        #endregion

        #region POST

        public static async Task<T> Post<T>(string path, object requestObject)
        {
            return await Post<T>(path, null, requestObject);
        }
        public static async Task<T> Post<T>(string path, QueryStringParameters queryParams, object requestObject)
        {
            var response = _client.PostAsJsonAsync(CreateEndpointUrl(path, queryParams), requestObject);

            return await ProcessResponse<T>(response);
        }
        #endregion


        #region PUT
        public static async Task<T> Put<T>(string path, object requestObject)
        {
            return await Put<T>(path, null, requestObject);
        }
        public static async Task<T> Put<T>(string path, QueryStringParameters queryParams = null)
        {
            return await Put<T>(path, queryParams, null);
        }
        public static async Task<T> Put<T>(string path, QueryStringParameters queryParams, object requestObject)
        {
            var response = _client.PutAsJsonAsync(CreateEndpointUrl(path, queryParams), requestObject);

            return await ProcessResponse<T>(response);
        }
        #endregion


        #region DELETE
        public static async Task<T> Delete<T>(string path, QueryStringParameters queryParams = null)
        {
            var response = _client.DeleteAsync(CreateEndpointUrl(path, queryParams));

            return await ProcessResponse<T>(response);
        }
        #endregion


        #region Private Helpers
        /// <summary>
        /// Creates the full endpoint URL using the base API url and an optional collection of query parameters.
        /// </summary>
        /// <param name="path">Path to the API controller to call .</param>
        /// <param name="queryParams">Collection of query parameters, or null.</param>
        /// <returns>Full URL string.</returns>
        private static string CreateEndpointUrl(string path, QueryStringParameters queryParams)
        {
            // If not query string parameters just return.
            if(!(queryParams?.Parameters?.Count > 0))
                return path;

            var sb = new StringBuilder(500);

            // Append the api path to the url.
            sb.Append(path);

            var keys = queryParams.Parameters.Keys.ToList();

            sb.Append("?");

            foreach(var key in keys)
            {
                sb.Append(WebUtility.UrlEncode(key));
                sb.Append("=");
                sb.Append(WebUtility.UrlEncode(queryParams.Parameters[key]));
                sb.Append("&");
            }

            sb.Length--;//remove the last ampersand.

            return sb.ToString();
        }

        private static async Task<T> ProcessResponse<T>(Task<HttpResponseMessage> responseTask)
        {
            var httpResponse = await responseTask;

            if(!httpResponse.IsSuccessStatusCode)
                throw new HttpRequestException(httpResponse.ToString());

            var dataResult = await httpResponse.Content.ReadAsAsync<T>();

            return dataResult;
        } 
        #endregion

    }
}
