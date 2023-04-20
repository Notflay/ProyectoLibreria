using System.ComponentModel.DataAnnotations;

namespace LibreriaAPI.Models
{
    public class LISTAR_PAISES
    {
        [Key]
        public int PaisId { get; set; }
        public string NomPais { get; set; }
        public string CodIso { get; set; }
        public string Continente { get; set; }
        public string Idioma { get; set; }
        public string Moneda { get; set; }
        public string HusoHorario { get; set; }
    }
}
