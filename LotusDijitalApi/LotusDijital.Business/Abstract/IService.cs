using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Abstract
{
    public interface IService<TDto>
    {
        Task<TDto> GetByIdAsync(int id);
        Task<List<TDto>> GetAllAsync();
        Task<List<TDto>> GetManyAsync(Expression<Func<TDto, bool>> expression);
        Task<bool> DeleteAsync(TDto tDto);
    }
}
