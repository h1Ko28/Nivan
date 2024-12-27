namespace WebApplication1.Models
{
    public class CardAssignee
    {
        public int CardId { get; set; }
        public int UserId { get; set; }
        public Card Card { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
