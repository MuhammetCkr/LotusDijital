namespace LotusDijital.WebUI.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public ImageGalleryModel ImageGallery { get; set; }
        public int? ImageGalleryId { get; set; }
    }
}