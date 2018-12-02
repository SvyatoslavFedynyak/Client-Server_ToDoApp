using System;
using DataBaseControl.Interfaces;
using Models.Entities;

namespace DataBaseControl.Services
{
    /// <summary>
    /// Represents class which will work with entities repository and gives away context for it
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        // FIELDS
        GenericRepository<Comment> commentRepository;
        GenericRepository<Like> likeRepository;
        GenericRepository<User> userRepository;
        GenericRepository<Subject> subjectRepository;
        GenericRepository<Photo> photoRepository;
        GenericRepository<Message> messageRepository;
        Context.AppContext db;
        private bool disposedValue;

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor with parameter
        /// </summary>
        /// <param name="connectionStringName">The name of connection string.</param>
        public UnitOfWork(string connectionStringName)
        {
            db = new Context.AppContext(connectionStringName);
            commentRepository = new GenericRepository<Comment>(db);
            likeRepository = new GenericRepository<Like>(db);
            userRepository = new GenericRepository<User>(db);
            subjectRepository = new GenericRepository<Subject>(db);
            photoRepository = new GenericRepository<Photo>(db);
            messageRepository = new GenericRepository<Message>(db);
            disposedValue = false;
        }

        // DESTRUCTORS
        ~UnitOfWork()
        {
            Dispose(false);
        }

        // PROPERTIES   
        /// <summary>
        /// Property that enable to interact with comment repository
        /// </summary>
        /// <returns>Comment Repository</returns>
        public IGenericRepository<Comment> CommentRepository
        {
            get
            {
                return commentRepository;
            }
        }
        /// <summary>
        /// Property that enable to interact with like repository
        /// </summary>
        /// <returns>Like Repository</returns>
        public IGenericRepository<Like> LikeRepository
        {
            get
            {
                return likeRepository;
            }
        }
        /// <summary>
        /// Property that enable to interact with message repository
        /// </summary>
        /// <returns>Message Repository</returns>
        public IGenericRepository<Message> MessageRepository
        {
            get
            {
                return messageRepository;
            }
        }
        /// <summary>
        /// Property that enable to interact with photo repository
        /// </summary>
        /// <returns>Photo Repository</returns>
        public IGenericRepository<Photo> PhotoRepository
        {
            get
            {
                return photoRepository;
            }
        }
        /// <summary>
        /// Property that enable to interact with subject repository
        /// </summary>
        /// <returns>Subject Repository</returns>
        public IGenericRepository<Subject> SubjectRepository
        {
            get
            {
                return subjectRepository;
            }
        }
        /// <summary>
        /// Property that enable to interact with user repository
        /// </summary>
        /// <returns>User Repository</returns>
        public IGenericRepository<User> UserRepository
        {
            get
            {
                return userRepository;
            }
        }

        // METHODS
        /// <summary>
        /// Save changes in data base
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }
        /// <summary>
        /// Special disposer
        /// </summary>
        /// <param name="disposing">Dispose managed resourses</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                    db = null;
                }
                disposedValue = true;
            }
        }
        /// <summary>
        /// Dispose resourses
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
