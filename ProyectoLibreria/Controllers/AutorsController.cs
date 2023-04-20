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
    public class AutorsController : ControllerBase
    {
        private readonly LibreriaDBContext _context;

        public AutorsController(LibreriaDBContext context)
        {
            _context = context;
        }


        [HttpGet("nacionalidad")]
        public async Task<ActionResult<IEnumerable<filtrar_nacionalidad>>> getTopUp(string nacionalidad)
        {
            var dato = await _context.filtrar_nacionalidad.FromSqlRaw<filtrar_nacionalidad>("execute filtrar_nacionalidad {0}", nacionalidad).ToListAsync();

            return dato;

        }

        // GET: api/Listar_autores
        [HttpGet("Listar_autores")]
        public async Task<ActionResult<IEnumerable<Listar_autores>>> getTopUp()
        {
            var dato = await _context.Listar_autores.FromSqlRaw<Listar_autores>("execute Listar_autores").ToListAsync();

            return dato;

        }



        private bool AutorExists(int id)
        {
            return _context.Autores.Any(e => e.IdAutor == id);
        }
    }
}
