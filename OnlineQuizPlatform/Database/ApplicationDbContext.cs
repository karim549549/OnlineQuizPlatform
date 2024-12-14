using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OnlineQuizPlatform.Domain;


namespace OnlineQuizPlatform.Database
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
              .HasIndex(u => u.Username)
              .IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = "D:/ParallelProcessing/Project/OnlineQuizPlatform/OnlineQuizPlatform/Database/Sqlite/MyDatabase.db";
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }

    }
}
