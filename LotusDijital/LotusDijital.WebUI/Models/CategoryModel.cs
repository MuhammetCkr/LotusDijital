using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class CategoryModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
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

    }
}
