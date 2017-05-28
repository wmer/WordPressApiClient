using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Page {
    public abstract class PageModelBase {
        public string Date { get; set; }
        public string Slug { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int Author { get; set; }
        public int Parent { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public int MenuOrder { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public int FeaturedMedia { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string CommentStatus { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string PingStatus { get; set; }
        public string Template { get; set; }
    }
}
