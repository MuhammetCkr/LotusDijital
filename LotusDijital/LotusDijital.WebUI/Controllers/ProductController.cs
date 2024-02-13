using LotusDijital.WebUI.Data;
using LotusDijital.WebUI.ViewModel;
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

        [HttpGet("getProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await ProductDAL.GetProductById(id);
            var productList = await ProductDAL.GetProductsWithCategories();
            var productViewModel = new ProductViewModel()
            {
                ProductModel = product,
                ProductList = productList
            };
            return View(productViewModel);
        }
    }
}
