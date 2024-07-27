using ExamenDSE.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace ExamenDSE.Models
{
    public class ProductosDBContext : DbContext
    {
        public ProductosDBContext(DbContextOptions<ProductosDBContext> options) : base(options)
        {
        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .Property(p => p.Precio)
                .HasColumnType("decimal(18,2)");

            modelBuilder.ApplyConfiguration(new CategoriaSeed());
            modelBuilder.ApplyConfiguration(new ProductosSeed());
        }
    }
}
