namespace Models.Entities
{
    /// <summary>
    /// Represents class that models Subject
    /// </summary>
    public class Subject
    {
        // FIELDS
        private int id;
        private string name;
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
        /// Property that defines the name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="id">Id subject</param>
        /// <param name="name">Name subject</param>
        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
