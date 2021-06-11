using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPersonal.Models
{
    public class Categoriaas
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
    }
}
