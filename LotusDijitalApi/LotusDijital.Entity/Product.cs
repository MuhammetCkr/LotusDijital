using LotusDijital.Entity;
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
        public string Title { get; set; }
        public string Contents { get; set; } // İçerik
        public string ShortContent { get; set; } // Kısa içerik
        public string Image { get; set; }
        public string SmallImage { get; set; }
        public string Banner { get; set; }
        public bool IsHome { get; set; }
        public string Link { get; set; }
        public string TrendyolLink { get; set; }
        public string HepsiBuradaLink { get; set; }
        public string CicekSepetiLink { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
        public List<ImageGallery> ImageGalleries { get; set; }
        public List<VideoGallery> VideoGalleries { get; set; }
        public List<DocumentGallery> DocumentGalleries { get; set; }
    }
}


