using Models.Entities;
using System.Data.Entity;

namespace DataBaseControl.Context
{
    public class AppContext : DbContext
    {
        // FIELDS
        DbSet<Photo> photos;
        DbSet<Subject> subjects;
        DbSet<Comment> comments;
        DbSet<Like> likes;
        DbSet<Message> messages;
        DbSet<User> users;

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor with parameter for context class
        /// </summary>
        /// <param name="connectionStringName">The name of connection string.</param>
        public AppContext(string connectionStringName)
            : base(connectionStringName)
        { }

        // PROPERTIES
        /// <summary>
        /// Property that enable to interruct with photos data base set
        /// </summary>
        /// <returns>Photos set</returns>
        public DbSet<Photo> Photos
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
        /// <summary>
        /// Property that enable to interruct with subjects data base set
        /// </summary>
        /// <returns>Subjects set</returns>
        public DbSet<Subject> Subjects
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
        /// <summary>
        /// Property that enable to interruct with comments data base set
        /// </summary>
        /// <returns>Comments set</returns>
        public DbSet<Comment> Comments
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
        /// <summary>
        /// Property that enable to interruct with likes data base set
        /// </summary>
        /// <returns>Likes set</returns>
        public DbSet<Like> Likes
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
        /// <summary>
        /// Property that enable to interruct with messages data base set
        /// </summary>
        /// <returns>Messages set</returns>
        public DbSet<Message> Messages
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
        /// <summary>
        /// Property that enable to interruct with users data base set
        /// </summary>
        /// <returns>Users set</returns>
        public DbSet<User> Users
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