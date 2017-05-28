using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Models.ModelsShared;

namespace WordPressApiClient.Models.Post {
    public class PostRevisionModel {
        public int Id { get; set; }
        public GuidModel Guid { get; set; }
        public int Parent { get; set; }
        public string Date { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string DateGmt { get; set; }
        public String Modified { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public String ModifiedGmt { get; set; }
        public TitleModel Title { get; set; }
        public string Slug { get; set; }
        public ContentModel Content { get; set; }
        public ExcerptModel Excerpt { get; set; }
        public int Author { get; set; }
    }
}
