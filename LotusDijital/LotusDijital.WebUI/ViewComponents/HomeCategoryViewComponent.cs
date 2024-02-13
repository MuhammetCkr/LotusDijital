using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.ViewComponents
{
    public class HomeCategoryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await CategoryDAL.GetCategoriesWithProducts();
            return View(categoryList);
        }
    }
}
