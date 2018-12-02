using System;
using System.Collections.Generic;
using DataBaseControl.Interfaces;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;



namespace DataBaseControl.Services
{
    /// <summary>
    /// Reprents class which will proxy behind data acsess and buisness logic
    /// </summary>
    /// <typeparam name="TEntity">Data class work with</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        // FIELDS
        internal Context.AppContext context;
        internal DbSet<TEntity> dbSet;

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor with 1 parameter
        /// </summary>
        /// <param name="context">Data context</param>
        public GenericRepository(Context.AppContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        // PROPERTIES
        /// <summary>
        /// Property that enale to interact with count of entities in data base
        /// </summary>
        /// <returns>Count of entities</returns>
        public int Count => dbSet.Count();

        // METHODS
        /// <summary>
        /// Deletes preset entity
        /// </summary>
        /// <param name="obj">Entity to delete</param>
        public void Delete(TEntity obj)
        {
            if (context.Entry(obj).State == EntityState.Detached)
            {
                dbSet.Attach(obj);
            }
            dbSet.Remove(obj);
        }
        /// <summary>
        /// Deletes object by id
        /// </summary>
        /// <param name="id">Objects id</param>
        public void Delete(object id)
        {
            Delete(dbSet.Find(id));
        }
        /// <summary>
        /// Method that get data from data base
        /// </summary>
        /// <param name="filter">Filter for data</param>
        /// <param name="orderBy">The order of the received items</param>
        /// <param name="includeProperties">Included properties</param>
        /// <returns>Queried entities collection</returns>
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                                   Func<IQueryable<TEntity>,
                                   IOrderedQueryable<TEntity>> orderBy = null,
                                    string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        /// <summary>
        /// Method that enable to get entity by id
        /// </summary>
        /// <param name="id">Entities id</param>
        /// <returns>Finded entity</returns>
        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }
        /// <summary>
        /// Inserts data in data base
        /// </summary>
        /// <param name="obj">Inserted entity</param>
        public void Insert(TEntity obj)
        {
            dbSet.Add(obj);
        }
        /// <summary>
        /// Updates data base
        /// </summary>
        /// <param name="obj">Entity to update</param>
        public void Update(TEntity obj)
        {
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
        }
    }
}
