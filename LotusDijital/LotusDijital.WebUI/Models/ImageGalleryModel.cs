namespace LotusDijital.WebUI.Models
{
    public class ImageGalleryModel : BaseModel
    {
        public int? ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int? InnerPageId { get; set; }
        public InnerPageModel InnerPage { get; set; }
        public List<ImageModel> Images { get; set; }
    }
}