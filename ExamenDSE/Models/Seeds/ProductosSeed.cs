using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenDSE.Models.Seeds
{
    public class ProductosSeed: IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder) 
        {
            builder.HasData(
                new Productos
                {
                    Id = 1,
                    Nombre = "Smartphone",
                    Precio = 299.99M,
                    Stock = 50,
                    CategoriaId = 1,
                    Descripcion = "Smartphone Samsung S24 Ultra"
                },
                new Productos
                {
                    Id = 2,
                    Nombre = "Camisa",
                    Precio = 19.99M,
                    Stock = 200,
                    CategoriaId = 2,
                    Descripcion = "Camiseta Nike"
                },
                new Productos
                {
                    Id = 3,
                    Nombre = "Pan",
                    Precio = 1.99M,
                    Stock = 100,
                    CategoriaId = 3,
                    Descripcion = "Pan Bimbo"
                },
                new Productos
                {
                    Id = 4,
                    Nombre = "Laptop",
                    Precio = 799.99M,
                    Stock = 30,
                    CategoriaId = 1,
                    Descripcion = "Laptop Dell"
                },
                new Productos
                {
                    Id = 5,
                    Nombre = "Zapatos",
                    Precio = 49.99M,
                    Stock = 150,
                    CategoriaId = 2,
                    Descripcion = "Zapatos Adidas"
                });
        }
    }
}
