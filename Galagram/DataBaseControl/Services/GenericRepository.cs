using System;
using System.Collections.Generic;
using DataBaseControl.Interfaces;

namespace DataBaseControl.Services
{
    class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        int IGenericRepository<TEntity>.Count()
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<TEntity>.Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<TEntity>.Delete(object id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.Get()
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<TEntity>.Insert(TEntity obj)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<TEntity>.Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
