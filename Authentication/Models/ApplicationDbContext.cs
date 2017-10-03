using System;
using Authentication.DbModel;
using Microsoft.EntityFrameworkCore;


namespace Authentication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseMySql("Host=localhost;Port=3306;database=LessonAuthentication;user=root;password=maksimus666" );


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .ToTable("Users")
                        .HasKey(key => key.UserName);
        }


    }
}