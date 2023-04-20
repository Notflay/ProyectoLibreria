using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class Editorial
    {
        [Key]
        public int IdEditorial { get; set; }
        public string NomAutores { get; set; }
        public string Tematicas { get; set; }
        public string Continente { get; set; }
        public string Catalogo { get; set; }
    }
}
