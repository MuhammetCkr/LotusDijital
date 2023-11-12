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
    public class InnerPageManager : IInnerPageService
    {
        public Task<bool> CreateAsync(InnerPageDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(InnerPageDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<InnerPageDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<InnerPageDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InnerPageDto>> GetManyAsync(Expression<Func<InnerPageDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(InnerPageDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
