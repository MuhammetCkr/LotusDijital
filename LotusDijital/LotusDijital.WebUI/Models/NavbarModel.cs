using LotusDijital.WebUI.Areas.Admin.Models;

namespace LotusDijital.WebUI.Models
{
    public class NavbarModel
    {
        public List<PageModel> Pages { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public SettingsModel Settings { get; set; }
    }
}
