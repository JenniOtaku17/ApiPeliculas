using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPelicula.Model
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Sipnosis { get; set; }
        public string Categoria { get; set; }
        public int Anio { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Pelicula> ebPelicula)
            {
                ebPelicula.HasKey(x => x.PeliculaId);
                ebPelicula.Property(x => x.Titulo).HasColumnName("Titulo").HasMaxLength(50);
                ebPelicula.Property(x => x.Sipnosis).HasColumnName("Sipnosis").HasMaxLength(500);
                ebPelicula.Property(x => x.Categoria).HasColumnName("Categoria").HasMaxLength(50);
                ebPelicula.Property(x => x.Anio).HasColumnName("Anio").HasColumnType("int");

            }
        }
    }
}
