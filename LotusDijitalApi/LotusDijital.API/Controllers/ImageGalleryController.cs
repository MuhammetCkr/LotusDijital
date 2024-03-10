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

        [HttpGet("/getImageGallery/{id}")]
        public async Task<IActionResult> GetImageGallery(int id)
        {
            var response = await _imageGalleryService.GetImageGalleryDto(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("/getImageGalleryList")]
        public async Task<IActionResult> GetImageGalleryList()
        {
            var response = await _imageGalleryService.GetImageGalleryListDto();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("/delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var galleryDto = await _imageGalleryService.GetByIdAsync(id);
            var response = await _imageGalleryService.DeleteAsync(galleryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("/getIsActive/{id}")]
        public async Task<IActionResult> GetIsActive(int id)
        {
            var galleryDto = await _imageGalleryService.GetByIdAsync(id);
            galleryDto.IsActive = !galleryDto.IsActive;
            var response = await _imageGalleryService.UpdateAsync(galleryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);

        }

        //[HttpPost("/update")]
        //public async Task<IActionResult> Update(ImageGalleryDto imageGalleryDto)
        //{
        //    var response = await _imageGalleryService.Upda
        //    return Ok(jsonResponse);
        //}


    }
}
