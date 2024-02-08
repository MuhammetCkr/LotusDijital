using LotusDijital.WebUI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Controllers
{
    public class InnerPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getInnerPage")]
        public async Task<IActionResult> GetInnerPage(int id)
        {
            var innerPageModel = await InnerPageDAL.GetInnerPage(id);

            return View(innerPageModel);
        }
    }
}
