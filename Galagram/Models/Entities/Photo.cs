using System.Collections.Generic;

namespace Models.Entities
{
    /// <summary>
    /// Represents class that models Photo
    /// </summary>
    public class Photo
    {
        // FIELDS
        private int id;
        private string path;
        private User author;
        private ICollection<Like> likes;
        private ICollection<Comment> comments;
        // PROPERTIES
        /// <summary>
        /// Property that defines the id
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        /// <summary>
        /// Property that defines the path
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        /// <summary>
        /// Property that defines the author
        /// </summary>
        public User Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        /// <summary>
        /// Property that defines the likes
        /// </summary>
        public ICollection<Like> Likes
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
        /// Property that defines the comments
        /// </summary>
        public ICollection<Comment> Comments
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
        // CONSTRUCTORS
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Photo() { }
    }
}
