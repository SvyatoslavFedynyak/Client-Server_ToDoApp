using System;
using Models.Entities;

namespace DataBaseControl.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        // PROPERTIES
        IGenericRepository<Subject> SubjectRepository { get; }
        IGenericRepository<Photo> PhotoRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Like> LikeRepository { get; }
        IGenericRepository<Comment> CommentRepository { get; }
        IGenericRepository<Message> MessageRepository { get; }

        // METHODS
        void Save();
    }
}
