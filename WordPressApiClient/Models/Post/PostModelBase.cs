using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Post {
    public abstract class PostModelBase {
        public string Date { get; set; }
        public string Slug { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public int Author { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public int FeaturedMedia { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string CommentStatus { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string PingStatus { get; set; }
        public bool Sticky { get; set; }
        public string Template { get; set; }
        public string Format { get; set; }
        public int[] Categories { get; set; }
        public int[] Tags { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public int LiveblogLikes { get; set; }
    }
}
