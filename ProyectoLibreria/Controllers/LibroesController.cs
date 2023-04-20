using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoLibreria.DataAccess;
using ProyectoLibreria.Models.DataModels;

namespace ProyectoLibreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroesController : ControllerBase
    {
        private readonly LibreriaDBContext _context;

        public LibroesController(LibreriaDBContext context)
        {
            _context = context;
        }

        [HttpGet("Listar_libros")]
        public async Task<ActionResult<IEnumerable<Listar_libros>>> getLibros()
        {
            var dato = await _context.Listar_libros.FromSqlRaw<Listar_libros>("execute Listar_libros ").ToListAsync();

            return dato;

        }

        // GET: api/Listar_autores
        [HttpGet("filtrar_publicacion")]
        public async Task<ActionResult<IEnumerable<filtrar_publicacion>>> getTopUp(string publi)
        {
            var dato = await _context.filtrar_publicacion.FromSqlRaw<filtrar_publicacion>("execute filtrar_publicacion {0}", publi).ToListAsync();

            return dato;

        }


        private bool LibroExists(int id)
        {
            return _context.Libros.Any(e => e.IdLibro == id);
        }
    }
}
