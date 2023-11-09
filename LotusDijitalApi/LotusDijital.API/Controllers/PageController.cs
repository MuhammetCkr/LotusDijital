using LotusDijital.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LotusDijital.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;
        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

    }
}
