using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class filtrar_nacionalidad
    {
        [Key]
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fech_naciminto { get; set; }
        public DateTime Fech_defuncion { get; set; }
        // LIBROS

    }
}
