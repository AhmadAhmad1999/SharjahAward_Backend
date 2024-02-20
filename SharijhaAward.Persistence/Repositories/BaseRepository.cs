using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected SharijhaAwardDbContext _dbContext { get; set; }

        public BaseRepository(SharijhaAwardDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            T? t = await _dbContext.Set<T>().FindAsync(id);
            return t;
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async virtual Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<T>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            typeof(T).GetProperty("CreatedAt").SetValue(entity, DateTime.UtcNow);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


        public async Task DeleteAsync(T entity)
        {
            typeof(T).GetProperty("isDeleted").SetValue(entity, true);
            typeof(T).GetProperty("DeletedAt").SetValue(entity, DateTime.UtcNow);
            await _dbContext.SaveChangesAsync();
        }
    }
}
