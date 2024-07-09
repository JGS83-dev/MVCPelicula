﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [StringLength(250)]
        [Required] 
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required]
        public string Director {  get; set; }
        public string Sala { get; set; }

        [Required]
        [ForeignKey("Genero")]
        public int? GeneroId { get; set; }

        public Genero Genero { get; set; }
    }
}
