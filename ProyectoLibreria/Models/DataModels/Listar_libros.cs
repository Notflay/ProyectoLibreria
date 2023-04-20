using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class Listar_libros
    {
        // GET: Listar_libros
        [Key]
        public int IdLibro { get; set; }
        // id de la tabla Inventario al que pertenece este Producto

        // id de la tabla Inventario al que pertenece este Producto

        // id de la tabla Inventario al que pertenece este Producto
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Anio_publi { get; set; }
        public string Num_paginas { get; set; }
        public string Precio { get; set; }
        public string Imglnk { get; set; }
    }
}
