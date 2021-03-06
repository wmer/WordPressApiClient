﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Comment {
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CommentModel : CommentModelBase {
        public string Content { get; set; }
    }
}
