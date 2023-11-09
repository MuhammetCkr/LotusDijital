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
    public class ColorManager : IColorService
    {
        public Task<bool> CreateAsync(ColorDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ColorDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColorDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ColorDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColorDto>> GetManyAsync(Expression<Func<ColorDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ColorDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
