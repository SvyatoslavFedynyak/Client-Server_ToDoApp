using Models.Entities;
using System.Data.Entity;

namespace DataBaseControl.Context
{
    class AppContext : DbContext
    {
        // FIELDS
        DbSet<Photo> photos;
        DbSet<Subject> subjects;
        DbSet<Comment> comments;
        DbSet<Like> likes;
        DbSet<Message> messages;
        DbSet<User> users;

        // CONSTRUCTORS
        public AppContext()
            : base("AppDbConnection")
        { }

        // PROPERTIES
        DbSet<Photo> Photos
        {
            get
            {
                return photos;
            }
            set
            {
                photos = value;
            }
        }
        DbSet<Subject> Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
            }
        }
        DbSet<Comment> Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
            }
        }
        DbSet<Like> Likes
        {
            get
            {
                return likes;
            }
            set
            {
                likes = value;
            }
        }
        DbSet<Message> Messages
        {
            get
            {
                return messages;
            }
            set
            {
                messages = value;
            }
        }
        DbSet<User> Users
        {
            get
            {
                return users;
            }
            set
            {
                users = value;
            }
        }
    }
}