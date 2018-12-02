using System;
using System.Collections.Generic;
using DataBaseControl.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace DataBaseControl.Services
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                                   Func<IQueryable<TEntity>,
                                   IOrderedQueryable<TEntity>> orderBy = null,
string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
