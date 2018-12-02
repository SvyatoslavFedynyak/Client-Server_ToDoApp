using System;
using Models.Entities;

namespace DataBaseControl.Interfaces
{
    /// <summary>
    /// Represents interface for classes which will work with entities repository and gives away context for it
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        // PROPERTIES
        /// <summary>
        /// Property that enable to interact with subject repository
        /// </summary>
        /// <returns>Subject Repository</returns>
        IGenericRepository<Subject> SubjectRepository { get; }
        /// <summary>
        /// Property that enable to interact with photo repository
        /// </summary>
        /// <returns>Photo Repository</returns>
        IGenericRepository<Photo> PhotoRepository { get; }
        /// <summary>
        /// Property that enable to interact with user repository
        /// </summary>
        /// <returns>User Repository</returns>
        IGenericRepository<User> UserRepository { get; }
        /// <summary>
        /// Property that enable to interact with like repository
        /// </summary>
        /// <returns>Like Repository</returns>
        IGenericRepository<Like> LikeRepository { get; }
        /// <summary>
        /// Property that enable to interact with comment repository
        /// </summary>
        /// <returns>Comment Repository</returns>
        IGenericRepository<Comment> CommentRepository { get; }
        /// <summary>
        /// Property that enable to interact with message repository
        /// </summary>
        /// <returns>Message Repository</returns>
        IGenericRepository<Message> MessageRepository { get; }

        // METHODS
        /// <summary>
        /// Save changes in data base
        /// </summary>
        void Save();
    }
}
