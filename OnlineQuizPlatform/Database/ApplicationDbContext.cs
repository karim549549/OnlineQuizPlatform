using Microsoft.EntityFrameworkCore;
using OnlineQuizPlatform.Domain;


namespace OnlineQuizPlatform.Database
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }

    }
}
