using System.Text.Json.Serialization;
using LotusDijital.WebUI.Models;

namespace LotusDijital.WebUI.Areas.Admin.Models
{
    public class EditCategoryModel : BaseModel
    {
        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [JsonPropertyName("Details")]
        public string Details { get; set; }
    }
}
