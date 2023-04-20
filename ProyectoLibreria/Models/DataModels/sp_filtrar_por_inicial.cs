using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class sp_filtrar_por_inicial
    {
        [Key]
        public int IdEditorial { get; set; }
        public string NomAutores { get; set; }
        public string Tematicas { get; set; }
        public string Continente { get; set; }
        public string Catalogo { get; set; }
    }
}
