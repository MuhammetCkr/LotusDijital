namespace LotusDijital.WebUI.Models
{
    public class VideoGalleryModel : BaseModel
    {
        public string VideoImage { get; set; }
        public string VideoEmbed { get; set; }
        public int? ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int? InnerPageId { get; set; }
        public InnerPageModel InnerPage { get; set; }
    }
}