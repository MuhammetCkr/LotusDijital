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
    public class PageManager : IPageService
    {
        private readonly IPageRepository _pageRepository;
        private readonly IMapper _mapper;
        public PageManager(IPageRepository pageRepository, IMapper mapper)
        {
            _pageRepository = pageRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreatAsync(AddPageDto addPageDto)
        {
            var pageAdd = _mapper.Map<Page>(addPageDto);
            var result = await _pageRepository.CreateAsync(pageAdd);
            if (result == null)
                return false;

            return true;

        }

        public async Task<bool> DeleteAsync(PageDto tDto)
        {
            var deletePage = _mapper.Map<Page>(tDto);
            var result = await _pageRepository.DeleteAsync(deletePage);
            return result;
        }

        public async Task<List<PageDto>> GetAllAsync()
        {
            var pageList = await _pageRepository.GetAllAsync();
            if (pageList.Count > 0)
            {
                return _mapper.Map<List<PageDto>>(pageList);
            }
            return new List<PageDto>() { new PageDto() { ErrorMessage = "Kayıtlı sayfa bulunamadı" } };
        }

        public async Task<PageDto> GetByIdAsync(int id)
        {
            var page = await _pageRepository.GetByIdAsync(id);
            var pageDto = _mapper.Map<PageDto>(page);
            return pageDto;
        }

        public Task<List<PageDto>> GetManyAsync(Expression<Func<PageDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PageDto>> GetPageListAsync()
        {
            var pageList = await _pageRepository.GetPageListAsync();
            var pageDtoList = _mapper.Map<List<PageDto>>(pageList);
            return pageDtoList;
        }

        public async Task<PageDto> GetPageWithInnerPage(int pageId)
        {
            var page = await _pageRepository.GetPageWithInnerPage(pageId);
            if (page != null)
            {
                var pageDto = _mapper.Map<PageDto>(page);
                return pageDto;
            }
            return null;
        }
    }
}
