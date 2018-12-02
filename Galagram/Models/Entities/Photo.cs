using System.Collections.Generic;

namespace Models.Entities
{
    public class Photo
    {
        // Properties
        public int Id { get; set; }
        public string Path { get; set; }
        public User Author { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
