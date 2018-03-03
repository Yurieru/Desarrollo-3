using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{

    [Table(name:"Roles")]
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre")]
        public string Nombre { get; set; }

        //RELACIONES
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<PermisoNegado> PermisosNegados { get; set; }
    }
}
