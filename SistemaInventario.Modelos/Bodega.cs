using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre debe de ser requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe de ser maximo 60 caracteres")]
        public  string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion debe de ser requerido")]
        [MaxLength(100, ErrorMessage = "Descripcion debe de ser maximo 100 caracteres")]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }
    }
}
