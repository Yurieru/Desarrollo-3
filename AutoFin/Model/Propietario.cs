using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{

    [Table(name:"Propietarios")]
    public class Propietario
    {
        [Key]
        public int PropetiarioId { get; set; }
        [Required(ErrorMessage ="Se requiere el nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Se requiere los apellidos")]
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        [Required(ErrorMessage ="Se requiere un correo electronico")]
        public string Email { get; set; }
        public string Fotografia { get; set; }
        public bool esBorrado { get; set; }

        //Relaciones
        public ICollection<Auto> Autos { get; set; }

        public Propietario()
        {
            this.esBorrado = false;
            this.Fotografia = "";
        }

    }
}