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
    public class OpinionsController : Controller
    {
        private readonly LibreriaDBContext _context;

        public OpinionsController(LibreriaDBContext context)
        {
            _context = context;
        }

        [HttpGet("tipoopi")]
        public async Task<ActionResult<IEnumerable<sp_tipoOpi>>> sp_tipoOpi(string tipoopi)
        {
            var dato = await _context.sp_tipoOpi.FromSqlRaw<sp_tipoOpi>("execute sp_tipoOpi {0}", tipoopi).ToListAsync();

            return dato;
        }

        [HttpGet("fecha")]
        public async Task<ActionResult<IEnumerable<sp_FechaOpi>>> sp_FechaOpi(string fecha)
        {
            var dato = await _context.sp_FechaOpi.FromSqlRaw<sp_FechaOpi>("execute sp_FechaOpi {0}", fecha).ToListAsync();

            return dato;
        }

        private bool OpinionExists(int id)
        {
            return _context.Opiniones.Any(e => e.IdOpinion == id);
        }
    }
}
