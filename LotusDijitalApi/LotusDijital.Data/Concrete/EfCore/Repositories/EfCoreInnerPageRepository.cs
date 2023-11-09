using LotusDijital.Data.Abstract;
using LotusDijital.Data.Concrete.EfCore.Context;
using LotusDijital.Entity;
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
    }
}
