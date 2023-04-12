using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class Lenguaje
    {
        [Key]
        public int IdLenguaje { get; set; }
        public string TipLeng { get; set; }
        public string FamLeng { get; set; }
        public string RegIdi { get; set; }
        public string NivFluIdi { get; set; }
        public string EstadIdi { get; set; }

    }
}
