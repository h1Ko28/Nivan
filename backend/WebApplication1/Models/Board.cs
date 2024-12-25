namespace WebApplication1.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();
        public List<List> Lists { get; set; } = new List<List>();
    }
}
