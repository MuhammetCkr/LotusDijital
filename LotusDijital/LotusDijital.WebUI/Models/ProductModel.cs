﻿using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class ProductModel : BaseModel
    {        
        public string ErrorMessage { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; } // İçerik
        public string ShortContent { get; set; } // Kısa içerik
        public string Image { get; set; }
        public string SmallImage { get; set; }
        public string Banner { get; set; }
        public bool IsHome { get; set; }
        public string Link { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public List<ImageGalleryModel> ImageGalleries { get; set; }
        public List<VideoGalleryModel> VideoGalleries { get; set; }
        public List<DocumentGalleryModel> DocumentGalleries { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> ImageGalleryIds { get; set; }
        public List<int> VideoGalleryIds { get; set; }
        public List<int> DocumentGalleryIds { get; set; }
    }
}
