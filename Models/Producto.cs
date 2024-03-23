using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del Producto")]
        [Required]
        public string? Nombre { get; set; }

        [Display(Name = "Descripcion del Producto")]
        [Required]
        public string? Descripcion { get; set; }


        [Display(Name = "Ingrese el precio del Producto")]
        [Required]
        public double? Precio { get; set; }

    }
}