using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLibreria.Models.DataModels
{
    public class Comprobante
    {
        [Key]
        public int IdComprobante { get; set; }


        //CARRITO

        public string NomCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string ImporteTotal { get; set; }
        public string Direccion { get; set; }
    }
}
