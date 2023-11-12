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
    public class PageManager : IPageService
    {
        public Task<bool> CreateAsync(PageDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(PageDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<PageDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PageDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PageDto>> GetManyAsync(Expression<Func<PageDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(PageDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
