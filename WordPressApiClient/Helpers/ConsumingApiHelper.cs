using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Builders;

namespace WordPressApiClient.Helpers {
    public class ConsumingApiHelper {
        private HttpClient _client;

        public ConsumingApiHelper(string appHost, string username, string password) {
            _client = HttpClientBuilder.Create(appHost, username, password);
        }

        public (T result, string message) Get<T>(string url) {
            return GetAssync<T>(url).Result;
        }

        public async Task<(T result, string message)> GetAssync<T>(string url) {
            var response = await _client.GetAsync(url);
            return DeserializeResponse<T>(response);
        }

        public (TResult result, string message) Post<T, TResult>(string url, T obj) {
            var response = _client.PostAsync(url, ObjectToHttpContent(obj)).Result;
            return DeserializeResponse<TResult>(response);
        }

        public (TResult result, string message) Put<T, TResult>(string url, T obj) {
            var response = _client.PutAsync(url, ObjectToHttpContent(obj)).Result;
            return DeserializeResponse<TResult>(response);
        }

        public (bool result, string message) Delete(string url) {
            var response = _client.DeleteAsync(url).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode) {
                return (true, responseContent);
            } else {
                return (false, responseContent);
            }
        }

        private (T result, string message) DeserializeResponse<T>(HttpResponseMessage response) {
            var responseContent = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode) {
                return (JsonConvert.DeserializeObject<T>(responseContent), responseContent);
            } else {
                return (default(T), responseContent);
            }
        }

        private HttpContent ObjectToHttpContent(object obj) {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
