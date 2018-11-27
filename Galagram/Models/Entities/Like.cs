namespace Models.Entities
{
    public abstract class Like
    {
        // Properties
        int Id { get; set; }
        User User { get; set; }
        bool IsLiked { get; set; }
    }
    public class PhotoLike : Like
    {
        // Properties
        Photo Photo { get; set; }
    }
    public class CommentLike
    {
        // Properties
        Comment Comment { get; set; }
    }
}
