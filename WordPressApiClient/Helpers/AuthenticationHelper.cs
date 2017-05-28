using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Helpers {
    public class AuthenticationHelper {
        private HttpClient _client;
        private string authenticationUri;

        public AuthenticationHelper(HttpClient client) {
            this._client = client;
            this.authenticationUri = $"{_client.BaseAddress}/wp-json/jwt-auth/v1/token";
        }

        public string Authenticate(string username, string password) {
            string token = null;
            var data = new Dictionary<String, String>() {
                    { "username", username },
                    { "password", password }
                };
            using (var requestContent = new FormUrlEncodedContent(data)) {
                var response = _client.PostAsync(authenticationUri, requestContent).Result;
                if (response.IsSuccessStatusCode) {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    var tokenData = JObject.Parse(responseContent);
                    token = (string)tokenData["token"];
                }
            }
            return token;
        }
    }
}
