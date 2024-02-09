using LotusDijital.WebUI.Models;
using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Areas.Admin.Models
{
    public class AddProductModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public string ErrorMessage { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; } // İçerik
        public string ShortContent { get; set; } // Kısa içerik
        public string Image { get; set; }
        public string SmallImage { get; set; }
        public string Banner { get; set; }
        public bool IsHome { get; set; }
        public string Link { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<int> ImageGalleryIds { get; set; }
        public List<int> VideoGalleryIds { get; set; }
        public List<int> DocumentGalleryIds { get; set; }

    }
}
