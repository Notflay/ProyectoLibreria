using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLibreria.Models.DataModels
{
    public class Comprobante
    {
        [Key]
        public int IdComprobante { get; set; }

        public virtual Cliente Cliente { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        //CARRITO
        public virtual Carrito Carrito { get; set; }
        // id de la tabla Inventario al que pertenece este Producto
        [ForeignKey("Carrito")]
        public int IdCarrito { get; set; }

        public string NomCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string ImporteTotal { get; set; }
        public string Direccion { get; set; }
    }
}
