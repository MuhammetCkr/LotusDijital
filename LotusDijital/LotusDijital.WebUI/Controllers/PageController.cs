using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getPage")]
        public async Task<IActionResult> GetPage(int id)
        {
            var pageModel = await PageDAL.GetPage(id);
            return View(pageModel);
        }

    }
}
