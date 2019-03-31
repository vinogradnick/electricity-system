using Microsoft.EntityFrameworkCore;

namespace ElectricityManagerWebCore.Models
{
    public class AppContext:DbContext
    {
        public DbSet<Fider> Fiders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=32768;Database=usersdb;Username=postgres;");
        }
    }
}