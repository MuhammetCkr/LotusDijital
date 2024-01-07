using LotusDijital.WebUI.Models;
using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Areas.Admin.Models
{
    public class AddProductModel
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("ErrorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [JsonPropertyName("Link")]
        public string Link { get; set; }

        [JsonPropertyName("CategoryIds")]
        public List<int> CategoryIds { get; set; }

        [JsonPropertyName("ImageGalleryIds")]
        public List<int> ImageGalleryIds { get; set; }

        [JsonPropertyName("VideoGalleryIds")]
        public List<int> VideoGalleryIds { get; set; }

        [JsonPropertyName("DocumentGalleryIds")]
        public List<int> DocumentGalleryIds { get; set; }

        [JsonPropertyName("Categories")]
        public List<CategoryModel> Categories { get; set; }

        [JsonPropertyName("ImageGalleries")]
        public List<ImageGalleryModel> ImageGalleries { get; set; }

        [JsonPropertyName("VideoGalleries")]
        public List<VideoGalleryModel> VideoGalleries { get; set; }

        [JsonPropertyName("DocumentGalleries")]
        public List<DocumentGalleryModel> DocumentGalleries { get; set; }
    }
}
