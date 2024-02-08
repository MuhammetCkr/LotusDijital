using LotusDijital.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Business.Abstract
{
    public interface IPageService : IService<PageDto>
    {
        Task<bool> CreatAsync(AddPageDto addPageDto);
        Task<PageDto> GetPageWithInnerPage(int pageId);
        Task<List<PageDto>> GetPageListAsync();
    }
}
