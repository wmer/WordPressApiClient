using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressApiClient.Models.Media {
    public class ImageSizesModel {
        public ImageThumbnailModel Thumbnail { get; set; }
        public ImageMediumModel Medium { get; set; }
        public ImageFullModel Full { get; set; }
    }
}
