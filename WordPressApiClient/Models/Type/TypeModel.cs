using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Type {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class TypeModel {
        public string Description { get; set; }
        public bool Hierarchical { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<string> Taxonomies { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string RestBase { get; set; }
    }
}
