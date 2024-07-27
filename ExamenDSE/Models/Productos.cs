using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDSE.Models
{
    public class Productos
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 4)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Precio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        [Column(TypeName = "int")]
        public int? Stock { get; set; }

        [Required]
        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        public Categoria categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
