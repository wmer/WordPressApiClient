using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Taxonomy {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class TaxonomyModel {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string[] Types { get; set; }
        public bool Hierarchical { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string RestBase { get; set; }
    }
}
