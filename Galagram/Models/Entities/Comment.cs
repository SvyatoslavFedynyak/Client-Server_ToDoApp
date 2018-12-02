namespace Models.Entities
{
    public class Comment
    {
        // Properties
        public int Id { get; set; }
        public User Author { get; set; }
        public System.Collections.Generic.ICollection<Like> Likes { get; set; }
        public string Text { get; set; }
        public System.DateTime Date { get; set; }
    }
}
