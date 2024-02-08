using LotusDijital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Abstract
{
    public interface IPageRepository : IGenericRepository<Page>
    {
        Task<Page> GetPageWithInnerPage(int pageId);
        Task<List<Page>> GetPageListAsync();

    }
}
