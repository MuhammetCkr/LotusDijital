using LotusDijital.Data.Abstract;
using LotusDijital.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Base
    {
        protected readonly DbContext _dbContext;

        public EfCoreGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            try
            {
                var existingEntity = await _dbContext.Set<TEntity>().FindAsync(entity.Id);
                _dbContext.Set<TEntity>().Remove(existingEntity);
                var result = await _dbContext.SaveChangesAsync();
                return result > 0;
            }
            catch (Exception e)
            {

                throw;
            }

        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            //.AsNoTracking()
            //.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);

            return entity;
        }

        public async Task<List<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entityList = await _dbContext.Set<TEntity>().Where(expression).ToListAsync();
            return entityList;
        }

        async Task<TEntity> IGenericRepository<TEntity>.CreateAsync(TEntity entity)
        {
            try
            {
                var isThere = _dbContext.Set<TEntity>().Any(x => x.Name == entity.Name);
                if (!isThere)
                {
                    await _dbContext.Set<TEntity>().AddAsync(entity);
                    var result = await _dbContext.SaveChangesAsync();
                    return result > 0 ? entity : null;
                }
                return null;
            }
            catch (Exception e)
            {

                throw;
            }

        }

        async Task<TEntity> IGenericRepository<TEntity>.UpdateAsync(TEntity entity)
        {
            var isThere = _dbContext.Set<TEntity>().Any(x => x.Name == entity.Name && x.Id != entity.Id);
                            
            if (!isThere)
            {
                try
                {
                    _dbContext.Set<TEntity>().Update(entity);
                    var result = await _dbContext.SaveChangesAsync();
                    return result > 0 ? entity : null;
                }
                catch (Exception e)
                {

                    throw;
                }
            }
            return null;
        }
    }
}
