using LotusDijital.WebUI.Data;
using LotusDijital.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.ViewComponents
{
    public class HomeProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productList = await ProductDAL.GetProductList();
            return View(productList);
        }
    }
}
