using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productList = await ProductDAL.GetProductList();
            var isHome = productList.Where(p => p.IsActive && p.IsHome).ToList();
            return View(isHome);
        }
    }
}
