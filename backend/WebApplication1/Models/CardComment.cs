namespace WebApplication1.Models
{
    public class CardComment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
