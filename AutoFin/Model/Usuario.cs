using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{
    [Table(name: "Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Se requiere el correo electronico")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Se requiere el password")]
        public string Password { get; set; }
        public bool EsBorrado { get; set; }
        [Required(ErrorMessage = "Se requiere un ingrese el nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requiere los apellidos")]
        public string Apellidos { get; set; }


        //RELACIONES
        public Rol Rol { get; set; }
        public ICollection<Venta> Ventas { get; set; }



        public Usuario() {
            this.EsBorrado = false;
        }
    }
}
