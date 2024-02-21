using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<T?> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetWhereThenPagedReponseAsync(Expression<Func<T, bool>> predicate, int page, int size);
        T? FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        T? LastOrDefault(Expression<Func<T, bool>> predicate);
        Task<T?> LastOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);
        IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector);
        IQueryable<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector);
        IQueryable<T> Include(string navigationPropertyPath);
        IQueryable<T> Include(Expression<Func<T, object>> navigationProperty);
        IQueryable<T> IncludeThenWhere(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
        IQueryable<T> WhereThenInclude(Expression<Func<T, bool>> predicate,
            Expression<Func<T, object>> navigationProperty);
        T? IncludeThenFirstOrDefault(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
        T? IncludeThenLastOrDefault(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
    }
}
