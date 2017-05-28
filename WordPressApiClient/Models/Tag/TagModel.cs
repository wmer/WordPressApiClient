using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Models.Category;

namespace WordPressApiClient.Models.Tag {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class TagModel {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int Parent { get; set; }
    }
}
