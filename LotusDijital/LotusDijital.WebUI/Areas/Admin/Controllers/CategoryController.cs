using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await AreaCategoryDAL.GetCategoriesAsync();
            return View(categories);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryModel categoryModel)
        {
            var response = await AreaCategoryDAL.AddCategory(categoryModel);
            var status = response ? 200 : 0;
            return Json(new { status = status });
        }
    }
}
