using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Models.ModelsShared;

namespace WordPressApiClient.Models.Media {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CreatedMediaModel : MediaModelBase {
        public int Id { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string DateGmt { get; set; }
        public GuidModel Guid { get; set; }
        public string Modified { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string ModifiedGmt { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public TitleModel Title { get; set; }
        public string Template { get; set; }
        public List<object> Meta { get; set; }
        public DescriptionModel Description { get; set; }
        public CaptionModel Caption { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string MediaType { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string MimeType { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public MediaDetailsModel MediaDetails { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string SourceUrl { get; set; }
    }
}
