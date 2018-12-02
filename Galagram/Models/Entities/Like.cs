namespace Models.Entities
{
    public abstract class Like
    {
        // Properties
        public int Id { get; set; }
        public User User { get; set; }
        public bool IsLiked { get; set; }
    }
    public class PhotoLike : Like
    {
        // Properties
        public Photo Photo { get; set; }
    }
    public class CommentLike: Like
    {
        // Properties
        public Comment Comment { get; set; }
    }
}
