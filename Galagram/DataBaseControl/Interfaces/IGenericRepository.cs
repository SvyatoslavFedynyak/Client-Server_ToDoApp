using System.Collections.Generic;

namespace DataBaseControl.Interfaces
{
    interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(/*filter*/);
        IEnumerable<TEntity> GetById(int id);
        void Insert(TEntity obj);
        void Delete(object id);
        void Delete(TEntity obj);
        void Update(TEntity obj);
        int Count();

    }
}
