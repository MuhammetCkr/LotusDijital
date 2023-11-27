using LotusDijital.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public EfCoreGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);

            return entity;
        }

        public Task<List<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        async Task<TEntity> IGenericRepository<TEntity>.CreateAsync(TEntity entity)
        {
            try
            {
                await _dbContext.Set<TEntity>().AddAsync(entity);
                var result = await _dbContext.SaveChangesAsync();
                return result > 0 ? entity : null;
            }
            catch (Exception e)
            {

                throw;
            }

        }

        async Task<TEntity> IGenericRepository<TEntity>.UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0 ? entity : null;
        }
    }
}
