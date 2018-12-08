using System.Collections.Generic;

namespace Models.Entities
{
    /// <summary>
    /// Represents class that models User
    /// </summary>
    public class User
    {
        // FIELDS
        private int id;
        private string mainPhoto;
        private string nickName;
        private string password;
        private ICollection<Photo> album;
        private ICollection<User> followers;
        private ICollection<User> following;
        private bool isAdmin;
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
        /// Property that defines the main photo
        /// </summary>
        public string MainPhoto
        {
            get
            {
                return mainPhoto;
            }
            set
            {
                mainPhoto = value;
            }
        }
        /// <summary>
        /// Property that defines the nickname
        /// </summary>
        public string NickName
        {
            get
            {
                return nickName;
            }
            set
            {
                nickName = value;
            }
        }
        /// <summary>
        /// Property that defines the password
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        /// <summary>
        /// Property that defines the album
        /// </summary>
        public ICollection<Photo> Album
        {
            get
            {
                return album;
            }
            set
            {
                album = value;
            }
        }
        /// <summary>
        /// Property that defines the followers
        /// </summary>
        public ICollection<User> Followers
        {
            get
            {
                return followers;
            }
            set
            {
                followers = value;
            }
        }
        /// <summary>
        /// Property that defines the following
        /// </summary>
        public ICollection<User> Following
        {
            get
            {
                return following;
            }
            set
            {
                following = value;
            }
        }
        /// <summary>
        /// Property that defines the is admin
        /// </summary>
        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public User() { }
    }
}
