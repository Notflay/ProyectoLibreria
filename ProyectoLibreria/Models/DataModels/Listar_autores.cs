using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System;

namespace ProyectoLibreria.Models.DataModels
{
    public class Listar_autores
    {
        // GET: Listar_autores
        [Key]
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fech_naciminto { get; set; }
        public DateTime Fech_defuncion { get; set; }
        // LIBROS
    }
}
