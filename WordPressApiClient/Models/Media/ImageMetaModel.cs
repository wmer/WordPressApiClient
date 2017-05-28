using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Media {
    public class ImageMetaModel {
        public string Aperture { get; set; }
        public string Credit { get; set; }
        public string Camera { get; set; }
        public string Caption { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string CreatedTimestamp { get; set; }
        public string Copyright { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string FocalLength { get; set; }
        public string Iso { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string ShutterSpeed { get; set; }
        public string Title { get; set; }
        public string Orientation { get; set; }
        public List<object> Keywords { get; set; }
    }
}
