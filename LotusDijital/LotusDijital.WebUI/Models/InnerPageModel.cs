
namespace LotusDijital.WebUI.Models
{
    public class InnerPageModel : BaseModel
    {
        public string Title { get; set; }
        public string Contents { get; set; } // İçerik
        public string ShortContent { get; set; } // Kısa içerik
        public string Image { get; set; }
        public string SmallImage { get; set; }
        public string Banner { get; set; }
        public bool IsHome { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int SequenceNumber { get; set; } //Sıra Numarası
        public string Icon { get; set; }
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }
        public string PageKeyword { get; set; }
        public PageModel Page { get; set; }
        public int? PageId { get; set; }
        public List<ImageGalleryModel> ImageGalleries { get; set; }
        public List<VideoGalleryModel> VideoGalleries { get; set; }
        public List<DocumentGalleryModel> DocumentGalleries { get; set; }
    }
}