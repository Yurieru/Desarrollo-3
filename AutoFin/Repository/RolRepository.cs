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
    class RolRepository
    {

        public ResponseHelper Listar(bool estado)
        {
            ResponseHelper rh = new ResponseHelper();
            try
            {
                using (var base_de_datos = new DataModel())
                {

                    rh.Result = base_de_datos.Roles.Include("Usuarios")
                        .Include("PermisosNegados")
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

        public ResponseHelper Guardar(Rol model)
        {
            ResponseHelper rh = new ResponseHelper();

            try
            {
                using (var ctx = new DataModel())
                {
                    if (model.RolId > 0)
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
                    rh.Result = ctx.Roles.Where(r => r.RolId == Id)
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
