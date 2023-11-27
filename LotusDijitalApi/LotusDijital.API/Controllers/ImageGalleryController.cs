using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LotusDijital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageGalleryController : ControllerBase
    {
        private readonly IImageGalleryService _imageGalleryService;

        public ImageGalleryController(IImageGalleryService imageGalleryService)
        {
            _imageGalleryService = imageGalleryService;
        }

        [HttpPost("/addImageGallery")]
        public async Task<IActionResult> AddImageGallery(AddImageGalleryDto addImageGalleryDto)
        {
            var response = await _imageGalleryService.CreateAsync(addImageGalleryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
