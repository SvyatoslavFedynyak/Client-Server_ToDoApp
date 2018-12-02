namespace Models.Entities
{
    public class Message
    {
        // Properties
        public int Id { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
        public Subject Subject { get; set; }
        public System.DateTime Date { get; set; }
    }
}
