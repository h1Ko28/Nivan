using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WebApplication1.Enums;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardMember> BoardsMemberships { get; set;}
        public DbSet<CardAssignee> CardAssignees { get; set; }
        public DbSet<CardComment> CardComments { get; set; }
        public DbSet<List> Lists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Primary key & Many 2 Many for Board member
            builder.Entity<BoardMember>()
                .HasKey(bm => new { bm.BoardId, bm.UserId });

            builder.Entity<BoardMember>()
                .HasOne(bm => bm.User)
                .WithMany(b => b.BoardMembers)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(bm => bm.UserId);

            builder.Entity<BoardMember>()
                .HasOne(bm => bm.Board)
                .WithMany(u => u.BoardMembers)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(bm => bm.BoardId);

            //Primary key & Many 2 Many Card assignee for card assignee
            builder.Entity<CardAssignee>()
                 .HasKey(bm => new { bm.CardId, bm.UserId });

            builder.Entity<CardAssignee>()
                .HasOne(ca => ca.User)
                .WithMany(u => u.CardAssignees)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ca => ca.UserId);

            builder.Entity<CardAssignee>()
                .HasOne(ca => ca.Card)
                .WithMany(c => c.CardAssignees)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ca => ca.CardId);

            //Many 2 Many Card Comment
            builder.Entity<CardComment>()
                .HasOne(cc => cc.User)
                .WithMany(u => u.CardComments)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(cc => cc.UserId);

            builder.Entity<CardComment>()
                .HasOne(cc => cc.Card)
                .WithMany(c => c.CardComments)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ca => ca.CardId);

            //List Relationship
            builder.Entity<List>()
                .HasOne(l => l.Board)
                .WithMany(b => b.Lists)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(l => l.BoardId);

            //Card Relationship
            builder.Entity<Card>()
                .HasOne(c => c.List)
                .WithMany(l => l.Cards)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(l => l.ListId);
        }
    }
}
