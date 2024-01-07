﻿using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class CategoryModel : BaseModel
    {
        [JsonPropertyName("ErrorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("Image")]
        public string Image { get; set; }

        [JsonPropertyName("Details")]
        public string Details { get; set; }

    }
}
