using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.User {
    public abstract class UserModelBase {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
    }
}
