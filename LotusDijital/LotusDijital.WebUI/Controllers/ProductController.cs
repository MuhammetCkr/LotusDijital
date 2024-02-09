using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("productList")]
        public async Task<IActionResult> ProductList()
        {
            var productList = await ProductDAL.GetProductsWithCategories();
            return View(productList);
        }
    }
}
