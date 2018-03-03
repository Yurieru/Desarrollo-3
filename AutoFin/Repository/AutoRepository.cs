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
    class AutoRepository
    {

        public ResponseHelper Listar(bool estado)
        {
            ResponseHelper rh = new ResponseHelper();
            try
            {
                using (var base_de_datos = new DataModel())
                {

                    rh.Result = base_de_datos.Autos.Where(r => r.esVendido==estado).ToList();
                }
                rh.SetResponse(true);
            }
            catch (DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }

        public ResponseHelper Guardar(Auto model)
        {
            ResponseHelper rh = new ResponseHelper();

            try
            {
                using (var ctx = new DataModel())
                {
                    if (model.AutoId > 0)
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
                    rh.Result = ctx.Autos.Where(r => r.AutoId == Id)
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