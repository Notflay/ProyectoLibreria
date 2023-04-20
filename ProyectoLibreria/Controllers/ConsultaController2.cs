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
    public class ConsultaController2 : Controller
    {
        private readonly LibreriaDBContext _context;
        // GET: ConsultaController2
        public ConsultaController2(LibreriaDBContext context)
        {
            _context = context;
        }

        // GET: ConsultaController2/Details/5
        [HttpGet("Inicial")]
        public async Task<ActionResult<IEnumerable<sp_filtrar_por_inicial>>> getInicial(string letra)
        {
            var consul = await _context.sp_filtrar_por_inicial.
             FromSqlRaw<sp_filtrar_por_inicial>("execute sp_filtrar_por_inicial {0} ", letra).
             ToListAsync();

            return consul;

        }
        
        // GET: ConsultaController2/Create
        [HttpGet("Continente")]
        public async Task<ActionResult<IEnumerable<usp_consultareditorial_porpais>>> getContinente(string conti)
        {
            var consul = await _context.usp_consultareditorial_porpais.
             FromSqlRaw<usp_consultareditorial_porpais>("execute usp_consultareditorial_porpais {0}",conti).
             ToListAsync();

            return consul;

        }
 
    }
}
