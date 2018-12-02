using System.Collections.Generic;

namespace Models.Entities
{
    public class User
    {
        // Properties
        public int Id { get; set; }
        public string MainPhoto { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public ICollection<Photo> Album { get; set; }
        public ICollection<User> Followers { get; set; }
        public ICollection<User> Following { get; set; }
        public bool IsAdmin { get; set; }
    }
}
