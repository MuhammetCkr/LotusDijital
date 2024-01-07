namespace LotusDijital.WebUI.Models
{
    public class PageModel : BaseModel
    {
        public string Title { get; set; }
        public List<InnerPageModel> InnerPages { get; set; }
    }
}