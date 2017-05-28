using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Comment {
    public abstract class CommentModelBase {
        public int Post { get; set; }
        public int Parent { get; set; }
        public int Author { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string AuthorName { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string AuthorUrl { get; set; }
        public string Date { get; set; }
        public string Link { get; set; }
    }
}
