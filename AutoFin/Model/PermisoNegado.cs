using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoFin.Model
{

    [Table(name:"PermisosNegados")]
    public class PermisoNegado
    {
        [Key]
        public int PermisonegadoId { get; set; }


        //RELACIONES
        public Permiso Permiso { get; set; }
        public Rol Rol { get; set; }
    }
}
