using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ApiService
    {
        /// <summary>
    /// Service class for making API calls.
    /// </summary>
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiSettings _apiSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiService"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to make requests.</param>
        /// <param name="apiSettings">The API settings containing base URL and domain.</param>
        /// <param name="httpContextAccessor">The HTTP context accessor used to access session data.</param>
        public ApiService(HttpClient httpClient, ApiSettings apiSettings, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _apiSettings = apiSettings;
            _httpContextAccessor = httpContextAccessor;
        }
        /// <summary>
        /// Makes a GET request to the specified endpoint and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response should be deserialized.</typeparam>
        /// <param name="endpoint">The API endpoint to call.</param>
        /// <returns>A task representing the asynchronous operation, with a result of the specified type.</returns>
        public async Task<T> GetAsync<T>(string endpoint)
        {
            // Retrieve the token from the session.
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            // Set the Authorization header with the token.
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            // Construct the full URL using the base URL, domain, and endpoint.
            var response = await _httpClient.GetAsync($"{_apiSettings.BaseUrl}/{_apiSettings.ApiDomain}/{endpoint}");
            
            // Read the response content as a string.
            var responseData = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(responseData))
            {
                throw new JsonException("The response content is empty.");
            }
            // Deserialize the response content to the specified type.
            return JsonSerializer.Deserialize<T>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        /// <summary>
        /// Makes a POST request to the specified endpoint with the provided data and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response should be deserialized.</typeparam>
        /// <typeparam name="TData">The type of the data to be sent in the request body.</typeparam>
        /// <param name="endpoint">The API endpoint to call.</param>
        /// <param name="data">The data to be sent in the request body.</param>
        /// <returns>A task representing the asynchronous operation, with a result of the specified type.</returns>
        public async Task<T> PostAsync<T, TData>(string endpoint, TData data)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{_apiSettings.BaseUrl}/{_apiSettings.ApiDomain}/{endpoint}", content);
            var responseData = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        /// <summary>
        /// Makes a PUT request to the specified endpoint with the provided data and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response should be deserialized.</typeparam>
        /// <typeparam name="TData">The type of the data to be sent in the request body.</typeparam>
        /// <param name="endpoint">The API endpoint to call.</param>
        /// <param name="data">The data to be sent in the request body.</param>
        /// <returns>A task representing the asynchronous operation, with a result of the specified type.</returns>
        public async Task<T> PutAsync<T, TData>(string endpoint, TData data)
        {
            var token = _httpContextAccessor.HttpContext.Session.GetString("token");
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{_apiSettings.BaseUrl}/{_apiSettings.ApiDomain}/{endpoint}", content);
            var responseData = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}