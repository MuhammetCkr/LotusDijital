using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LotusDijital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InnerPageController : ControllerBase
    {
        private readonly IInnerPageService _innerPageService;

        public InnerPageController(IInnerPageService innerPageService)
        {
            _innerPageService = innerPageService;
        }

        [HttpPost("/addInnerPage")]
        public async Task<IActionResult> AddInnerPage(AddInnerPageDto addInnerPageDto)
        {
            var response = await _innerPageService.CreateAsync(addInnerPageDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);

        }

        [HttpGet("/getInnerPage/{id}")]
        public async Task<IActionResult> GetInnerPage(int id)
        {
            var innerPage = await _innerPageService.GetInnerPageDto(id);
            var jsonSerialize = JsonSerializer.Serialize(innerPage);
            return Ok(jsonSerialize);
        }
    }
}
