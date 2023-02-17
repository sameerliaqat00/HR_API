﻿using HR_API.Models;
using System.Linq.Expressions;

namespace HR_API.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties= null, int pageSize = 0, int pageNumber = 1);
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true,string? includeProperties=null);
        Task CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
