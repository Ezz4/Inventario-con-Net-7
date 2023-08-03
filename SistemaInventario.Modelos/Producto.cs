using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numero de serie es requrido")]
        [MaxLength(60)]
        public string? NumeroSerie { get; set; }

        [Required(ErrorMessage = "Descripcion es requerido")]
        [MaxLength(60)]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El costo es requerido")]
        public double Costo { get; set; }

        public string? ImagenURL { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "Categoria es requerida")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="El precio es requerido")]
        public int Precio { get; set; }

        
        public Categoria? Categoria { get; set; }

        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca? Marca { get; set; }

        public int? PadreId { get; set; }

        public virtual Producto? Padre { get; set; }
    }
}