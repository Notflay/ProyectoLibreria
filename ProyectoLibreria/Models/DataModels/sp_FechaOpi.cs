using System.ComponentModel.DataAnnotations;

namespace ProyectoLibreria.Models.DataModels
{
    public class sp_FechaOpi
    {
        [Key]
        public int IdOpinion { get; set; }
        public string TipoOpi { get; set; }
        public string Comentario { get; set; }
        public string Calificación { get; set; }
        public string FechaOpi { get; set; }

        public string Producto { get; set; }
    }
}
