using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Entity
{
    public class Product : Base
    {
        public Product()
        {
            ProductCategories = new List<ProductCategories>();
            VideoGalleries = new List<VideoGallery>();
            ImageGalleries = new List<ImageGallery>();
            DocumentGalleries = new List<DocumentGallery>();
        }
        public string Image { get; set; }
        public string Link { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
        public List<ImageGallery> ImageGalleries { get; set; }
        public List<VideoGallery> VideoGalleries { get; set; }
        public List<DocumentGallery> DocumentGalleries { get; set; }
    }
}
