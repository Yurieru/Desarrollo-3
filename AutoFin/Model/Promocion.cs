using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{

    [Table(name:"Promociones")]
    public class Promocion
    {
        [Key]
        public int PromocionId { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requiere un descuento")]
        public int Descuento { get; set; }
        [Required(ErrorMessage = "Se requiere la fecha de inicio")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "Se requiere la fecha final")]
        public DateTime FechaFinal { get; set; }

        //Relaciones
        public Auto Auto { get; set; }

        public Promocion()
        {
            this.Descuento = 0;
        }
    }
}
