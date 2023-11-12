using LotusDijital.Business.Abstract;
using LotusDijital.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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

        [HttpGet("/category/{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var response = await _categoryService.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("/addcategory")]
        public async Task<IActionResult> Create(AddCategoryDto addCategoryDto)
        {
            var categoryDto = new CategoryDto()
            {
                Image = addCategoryDto.Image,
                IsActive = addCategoryDto.IsActive,
                Name = addCategoryDto.Name,
                Url = addCategoryDto.Url
            };
            var response = await _categoryService.CreateAsync(categoryDto);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPut("/updatecategory")]
        public async Task<IActionResult> Update(UpdateCategoryDto updateCategoryDto)
        {
            var categoryDto = new CategoryDto()
            {
                Id = updateCategoryDto.Id,
                Url = updateCategoryDto.Url,
                IsActive = updateCategoryDto.IsActive,
                Name = updateCategoryDto.Name,
                Image = updateCategoryDto.Image,
            };
            var response = await _categoryService.UpdateAsync(categoryDto);
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
