using Microsoft.EntityFrameworkCore;
using MultiThreading.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.Database
{
    public class ApplicationDbContext
        (DbContextOptions<ApplicationDbContext> options)
        :DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
