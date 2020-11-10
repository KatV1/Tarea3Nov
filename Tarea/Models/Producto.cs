using System.ComponentModel.DataAnnotations;


namespace Tarea.Models
{
    public class Producto
    {
        [Required(ErrorMessage = "Por favor, ingrese nombre")]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese un precio")]
        [Display(Name="Precio")]
        //no sé, podría ser decimal o float
        public double Precio { get; set; }

        [Display(Name="Descripción")]
        public string Descripcion { get; set; }
        // prueba Staging Area

    }
}