using LotusDijital.WebUI.Areas.Admin.Data;
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

    }
}
