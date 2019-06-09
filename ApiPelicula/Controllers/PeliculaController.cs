using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPelicula.Model;
using ApiPelicula.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPelicula.Controllers
{
    [Produces("application/json")]
    [Route("api/Pelicula")]
    public class PeliculaController : Controller
    {
        private readonly PeliculaService _PeliculaService;

        public PeliculaController(PeliculaService NoticiaServicio)
        {
            _PeliculaService = NoticiaServicio;
        }

        [Route("VerPeliculas")]
        public IActionResult VerPeliculas()
        {
            var resultado = _PeliculaService.VerListado();
            return Ok(resultado);
        }

        [Route("Agregar")]
        [HttpPost]
        public IActionResult Agregar([FromBody] Pelicula PeliculaAgregar)
        {
            if (_PeliculaService.Agregar(PeliculaAgregar))
            {
                return Ok("Agregado");
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("Editar")]
        [HttpPut]
        public IActionResult Editar([FromBody] Pelicula PeliculaEditar)
        {
            if (_PeliculaService.Editar(PeliculaEditar))
            {
                return Ok("Actualizado");
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("Eliminar/{PeliculaId}")]
        public IActionResult Eliminar(int PeliculaId)
        {
            if (_PeliculaService.Eliminar(PeliculaId))
            {
                return Ok("Borrado");
            }
            else
            {
                return BadRequest();
            }
        }


    }
}