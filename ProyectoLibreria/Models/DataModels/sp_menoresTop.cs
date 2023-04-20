using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class sp_menoresTop
    {
        [Key]
        public int IdCarrito { get; set; }
        public string Cantidad { get; set; }
        public string PrecioTotal { get; set; }
    }
}
