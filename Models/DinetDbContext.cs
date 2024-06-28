using Microsoft.EntityFrameworkCore;

namespace webApiDinet.Models
{
    public class DinetDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\MSSQLSERVER01;Database=PruebaDinet;Integrated Security=true;Encrypt=false;TrustServerCertificate=True");
            }
        }
    }
}
