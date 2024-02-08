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
    public class EfCoreInnerPageRepository : EfCoreGenericRepository<InnerPage>, IInnerPageRepository
    {
        public EfCoreInnerPageRepository(LotusDijitalDbContext _context) : base(_context) { }

        LotusDijitalDbContext context
        {
            get { return _dbContext as LotusDijitalDbContext; }
        }

        public async Task<InnerPage> GetInnerPage(int id)
        {
            var innerPage = await context.InnerPages
                .Where(ip => ip.Id == id)
                .Include(ip => ip.VideoGalleries)
                .Include(ip => ip.DocumentGalleries)
                .Include(ip => ip.ImageGalleries).ThenInclude(i => i.Images)
                .SingleOrDefaultAsync();
            return innerPage;
        }
    }
}
