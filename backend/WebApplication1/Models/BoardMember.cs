using WebApplication1.Enums;

namespace WebApplication1.Models
{
    public class BoardMember
    {
        public int BoardId { get; set; }
        public int UserId { get; set; }
        public RoleType Role { get; set; } = RoleType.Member;
        public Board Board { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
