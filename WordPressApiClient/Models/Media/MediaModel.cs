using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Media {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class MediaModel : MediaModelBase {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
    }
}
