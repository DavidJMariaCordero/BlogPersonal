using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPersonal.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Categoria { get; set; }
        public string  Resumen { get; set; }
    }
}
