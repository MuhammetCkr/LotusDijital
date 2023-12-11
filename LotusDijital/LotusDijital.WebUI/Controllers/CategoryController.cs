using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await CategoryDAL.GetCategoriesAsync();
            return View();
        }


    }
}
