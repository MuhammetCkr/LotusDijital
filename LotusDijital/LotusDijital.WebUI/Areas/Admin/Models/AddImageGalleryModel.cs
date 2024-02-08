using LotusDijital.WebUI.Models;

namespace LotusDijital.WebUI.Areas.Admin.Models
{
    public class AddImageGalleryModel
    {
        public string Name { get; set; }
        public List<ImageModel> Images { get; set; }
        public bool IsActive { get; set; }
    }
}
