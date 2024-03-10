using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await CategoryDAL.GetCategoriesWithProducts();
            var isHome = categoryList.Where(c => c.IsActive ).ToList();
            return View(isHome);
        }
    }
}
