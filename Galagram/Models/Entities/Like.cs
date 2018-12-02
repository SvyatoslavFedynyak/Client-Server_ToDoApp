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
        /// Constructor with parameters
        /// </summary>
        /// <param name="id">Id like</param>
        /// <param name="user">User who has set the like</param>
        /// <param name="isLiked">Defines or likes</param>
        public Like(int id, User user, bool isLiked)
        {
            this.id = id;
            this.user = user;
            this.isLiked = isLiked;
        }
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
        /// Constructor with parameters
        /// </summary>
        /// <param name="id">Id photo</param>
        /// <param name="user">User who put like in a photo</param>
        /// <param name="isLiked">Defines or likes photo</param>
        /// <param name="photo">photo with like</param>
        public PhotoLike(int id, User user, bool isLiked, Photo photo) : base(id, user, isLiked)
        {
            this.photo = photo;
        }
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
        /// Constructor with parameters
        /// </summary>
        /// <param name="id">Id comment</param>
        /// <param name="user">User who put like in a comment</param>
        /// <param name="isLiked">Defines or likes comment</param>
        /// <param name="comment">Comment with like</param>
        public CommentLike(int id, User user, bool isLiked, Comment comment) : base(id, user, isLiked)
        {
            this.comment = comment;
        }
    }
}
