using Microsoft.EntityFrameworkCore;

namespace ElectricityManagerWebCore.Models
{
    public class AppContext:DbContext
    {
        public DbSet<Fider> Fiders { get; set; }
        public DbSet<Tp> Tps { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Workload> Workloads { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=32768;Database=usersdb;Username=postgres;");
        }
    }
}