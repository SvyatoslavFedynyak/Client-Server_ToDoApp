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
        /// Constructor with parameters
        /// </summary>
        /// <param name="id">Id photo</param>
        /// <param name="path">Path to the photo</param>
        /// <param name="author">The author of the photo</param>
        /// <param name="likes">Amount of likes in the photo</param>
        /// <param name="comments">Amount of comments in the photo</param>
        public Photo(int id, string path, User author, ICollection<Like> likes, ICollection<Comment> comments)
        {
            this.id = id;
            this.path = path;
            this.author = author;
            this.likes = likes;
            this.comments = comments;
        }
    }
}
