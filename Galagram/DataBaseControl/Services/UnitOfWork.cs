using System;
using DataBaseControl.Interfaces;
using Models.Entities;

namespace DataBaseControl.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Comment> CommentRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGenericRepository<Like> LikeRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGenericRepository<Message> MessageRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGenericRepository<Photo> PhotoRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGenericRepository<Subject> SubjectRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UnitOfWork() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        void IDisposable.Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
