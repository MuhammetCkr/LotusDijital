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
    }
}
