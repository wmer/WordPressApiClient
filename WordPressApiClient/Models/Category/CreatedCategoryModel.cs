using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Category {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CreatedCategoryModel : CategoryModel {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Taxonomy { get; set; }
        public string Link { get; set; }
    }
}
