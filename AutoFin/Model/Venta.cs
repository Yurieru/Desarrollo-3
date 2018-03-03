using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{

    [Table(name:"Ventas")]
    public class Venta
    {
        [Key,ForeignKey("Auto")]
        public int AutoId { get; set; }
        [Required(ErrorMessage = "Se requiere la fecha")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Se requiere el precio")]
        public double Precio { get; set; }
        public double Descuento { get; set; }

        //RELACIONES
        public Usuario Usuario { get; set; }
        public virtual Auto Auto { get; set; }

        public Venta()
        {
            this.Descuento = 0;
        }
    }
}
