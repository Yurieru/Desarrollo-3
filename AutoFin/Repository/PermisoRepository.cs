using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoFin.Model;
using AutoFin.Helper;
using AutoFin.Tools;

using System.Data.Entity.Validation;

namespace AutoFin.Repository
{
    class PermisoRepository
    {
        public ResponseHelper Listar(bool estado)
        {
            ResponseHelper rh = new ResponseHelper();
            try
            {
                using (var base_de_datos = new DataModel())
                {

                    rh.Result = base_de_datos.Permisos.Include("PermisosNegados")
                        .ToList();
                }
                rh.SetResponse(true);
            }
            catch (DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }

        public ResponseHelper Guardar(Permiso model)
        {
            ResponseHelper rh = new ResponseHelper();

            try
            {
                using (var ctx = new DataModel())
                {
                    if (model.PermisoId > 0)
                    {
                        ctx.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(model).State = System.Data.Entity.EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }

        public ResponseHelper ObtenerById(int Id)
        {
            ResponseHelper rh = new ResponseHelper();

            try
            {
                using (var ctx = new DataModel())
                {
                    rh.Result = ctx.Permisos.Where(r => r.PermisoId == Id)
                        .FirstOrDefault();
                }
                rh.SetResponse(true);
            }
            catch (DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }
    }
}
