using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AutoFin.Model
{

    [Table(name:"Autos")]
    public class Auto
    {
        [Key]
        public int AutoId { get; set; }
        [Required(ErrorMessage = "Se requiere numero de serie")]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage = "Se requiere el modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Se requiere el año")]
        public string Anio { get; set; }
        [Required(ErrorMessage = "Se requiere la marca")]
        public string Marca { get; set; }
        public string Placa { get; set; }
        [Required(ErrorMessage = "Se requiere la descripcion")]
        public string Descripcion { get; set; }
        public string Fotografia { get; set; }
        public bool esVendido { get; set; }
        public double Precio { get; set; }

        //Relaciones
        public Propietario Propietario { get; set; }
        public virtual Venta Venta { get; set; }
        public ICollection<Promocion> Promociones { get; set; }

        public Auto()
        {
            this.esVendido = false;
            this.Fotografia = "";
            this.Precio = 0;
        }
    }
}
