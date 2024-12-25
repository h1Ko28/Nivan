namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }
        public List<BoardMember> BoardMembers { get; set; } = new List<BoardMember>();
        public List<CardAssignee> CardAssignees { get; set; } = new List<CardAssignee>();
        public List<CardComment> CardComments { get; set; } = new List<CardComment> { };
    }
}
