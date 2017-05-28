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
    public class EditedPageModel : PageModel {
        public int Id { get; set; }
    }
}
