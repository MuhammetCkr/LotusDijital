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
    public class ProductManager : IProductService
    {
        public Task<bool> CreateAsync(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetManyAsync(Expression<Func<ProductDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ProductDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
