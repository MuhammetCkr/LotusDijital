using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class BaseModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }
    }
}
