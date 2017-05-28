using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Helpers;

namespace WordPressApiClient.Builders {
    public class HttpClientBuilder {
        public static HttpClient Create(string appHost, string username, string password) {
            var client = new HttpClient() {
                BaseAddress = new Uri(appHost)
            };
            var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(mediaType);
            var auth = new AuthenticationHelper(client);
            var token = auth.Authenticate(username, password);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return client;
        }
    }
}
