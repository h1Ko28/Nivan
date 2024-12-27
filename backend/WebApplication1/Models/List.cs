namespace WebApplication1.Models
{
    public class List
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public DateTime CreateAt { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public List<Card> Cards { get; set; }
    }
}
