﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Base.Repositories
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Get All Async
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool asNoTracking = true);

        /// <summary>
        /// Get by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T GetById(Guid Id);

        /// <summary>
        /// Get by Id Async
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(Guid Id);

        /// <summary>
        /// Create new
        /// </summary>
        /// <param name="_object"></param>
        /// <returns></returns>
        void Create(T _object);

        Task Delete(T _object);

        /// <summary>
        /// Create Async
        /// </summary>
        /// <param name="_object"></param>
        /// <returns></returns>
        Task CreateAsync(T _object);

        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="_object"></param>
        bool Update(T _object);


        /// <summary>
        /// Remove by Id
        /// </summary>
        /// <param name="_object"></param>
        void Remove(T _object);

        IQueryable<T> Table();
    }
}
