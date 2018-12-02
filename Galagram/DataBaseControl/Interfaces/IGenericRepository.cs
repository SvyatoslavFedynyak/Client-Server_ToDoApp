using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace DataBaseControl.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                                   Func<IQueryable<TEntity>,
                                   IOrderedQueryable<TEntity>> orderBy = null,
string includeProperties = "");
        IEnumerable<TEntity> GetById(int id);
        void Insert(TEntity obj);
        void Delete(object id);
        void Delete(TEntity obj);
        void Update(TEntity obj);
        int Count();

    }
}
