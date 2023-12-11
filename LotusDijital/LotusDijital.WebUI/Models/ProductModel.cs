namespace LotusDijital.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public string ErrorMessage { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public List<CategoryModel> Categories { get; set; }
    }
}
