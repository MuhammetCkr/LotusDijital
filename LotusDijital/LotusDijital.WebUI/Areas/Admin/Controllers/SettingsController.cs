using LotusDijital.WebUI.Areas.Admin.Data;
using LotusDijital.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetSettings(int id)
        {
            var settings = await AreaSettingsDAL.GetSettings(id);
            return View(settings);
        }

        public async Task<IActionResult> UpdateSettings(SettingsModel settingsModel, IFormFile logo, IFormFile favicon)
        {
            settingsModel.Logo = logo == null ? "" : Jobs.UploadImage(logo);
            settingsModel.Favicon = favicon == null ? "" : Jobs.UploadImage(favicon);
            var result = await AreaSettingsDAL.UpdateAsync(settingsModel);
            return Json(new { status = result });
        }
    }
}
