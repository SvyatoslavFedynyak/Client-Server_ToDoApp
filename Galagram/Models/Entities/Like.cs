namespace Models.Entities
{
    /// <summary>
    /// Represents an abstract class that models Like
    /// </summary>
    public abstract class Like
    {
        // FIELDS
        private int id;
        private User user;
        private bool isLiked;
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
        /// Property that defines the user
        /// </summary>
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        /// <summary>
        /// Property that defines the is liked
        /// </summary>
        public bool IsLiked
        {
            get
            {
                return isLiked;
            }
            set
            {
                isLiked = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Like() { }         
    }
    /// <summary>
    /// Represents a derived class from Like, which models PhotoLike
    /// </summary>
    public class PhotoLike : Like
    {
        // FIELDS
        private Photo photo;
        // PROPERTIES
        /// <summary>
        /// Property that defines the photo
        /// </summary>
        public Photo Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public PhotoLike() : base() { }
    }
    /// <summary>
    /// Represents a derived class from Like, which models CommentLike
    /// </summary>
    public class CommentLike: Like
    {
        // FIELDS
        private Comment comment;
        // PROPERTIES
        /// <summary>
        /// Property that defines the comment
        /// </summary>
        public Comment Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public CommentLike() : base() { }
    }
}
