using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace DataBaseControl.Interfaces

{
    /// <summary>
    /// Reprents interface for classes which will proxy behind data acsess and buisness logic
    /// </summary>
    /// <typeparam name="TEntity">Data class work with</typeparam>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Method that get data from data base
        /// </summary>
        /// <param name="filter">Filter for data</param>
        /// <param name="orderBy">The order of the received items</param>
        /// <param name="includeProperties">Included properties</param>
        /// <returns>Queried entities collection</returns>
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                                   Func<IQueryable<TEntity>,
                                   IOrderedQueryable<TEntity>> orderBy = null,
                                    string includeProperties = "");
        /// <summary>
        /// Method that enable to get entity by id
        /// </summary>
        /// <param name="id">Entities id</param>
        /// <returns>Finded entity</returns>
        TEntity GetById(int id);
        /// <summary>
        /// Inserts data in data base
        /// </summary>
        /// <param name="obj">Inserted entity</param>
        void Insert(TEntity obj);
        /// <summary>
        /// Deletes object by id
        /// </summary>
        /// <param name="id">Objects id</param>
        void Delete(object id);
        /// <summary>
        /// Deletes preset entity
        /// </summary>
        /// <param name="obj">Entity to delete</param>
        void Delete(TEntity obj);
        /// <summary>
        /// Updates data base
        /// </summary>
        /// <param name="obj">Entity to update</param>
        void Update(TEntity obj);
        /// <summary>
        /// Property that enale to interact with count of entities in data base
        /// </summary>
        /// <returns>Count of entities</returns>
        int Count { get; }

    }
}
