using LotusDijital.Data.Abstract;
using LotusDijital.Data.Concrete.EfCore.Context;
using LotusDijital.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Concrete.EfCore.Repositories
{
    public class EfCorePageRepository : EfCoreGenericRepository<Page>, IPageRepository
    {
        public EfCorePageRepository(LotusDijitalDbContext _context) : base(_context) { }

        LotusDijitalDbContext context
        {
            get { return _dbContext as LotusDijitalDbContext; }
        }

        public async Task<List<Page>> GetPageListAsync()
        {
            var pageList = await context.Pages
                .Include(p => p.InnerPages)
                .ToListAsync();
            return pageList;
        }

        public async Task<Page> GetPageWithInnerPage(int pageId)
        {
            var page = await context.Pages
                .Where(p => p.Id == pageId)
                .Include(p => p.InnerPages)
                .SingleOrDefaultAsync();
            return page;
        }
    }
}
