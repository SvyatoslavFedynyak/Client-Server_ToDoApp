using System.Collections.Generic;

namespace Models.Entities
{
    public class User
    {
        // Properties
        int Id { get; set; }
        string MainPhoto { get; set; }
        string NickName { get; set; }
        string Password { get; set; }
        ICollection<Photo> Album { get; set; }
        ICollection<User> Followers { get; set; }
        ICollection<User> Following { get; set; }
        bool IsAdmin { get; set; }
    }
}
