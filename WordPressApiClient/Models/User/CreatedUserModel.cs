using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.User {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CreatedUserModel : UserModelBase {
        public int Id { get; set; }
        public string Link { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public Dictionary<string, string> AvatarUrls { get; set; }
        public List<object> Meta { get; set; }
    }
}
