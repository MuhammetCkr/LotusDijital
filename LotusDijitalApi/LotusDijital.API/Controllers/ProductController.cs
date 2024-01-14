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

        [HttpGet("/products")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("/addProduct")]
        public async Task<IActionResult> AddProduct(AddProductDto addProductDto)
        {
            var response = await _productService.CreateAsync(addProductDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("/updateProduct")]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var response = await _productService.UpdateAsync(updateProductDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("/deleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var productDto = await _productService.GetByIdAsync(id);
            var response = await _productService.DeleteAsync(productDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(response);
        }
    }
}
