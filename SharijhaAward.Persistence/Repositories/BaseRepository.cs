using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace SharijhaAward.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected SharijhaAwardDbContext _dbContext { get; set; }
        protected readonly DbSet<T> _DbSet;
        public BaseRepository(SharijhaAwardDbContext dbContext)
        {
            _dbContext = dbContext;
            _DbSet = _dbContext.Set<T>();
        }
        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            T? t = await _DbSet.FindAsync(id);
            return t;
        }
        public virtual async Task<T?> GetByIdAsync(int id)
        {
            T? t = await _DbSet.FindAsync(id);
            return t;
        }
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _DbSet.ToListAsync();
        }
        public async virtual Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size)
        {
            return await _DbSet.Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }
        public async Task<T> AddAsync(T entity)
        {
            await _DbSet.AddAsync(entity);
            typeof(T).GetProperty("CreatedAt").SetValue(entity, DateTime.UtcNow);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _DbSet.AddRangeAsync(entities);

            PropertyInfo createdAtProperty = typeof(T).GetProperty("CreatedAt");
            if (createdAtProperty != null && createdAtProperty.PropertyType == typeof(DateTime))
            {
                DateTime currentTime = DateTime.UtcNow;
                foreach (T entity in entities)
                {
                    createdAtProperty.SetValue(entity, currentTime);
                }
            }

            await _dbContext.SaveChangesAsync();

            return entities;
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

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate);
        }
        public T? FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.FirstOrDefault(predicate);
        }
        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _DbSet.FirstOrDefaultAsync(predicate);
        }
        public T? LastOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.LastOrDefault(predicate);
        }
        public async Task<T?> LastOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _DbSet.LastOrDefaultAsync(predicate);
        }
        public IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
        {
            return _DbSet.Select(selector);
        }
        public IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            return _DbSet.OrderBy(keySelector);
        }
        public IQueryable<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            return _DbSet.OrderByDescending(keySelector);
        }
        public IQueryable<T> Include(string navigationPropertyPath)
        {
            return _DbSet.Include(navigationPropertyPath);
        }
        public IQueryable<T> Include(Expression<Func<T, object>> navigationProperty)
        {
            string navigationPropertyPath = GetNavigationPropertyPath(navigationProperty);
            return _DbSet.Include(navigationPropertyPath);
        }
        public IQueryable<T> IncludeThenWhere(Expression<Func<T, object>> navigationProperty, 
            Expression<Func<T, bool>> predicate)
        {
            string navigationPropertyPath = GetNavigationPropertyPath(navigationProperty);
            return _DbSet.Include(navigationPropertyPath).Where(predicate);
        }
        public IQueryable<T> WhereThenInclude(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> navigationProperty)
        {
            string navigationPropertyPath = GetNavigationPropertyPath(navigationProperty);
            return _DbSet.Where(predicate).Include(navigationPropertyPath);
        }
        public T? IncludeThenFirstOrDefault(string navigationPropertyPath, Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Include(navigationPropertyPath).FirstOrDefault(predicate);
        }
        public T? IncludeThenLastOrDefault(string navigationPropertyPath, Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Include(navigationPropertyPath).LastOrDefault(predicate);
        }
        private string GetNavigationPropertyPath(Expression<Func<T, object>> navigationProperty)
        {
            if (navigationProperty == null)
                throw new ArgumentNullException(nameof(navigationProperty));

            if (!(navigationProperty.Body is MemberExpression memberExpression))
                throw new ArgumentException("Invalid expression type. Expected MemberExpression.", nameof(navigationProperty));

            var properties = memberExpression.ToString().Split('.');
            return string.Join(".", properties.Skip(1));
        }
    }
}
