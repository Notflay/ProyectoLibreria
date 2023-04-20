using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class sp_obtener_registros
    {
        [Key]
        public int idComprobante { get; set; }
        public string NomCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string ImporteTotal { get; set; }
        public string Direccion { get; set; }
    }
}
