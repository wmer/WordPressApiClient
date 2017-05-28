using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Category {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CategoryModel {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public int Parent { get; set; }
    }
}
