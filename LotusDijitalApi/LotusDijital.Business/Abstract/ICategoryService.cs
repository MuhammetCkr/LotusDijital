using LotusDijital.Entity;
using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Abstract
{
    public interface ICategoryService : IService<CategoryDto>
    {
        Task<bool> CreateAsync(AddCategoryDto addCategoryDto);
        Task<bool> UpdateAsync(UpdateCategoryDto updateCategoryDto);

    }
}
