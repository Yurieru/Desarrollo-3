using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{

    [Table(name:"Permisos")]
    public class Permiso
    {
        [Key]
        public int PermisoId { get; set; }
        [Required(ErrorMessage = "Se requiere un nombre")]
        public string Nombre { get; set; }

        public ICollection<PermisoNegado> PermisosNegados { get; set; }
    }
}
