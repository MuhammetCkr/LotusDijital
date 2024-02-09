using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Abstract
{
    public interface IProductService : IService<ProductDto>
    {
        Task<bool> CreateAsync(AddProductDto addProductDto);
        Task<bool> UpdateAsync(UpdateProductDto updateProductDto);
        Task<List<ProductDto>> GetProductsWithCategories();

    }
}
