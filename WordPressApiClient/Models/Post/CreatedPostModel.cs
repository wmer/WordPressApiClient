﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressApiClient.Models.ModelsShared;

namespace WordPressApiClient.Models.Post {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CreatedPost : PostModelBase {
        public int Id { get; set; }
        public GuidModel Guid { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string DateGmt { get; set; }
        public String Modified { get; set; }
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public String ModifiedGmt { get; set; }
        public string Link { get; set; }
        public TitleModel Title { get; set; }
        public ContentModel Content { get; set; }
        public ExcerptModel Excerpt { get; set; }
        
    }
}
