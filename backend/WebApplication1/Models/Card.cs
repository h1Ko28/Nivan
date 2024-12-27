namespace WebApplication1.Models
{
    public class Card
    {
        public int Id { get; set; }
       
        public string Title { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateAt { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
        public List<CardAssignee> CardAssignees { get; set; } = new List<CardAssignee>();
        public List<CardComment> CardComments { get; set; } = new List<CardComment>();
    }
}
