using LibreriaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ProyectoLibreria.DataAccess;

namespace LibreriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly LibreriaDBContext db;

        public ClienteController(LibreriaDBContext _db)
        {
            db = _db;
        }

        [HttpGet("listarClientes")]
        public List<LISTAR_CLIENTES> listarClientes()
        {
            var listado = db.LISTAR_CLIENTES
                .FromSqlRaw<LISTAR_CLIENTES>(
                "LISTAR_CLIENTES")
                .ToList();

            return listado;
        }
    }
}
