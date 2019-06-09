using ApiPelicula.Model;
using ApiPelicula.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPelicula.Service
{
    public class PeliculaService
    {
        public readonly PeliculaDbContext _PeliculaDB;
        public PeliculaService(PeliculaDbContext PeliculaDB)
        {
            _PeliculaDB = PeliculaDB;
        }

        public List<Pelicula> VerListado()
        {
            var PeliBuscada = _PeliculaDB.Pelicula.OrderByDescending(x => x.PeliculaId).ToList();
            return PeliBuscada;
        }
    }
}
