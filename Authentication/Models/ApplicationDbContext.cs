using Authentication.DbModel;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .ToTable("Users")
                        .HasKey(key => key.UserName);
        }

/*         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseMySQL("server=localhost;database=LessonAuthentication;user=root;password=maksimus666");
        } */
    }
}