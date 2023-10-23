using APICodeCraft.Models;
using Microsoft.EntityFrameworkCore;

namespace APICodeCraft.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet <Subtopic> Subtopics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Subtopic>().HasOne(s => s.Course).WithMany().HasForeignKey(s => s.CourseId);

            modelBuilder.Entity<Quiz>().HasOne(q => q.Subtopic).WithMany().HasForeignKey(q => q.SubtopicId);

            modelBuilder.Entity<Content>().HasOne(c => c.Subtopic).WithMany().HasForeignKey(c => c.SubtopicId);

        }

    }
}
