using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Media {
    public class MediaDetailsModel {
        public int Width { get; set; }
        public int Height { get; set; }
        public string File { get; set; }
        public ImageSizesModel Sizes { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public ImageMetaModel ImageMeta { get; set; }
    }
}
