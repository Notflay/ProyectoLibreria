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
    public class PaisController : ControllerBase
    {
        private readonly LibreriaDBContext db;

        public PaisController(LibreriaDBContext _db)
        {
            db = _db;
        }

        [HttpGet("listarPaises")]
        public List<LISTAR_PAISES> listarPaises()
        {
            var listado = db.LISTAR_PAISES
                .FromSqlRaw<LISTAR_PAISES>(
                "LISTAR_PAISES")
                .ToList();

            return listado;
        }
    }
}
