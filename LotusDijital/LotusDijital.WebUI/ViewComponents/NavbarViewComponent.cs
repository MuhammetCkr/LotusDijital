using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pageList = await PageDAL.PageList();
            return View(pageList);
        }
    }
}
