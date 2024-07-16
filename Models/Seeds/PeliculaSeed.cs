using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVCPelicula.Models.Seeds
{
    public class PeliculaSeed : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.HasData(
                new Pelicula { Id = 1, 
                    Titulo = "Matrix recargado" , 
                    FechaLanzamiento = DateTime.Parse("2003-11-13"),
                    GeneroId = 4,
                    Precio = 10.99M,
                    Sala = "1",
                    Director = "Hermanas Wachowski"
                },
                new Pelicula
                {
                    Id = 2,
                    Titulo = "El señor de los anillos las dos torres",
                    FechaLanzamiento = DateTime.Parse("2002-12-18"),
                    GeneroId = 3,
                    Precio = 11.99M,
                    Sala = "1",
                    Director = "Peter Jackson"
                },
                new Pelicula
                {
                    Id = 3,
                    Titulo = "Harry Potter y la cámara secreta",
                    FechaLanzamiento = DateTime.Parse("2002-11-15"),
                    GeneroId = 5,
                    Precio = 9.99M,
                    Sala = "1",
                    Director = "Chris Columbus"
                });
        }
    }
}
