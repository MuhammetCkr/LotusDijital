using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InnerPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddInnerPage(int pageId)
        {
            ViewBag.PageId = pageId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddInnerPage(AddInnerPageModel model, IFormFile image, IFormFile banner)
        {
            if (image != null)
                model.Image = Jobs.UploadImage(image);
            if (banner != null)
                model.Banner = Jobs.UploadImage(banner);
            var response = await AreaInnerPageDAL.AddInnerPage(model);
            return Json(new { status = response });
        }


    }
}
