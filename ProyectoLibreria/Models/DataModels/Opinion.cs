﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLibreria.Models.DataModels
{
    public class Opinion
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
