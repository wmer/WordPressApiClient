using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Models.Post;

namespace WordPressApiClient.Models.Page {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PageModel : PageModelBase {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Excerpt { get; set; }
    }
}
