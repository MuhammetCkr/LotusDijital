using LotusDijital.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<bool> SaveProductCategoriesAsync(int productId, List<int> categoryIds, List<int> imageGalleryIds, List<int> videoGalleryIds, List<int> documentGalleryIds);
    }
}