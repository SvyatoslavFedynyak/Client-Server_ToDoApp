using System.Collections.Generic;

namespace Models.Entities
{
    public class Photo
    {
        // Properties
        int Id { get; set; }
        string Path { get; set; }
        User Author { get; set; }
        ICollection<Like> Likes { get; set; }
        ICollection<Comment> Comments { get; set; }
    }
}
