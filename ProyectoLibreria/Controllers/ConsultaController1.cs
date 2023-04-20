using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoLibreria.DataAccess;
using ProyectoLibreria.Models.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoLibreria.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class ConsultaController1 : Controller
    {
       
        private readonly LibreriaDBContext _context;
        // GET: ConsultaController1
        public ConsultaController1( LibreriaDBContext context)
        {
            _context = context;
        }

        //GET  API/
        [HttpGet("TopUp")]
        public async Task<ActionResult<IEnumerable<sp_buscar_clientes_por_nombre>>> getTopUp( string nombre)
        {
            var dato = await _context.sp_buscar_clientes_por_nombre.
                FromSqlRaw<sp_buscar_clientes_por_nombre>("execute sp_buscar_clientes_por_nombre {0} ", nombre).
                ToListAsync();

            return dato;

        }

        // GET: Consulta registro/Details/5
        [HttpGet("registros")]
        public async Task<ActionResult<IEnumerable<sp_obtener_registros>>> getregistros()
        {
            var consul = await _context.sp_obtener_registros.
                FromSqlRaw<sp_obtener_registros>("execute sp_obtener_registros").
                ToListAsync();

            return consul;

        }
        
    }
}
