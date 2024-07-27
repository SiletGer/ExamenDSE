using System.ComponentModel.DataAnnotations;

namespace ExamenDSE.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 4)]
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Productos> Productos { get; set; }
    }
}
