using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPelicula.Model
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string titulo { get; set; }
        public string categoria { get; set; }
        public int anio { get; set; }
    }
}
