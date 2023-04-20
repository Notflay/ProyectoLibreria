using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class filtrar_publicacion
    {
        [Key]
        public int IdLibro { get; set; }
        // id de la tabla Inventario al que pertenece este Producto

        // id de la tabla Inventario al que pertenece este Producto

        // id de la tabla Inventario al que pertenece este Producto

        public string Descripcion { get; set; }
        public string Anio_publi { get; set; }
        public string Num_paginas { get; set; }
        public string Precio { get; set; }
    }
}
