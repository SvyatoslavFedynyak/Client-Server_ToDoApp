namespace Models.Entities
{
    /// <summary>
    /// Represents class that models Comment
    /// </summary>
    public class Comment
    {
        // FIELDS
        private int id;
        private User author;
        private System.Collections.Generic.ICollection<Like> likes;
        private string text;
        private System.DateTime date;
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
        public System.Collections.Generic.ICollection<Like> Likes
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
        /// Property that defines the text
        /// </summary>
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        /// <summary>
        /// Property that defines the date
        /// </summary>
        public System.DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="id">Id comment</param>
        /// <param name="author">The author who commented</param>
        /// <param name="likes">Amount of likes</param>
        /// <param name="text">Text of the comment</param>
        /// <param name="date">Time to write a comment</param>
        public Comment(int id, User author, System.Collections.Generic.ICollection<Like> likes, string text, System.DateTime date)
        {
            this.id = id;
            this.author = author;
            this.likes = likes;
            this.text = text;
            this.date = date;
        }
    }
}
