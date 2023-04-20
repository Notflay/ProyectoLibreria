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
    public class CategoriasController : ControllerBase
    {
        private readonly LibreriaDBContext _context;

        public CategoriasController(LibreriaDBContext context)
        {
            _context = context;
        }
        // GET: api/Categorias
        [HttpGet("listaCategorias")]
        public ActionResult<List<Categoria>> GetClientes()
        {
            var categorias = _context.Categorias.ToList();
            return Ok(categorias);
        }
        // GET: api/Categorias
        [HttpGet("letra")]
        public async Task<ActionResult<IEnumerable<sp_letraCategoria>>> getLetraCategoria(string letra)
        {
            var dato = await _context.sp_letraCategoria.FromSqlRaw<sp_letraCategoria>("execute sp_letraCategoria {0}", letra).ToListAsync();

            return dato;
        }

        [HttpGet("edad")]
        public async Task<ActionResult<IEnumerable<sp_searchEdad>>> getEdad(string edad)
        {
            var dato = await _context.sp_searchEdad.FromSqlRaw<sp_searchEdad>("execute sp_searchEdad {0}", edad).ToListAsync();

            return dato;
        }

        // GET: api/Categorias/5
        [HttpGet("notedad")]
        public async Task<ActionResult<IEnumerable<sp_searchNotEdad>>> getNotEdad(string notedad)
        {
            var dato = await _context.sp_searchNotEdad.FromSqlRaw<sp_searchNotEdad>("execute sp_searchNotEdad {0}", notedad).ToListAsync();

            return dato;
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categorias.Any(e => e.IdCategoria == id);
        }
    }
}
