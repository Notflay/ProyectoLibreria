using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class Carrito
    {
        [Key]
        public int IdCarrito { get; set; }
        public string Cantidad { get; set; }
        public string PrecioTotal { get; set; }

    }
}
