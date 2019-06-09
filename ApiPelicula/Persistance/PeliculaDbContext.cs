using ApiPelicula.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPelicula.Persistance
{
    public class PeliculaDbContext: DbContext
    {
        public PeliculaDbContext(DbContextOptions opciones): base(opciones)
        {

        }

        public virtual DbSet<Pelicula> Pelicula { get; set; }

        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Pelicula.Map(modelB.Entity<Pelicula>());
            base.OnModelCreating(modelB);
        }
    }
}
