using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
