using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenDSE.Models.Seeds
{
    public class CategoriaSeed: IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(
                 new Categoria { Id = 1, Nombre = "Electrónica", Descripcion = "---" },
                 new Categoria { Id = 2, Nombre = "Ropa", Descripcion = "---" },
                 new Categoria { Id = 3, Nombre = "Alimentos", Descripcion = "---" });
        }
    }
}
