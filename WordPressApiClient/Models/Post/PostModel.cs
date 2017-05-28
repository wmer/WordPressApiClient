using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Post {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PostModel : PostModelBase {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Excerpt { get; set; }
    }
}
