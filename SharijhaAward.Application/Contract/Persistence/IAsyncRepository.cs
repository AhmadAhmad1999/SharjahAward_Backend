using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;
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
        Task<int> GetCountAsync(Expression<Func<T, bool>>? predicate);
        int GetCount(Expression<Func<T, bool>>? predicate);
        Task<T> GetByIdAsync(int? id);
        Task<T?> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size);
        Task<IReadOnlyList<T>> GetPagedReponseWithPredicateAsync(Expression<Func<T, bool>>? predicate, int page, int size);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteListAsync(IEnumerable<T> entities);
        Task RemoveAsync(T entity);
        Task RemoveListAsync(IEnumerable<T> entities);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        IQueryable<T> WhereThenFilter(Expression<Func<T, bool>> predicate, FilterObject filterObject);
        Task<IReadOnlyList<T>> GetWhereThenPagedReponseAsync(Expression<Func<T, bool>> predicate, int page, int size);
        Task<IReadOnlyList<T>> GetWhereThenPagedReponseAsync(Expression<Func<T, bool>> predicate, FilterObject filterObject, int page, int size);
        T? FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        T? LastOrDefault(Expression<Func<T, bool>> predicate);
        Task<T?> LastOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);
        IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> keySelector);
        IQueryable<T> WhereThenIncludeThenPagination(
            Expression<Func<T, bool>> predicate, int page, int size,
            params Expression<Func<T, object>>[] navigationProperties);
        IQueryable<T> OrderByDescending<TKey>(Expression<Func<T, TKey>> keySelector, int page, int size);
        IQueryable<T> Include(string navigationPropertyPath);
        IQueryable<T> Include(Expression<Func<T, object>> navigationProperty);
        IQueryable<T> IncludeThenWhere(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
        public IQueryable<T> WhereThenInclude(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] navigationProperties);
        T? IncludeThenFirstOrDefault(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
        Task<T?> IncludeThenFirstOrDefaultAsync(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
        T? IncludeThenLastOrDefault(Expression<Func<T, object>> navigationProperty,
            Expression<Func<T, bool>> predicate);
        void SaveChanges();
        Task SaveChangesAsync();
        Task<int> ExecuteUpdateAsync(string sql);
    }
}
