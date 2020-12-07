using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloWorld.Sqlite.Data.Contexts;
using HelloWorld.Sqlite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelloWorld.Sqlite.Data.Repositories
{
    public class MainRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MainDbContext dbContext;

        private DbSet<T> entities;

        public MainRepository(MainDbContext context)
        {
            this.dbContext = context;
            entities = dbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task AddMultipleAsync(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }

            foreach (var entity in entities)
            {
                await dbContext.AddAsync(entity);
            }

            await dbContext.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public async Task<T> GetAsync(int id)
        {
            return await entities.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entity.UpdatedAt = DateTime.Now;

            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateMultipleAsync(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }

            foreach (var entity in entities)
            {
                entity.UpdatedAt = DateTime.Now;
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var selectedEntity = await GetAsync(id);

            if (selectedEntity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Remove(selectedEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteMultipleAsync(IEnumerable<T> deletingEntities)
        {
            if (deletingEntities == null)
            {
                throw new ArgumentNullException("entities");
            }

            foreach (var entity in deletingEntities)
            {
                entities.Remove(entity);
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
