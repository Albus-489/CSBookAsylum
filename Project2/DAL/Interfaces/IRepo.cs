﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DAL.Interfaces
{
    public interface IRepo<T> where T : class, new()
    {
        IQueryable<T> Items { get; }
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id, CancellationToken Cancel = default);

        Task AddAsync(T entity, CancellationToken Cancel = default);

        Task UpdateAsync(T entity, CancellationToken Cancel = default);

        Task RemoveAsync(int id, CancellationToken Cancel = default);
    }
}
