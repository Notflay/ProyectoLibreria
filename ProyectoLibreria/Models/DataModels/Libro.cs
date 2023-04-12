using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLibreria.Models.DataModels
{
    public class Libro
    {
        [Key]
        public int IdLibro { get; set; }
        public virtual Editorial Editorial { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Editorial")]
        public int IdEditorial { get; set; }
        public virtual Autor Autor { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Autor")]
        public int IdAutor { get; set; }
        public virtual Categoria Categoria { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public virtual Lenguaje Lenguaje { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Lenguaje")]
        public int IdLenguaje { get; set; }
        public ICollection<Opinion> Opiniones { get; set; } = new List<Opinion>();
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Anio_publi { get; set; }
        public string Num_paginas { get; set; }
        public string Precio { get; set; }
        public string Imglnk { get; set; }
    }
}
