namespace Models.Entities
{
    public class Comment
    {
        // Properties
        int Id { get; set; }
        User Author { get; set; }
        System.Collections.Generic.ICollection<Like> Likes { get; set; }
        string Text { get; set; }
        System.DateTime Date { get; set; }
    }
}
