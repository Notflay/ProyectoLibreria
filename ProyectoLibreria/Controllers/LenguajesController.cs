using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoLibreria.DataAccess;
using ProyectoLibreria.Models.DataModels;

namespace ProyectoLibreria.Controllers
{
    public class LenguajesController : Controller
    {
        private readonly LibreriaDBContext _context;

        public LenguajesController(LibreriaDBContext context)
        {
            _context = context;
        }
        [HttpGet("listaLenguajes")]
        public ActionResult<List<Categoria>> GetClientes()
        {
            var lenguajes = _context.Lenguajes.ToList();
            return Ok(lenguajes);
        }

        [HttpGet("nivel")]
        public async Task<ActionResult<IEnumerable<sp_nivelFlui>>> sp_nivelFlui(string nivel)
        {
            var dato = await _context.sp_nivelFlui.FromSqlRaw<sp_nivelFlui>("execute sp_nivelFlui {0}", nivel).ToListAsync();

            return dato;
        }

        [HttpGet("estado")]
        public async Task<ActionResult<IEnumerable<sp_estadoIdioma>>> sp_estadoIdioma(string estado)
        {
            var dato = await _context.sp_estadoIdioma.FromSqlRaw<sp_estadoIdioma>("execute sp_estadoIdioma {0}", estado).ToListAsync();

            return dato;
        }

        private bool LenguajeExists(int id)
        {
            return _context.Lenguajes.Any(e => e.IdLenguaje == id);
        }
    }
}
