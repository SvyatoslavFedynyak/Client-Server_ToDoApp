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
        /// Constructor without parameters
        /// </summary>
        public Comment() { }
    }
}
