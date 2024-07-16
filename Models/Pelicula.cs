using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [StringLength(250)]
        [Display(Name ="Título")]
        [Required(ErrorMessage ="El campo título es requerido")] 
        public string Titulo { get; set; }

        [Display(Name = "Fecha de Lanzamiento")]
        [Required(ErrorMessage = "El campo fecha de lanzamiento es requerido")]
        public DateTime FechaLanzamiento { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "El campo director es requerido")]
        public string Director {  get; set; }
        public string Sala { get; set; }

        [Required]
        [ForeignKey("Genero")]
        [Display(Name = "Género")]
        public int? GeneroId { get; set; }

        public Genero Genero { get; set; }
    }
}
