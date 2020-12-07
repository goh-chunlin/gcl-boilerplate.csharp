using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Sqlite.Data.Entities;

namespace HelloWorld.Sqlite.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        // Create
        Task AddAsync(T entity);
        Task AddMultipleAsync(IEnumerable<T> entities);

        // Read
        IQueryable<T> GetAll();
        Task<T> GetAsync(int id);

        // Update
        Task UpdateAsync(T entity);
        Task UpdateMultipleAsync(IEnumerable<T> entities);

        // Delete
        Task DeleteAsync(int id);
        Task DeleteMultipleAsync(IEnumerable<T> deletingEntities);
    }
}
