using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Models.ModelsShared;
using WordPressApiClient.Models.Post;

namespace WordPressApiClient.Models.Comment {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CreatedCommentModel : CommentModelBase {
        public int Id { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string DateGmt { get; set; }
        public ContentModel Content { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public Dictionary<string, string> AuthorAvatarUrls { get; set; }
    }
}
