using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLibreria.Models.DataModels
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public virtual Pais Pais { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public string NomCliente { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
