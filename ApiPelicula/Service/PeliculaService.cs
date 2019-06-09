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

        public bool Agregar(Pelicula PeliculaAgregar)
        {
            try
            {
                _PeliculaDB.Pelicula.Add(PeliculaAgregar);
                _PeliculaDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;

            }

        }
        public bool Editar(Pelicula PeliculaEditar)
        {
            try
            {
                var noticia = _PeliculaDB.Pelicula.FirstOrDefault(x => x.PeliculaId == PeliculaEditar.PeliculaId);
                noticia.Titulo = PeliculaEditar.Titulo;
                noticia.Sipnosis = PeliculaEditar.Sipnosis;
                noticia.Categoria = PeliculaEditar.Categoria;
                noticia.Anio = PeliculaEditar.Anio;
                _PeliculaDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Eliminar(int PeliculaId)
        {
            try
            {
                var PeliculaEliminar = _PeliculaDB.Pelicula.FirstOrDefault(x => x.PeliculaId == PeliculaId);
                _PeliculaDB.Pelicula.Remove(PeliculaEliminar);
                _PeliculaDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }
    }
}
