using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using LotusDijital.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products = await AreaProductDAL.GetProductAsync();
            return View(products);
        }

        [HttpGet("addProduct")]
        public async Task<IActionResult> AddProduct()
        {
            var categories = await AreaCategoryDAL.GetCategoriesAsync();
            var productModel = new ProductModel()
            {
                Categories = categories
            };
            return View(productModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductModel addProductModel, IFormFile image)
        {
            if (image != null)
                addProductModel.Image = Jobs.UploadImage(image);
            var response = await AreaProductDAL.AddProductAsync(addProductModel);
            return Json(new { status = response });
        }
    }
}
