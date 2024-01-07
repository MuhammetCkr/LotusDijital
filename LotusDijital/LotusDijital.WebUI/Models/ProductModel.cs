using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class ProductModel : BaseModel
    {        
        [JsonPropertyName("ErrorMessage")]
        public string ErrorMessage { get; set; }
        
        [JsonPropertyName("Image")]
        public string Image { get; set; }
        
        [JsonPropertyName("Link")]
        public string Link { get; set; }

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
