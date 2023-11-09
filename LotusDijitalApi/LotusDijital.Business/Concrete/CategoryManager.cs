using LotusDijital.Business.Abstract;
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
        public Task<bool> CreateAsync(CategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(CategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetManyAsync(Expression<Func<CategoryDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CategoryDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
