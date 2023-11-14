using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LotusDijital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost("/addproduct")]
        public async Task<IActionResult> AddProduct(AddProductDto addProductDto)
        {
            var productDto = new ProductDto()
            {
                Categories = addProductDto.CategoryIds,
                DocumentGalleries = addProductDto.DocumentGalleries,
                Image = addProductDto?.Image,
                ImageGalleries = addProductDto?.ImageGalleries,
                IsActive = addProductDto.IsActive,
                Link = addProductDto?.Link,
                Name = addProductDto?.Name,
                Url = addProductDto?.Url,
                VideoGalleries = addProductDto?.VideoGalleries,
            };
            var response = await _productService.CreateAsync(productDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
