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
    public class CarritoesController : ControllerBase
    {
        private readonly LibreriaDBContext _context;

        public CarritoesController(LibreriaDBContext context)
        {
            _context = context;
        }

        [HttpGet("listarCarrito")]
        public ActionResult<List<Carrito>> GetCarrito()
        {
            var carritos = _context.Carritos.ToList();
            return Ok(carritos);
        }

        // GET: api/Carritoes
        [HttpGet("TopUp")]
        public async Task<ActionResult<IEnumerable<sp_mayoresTop>>> getTopUp()
        {
            var dato = await _context.sp_mayoresTop.FromSqlRaw<sp_mayoresTop>("execute sp_mayoresTop").ToListAsync();

            return dato;

        }

        // GET: api/Carritoes/5
        [HttpGet("TopDown")]
        public async Task<ActionResult<IEnumerable<sp_menoresTop>>> getTopDown()
        {
            var dato = await _context.sp_menoresTop.FromSqlRaw<sp_menoresTop>("execute sp_menoresTop").ToListAsync();

            return dato;
        }

        private bool CarritoExists(int id)
        {
            return _context.Carritos.Any(e => e.IdCarrito == id);
        }
    }
}
