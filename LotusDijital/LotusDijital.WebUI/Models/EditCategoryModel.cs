using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class EditCategoryModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [JsonPropertyName("Details")]
        public string Details { get; set; }
    }
}
