using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LotusDijital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("/categories")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryService.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("/getCategoriesWithProducts")]
        public async Task<IActionResult> GetCategoriesWithProducts()
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };
            var response = await _categoryService.GetCategoriesWithProducts();
            try
            {
                var jsonResponse = JsonSerializer.Serialize(response,options);
                return Ok(jsonResponse);

            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpGet("/category/{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var response = await _categoryService.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("/addcategory")]
        public async Task<IActionResult> AddCategory(AddCategoryDto addCategoryDto)
        {
            var response = await _categoryService.CreateAsync(addCategoryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("/updatecategory")]
        public async Task<IActionResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            var response = await _categoryService.UpdateAsync(updateCategoryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("/deletecategory/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var categoryDto = await _categoryService.GetByIdAsync(id);
            var response  = await _categoryService.DeleteAsync(categoryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
