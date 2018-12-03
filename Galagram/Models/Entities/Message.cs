namespace Models.Entities
{
    /// <summary>
    /// Represents class that models Message
    /// </summary>
    public class Message
    {
        // FIELDS
        private int id;
        private string text;
        private User user;
        private Subject subject;
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
        /// Property that defines the subject
        /// </summary>
        public Subject Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
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
        public Message() { }
    }
}
