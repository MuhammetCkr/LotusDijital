using AutoMapper;
using LotusDijital.Business.Abstract;
using LotusDijital.Core;
using LotusDijital.Data.Abstract;
using LotusDijital.Entity;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(AddCategoryDto addCategoryDto)
        {
            var categoryAdd = _mapper.Map<Category>(addCategoryDto);
            categoryAdd.Url = Jobs.MakeUrl(addCategoryDto.Name);
            var result = await _categoryRepository.CreateAsync(categoryAdd);
            return result != null;
        }

        public async Task<bool> DeleteAsync(CategoryDto dto)
        {
            var categoryDelete = _mapper.Map<Category>(dto);
            var result = await _categoryRepository.DeleteAsync(categoryDelete);
            return result;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            if (categories.Count == 0)
            {
                return new List<CategoryDto> { new CategoryDto() { ErrorMessage = "Hiç kategori bulunamadı" } };
            }
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);
            return categoryDtos;
        }

        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return new CategoryDto() { ErrorMessage = "kategori bulunamadı!" };
            }
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return categoryDto;
        }

        public async Task<List<CategoryDto>> GetCategoriesWithProducts()
        {
            var categoryList = await _categoryRepository.GetCategoriesWithProducts();
            var categoryListDto = _mapper.Map<List<CategoryDto>>(categoryList);
            return categoryListDto;
        }

        public Task<List<CategoryDto>> GetManyAsync(Expression<Func<CategoryDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            var updateCategory = _mapper.Map<Category>(updateCategoryDto);
            updateCategory.Url = Jobs.MakeUrl(updateCategoryDto.Name);
            var result = await _categoryRepository.UpdateAsync(updateCategory);
            return result != null;
        }
    }
}
