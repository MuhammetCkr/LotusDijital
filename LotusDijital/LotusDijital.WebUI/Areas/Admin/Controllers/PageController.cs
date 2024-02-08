using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PageList()
        {
            var pageList = await AreaPageDAL.PageList();
            return View(pageList);
        }

        [HttpGet]
        public async Task<IActionResult> GetPage(int id)
        {
            var pageModel = await AreaPageDAL.GetPage(id);
            return View(pageModel);
        }

        [HttpGet]
        public IActionResult AddPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPage(AddPageModel pageModel)
        {
            var response = await AreaPageDAL.AddPage(pageModel);
            return Json(new { status = response });
        }

        [HttpGet]
        public async Task<IActionResult> DeletePage(int id)
        {
            var response = await AreaPageDAL.DeletePage(id);
            return Json(new { status = response });
        }
    }
}
