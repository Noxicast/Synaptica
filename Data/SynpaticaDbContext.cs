using Microsoft.EntityFrameworkCore;
using Synaptica.Shared.Models;

namespace Synaptica.Data
{
    public class SynpaticaDbContext : DbContext
    {
        public SynpaticaDbContext(DbContextOptions<SynpaticaDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
        
        public DbSet<Notification> Notifications { get; set; }
        
        public DbSet<Quiz> Quizzes { get; set; }
        
        public DbSet<QuizQuestion> QuizQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Optional: Add custom configurations here, such as composite keys or default values.
        }
    }
}

