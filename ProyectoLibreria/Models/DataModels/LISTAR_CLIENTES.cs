using System.ComponentModel.DataAnnotations;

namespace LibreriaAPI.Models
{
    public class LISTAR_CLIENTES
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string Dni { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string NomPais { get; set; }
    }
}
