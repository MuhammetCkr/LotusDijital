using LotusDijital.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LotusDijital.WebUI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}