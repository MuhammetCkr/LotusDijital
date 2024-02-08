using AutoMapper;
using LotusDijital.Business.Abstract;
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
    public class InnerPageManager : IInnerPageService
    {
        private readonly IMapper _mapper;
        private readonly IInnerPageRepository _innerPageRepository;

        public InnerPageManager(IMapper mapper, IInnerPageRepository innerPageRepository)
        {
            _mapper = mapper;
            _innerPageRepository = innerPageRepository;
        }

        public async Task<bool> CreateAsync(AddInnerPageDto addInnerPageDto)
        {
            var innerPage = _mapper.Map<InnerPage>(addInnerPageDto);
            var result = await _innerPageRepository.CreateAsync(innerPage);
            if (result == null)
                return false;

            return true;

        }

        public Task<bool> DeleteAsync(InnerPageDto tDto)
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

        public async Task<InnerPageDto> GetInnerPageDto(int id)
        {
            var innerPage = await _innerPageRepository.GetInnerPage(id);
            var innerPageDto = _mapper.Map<InnerPageDto>(innerPage);
            return innerPageDto;
        }

        public Task<List<InnerPageDto>> GetManyAsync(Expression<Func<InnerPageDto, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
