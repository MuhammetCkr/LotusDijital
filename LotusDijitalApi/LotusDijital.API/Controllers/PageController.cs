using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LotusDijital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [HttpGet("/pageList")]
        public async Task<IActionResult> PageList()
        {
            var response = await _pageService.GetPageListAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("/getPage/{id}")]
        public async Task<IActionResult> GetPage(int id)
        {
            var response = await _pageService.GetPageWithInnerPage(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("/addPage")]
        public async Task<IActionResult> AddPage(AddPageDto addPageDto)
        {
            var response = await _pageService.CreatAsync(addPageDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("/deletePage/{id}")]
        public async Task<IActionResult> DeletePage(int id)
        {
            var pageDto = await _pageService.GetPageWithInnerPage(id);
            var response = await _pageService.DeleteAsync(pageDto);
            return Ok(response);
        }
    }
}
