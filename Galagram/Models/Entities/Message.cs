namespace Models.Entities
{
    public class Message
    {
        // Properties
        int Id { get; set; }
        string Text { get; set; }
        User User { get; set; }
        Subject Subject { get; set; }
        System.DateTime Date { get; set; }
    }
}
