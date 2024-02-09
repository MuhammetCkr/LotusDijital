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
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(LotusDijitalDbContext _context) : base(_context) { }

        LotusDijitalDbContext context
        {
            get { return _dbContext as LotusDijitalDbContext; }
        }

        public async Task<List<Product>> GetProductsWithCategories()
        {
            var productList = await context.Products
                .Include(p => p.ProductCategories).ThenInclude(pc => pc.Category)
                .ToListAsync();
            return productList;
        }

        public async Task<bool> SaveProductCategoriesAsync(int productId, List<int> categoryIds)
        {
            var productCategories =  categoryIds.Select(catId => new ProductCategories
            {
                ProductId = productId,
                CategoryId = catId
            }).ToList();
            context.AddRange(productCategories);

            var result = await context.SaveChangesAsync();
            return result > 0;

        }

    }
}
