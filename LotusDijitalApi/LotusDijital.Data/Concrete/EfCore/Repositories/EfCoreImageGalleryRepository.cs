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
    public class EfCoreImageGalleryRepository : EfCoreGenericRepository<ImageGallery>, IImageGalleryReposiyory
    {
        public EfCoreImageGalleryRepository(LotusDijitalDbContext _context) : base(_context) { }

        LotusDijitalDbContext context
        {
            get { return _dbContext as LotusDijitalDbContext; }
        }

        public async Task<ImageGallery> GetImageGallery(int id)
        {
            var imageGallery = await context.ImageGalleries
                .Where(ig => ig.Id == id)
                .Include(ig => ig.Images)
                .SingleOrDefaultAsync();
            return imageGallery;
        }

        public async Task<List<ImageGallery>> GetImageGalleryListDto()
        {
            var imageGalleryList = await context.ImageGalleries
                .Include(ig => ig.Images)
                .ToListAsync();
            return imageGalleryList;
        }
    }
}
