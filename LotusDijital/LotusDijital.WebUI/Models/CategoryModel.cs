using System.Text.Json.Serialization;

namespace LotusDijital.WebUI.Models
{
    public class CategoryModel : BaseModel
    {
        public string ErrorMessage { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public List<ProductModel> Products { get; set; }

    }
}
