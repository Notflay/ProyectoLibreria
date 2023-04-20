using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class usp_consultareditorial_porpais
    {
        [Key]
        public int IdEditorial { get; set; }
        public string NomAutores { get; set; }
        public string Tematicas { get; set; }
        public string Continente { get; set; }
        public string Catalogo { get; set; }



    }
}
