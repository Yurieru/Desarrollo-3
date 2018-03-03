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
    class PropietarioRepository
    {

        public ResponseHelper Listar(bool estado)
        {
            ResponseHelper rh = new ResponseHelper();
            try
            {
                using (var base_de_datos = new DataModel())
                {

                    rh.Result = base_de_datos.Propietarios.Include("Autos")
                        .Where(r => r.esBorrado == estado).ToList();
                }
                rh.SetResponse(true);
            }
            catch (DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }

        public ResponseHelper Guardar(Propietario model)
        {
            ResponseHelper rh = new ResponseHelper();

            try
            {
                using (var ctx = new DataModel())
                {
                    if (model.PropetiarioId > 0)
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
                    rh.Result = ctx.Propietarios.Where(r => r.PropetiarioId == Id)
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

        public ResponseHelper Borrar(int Id)
        {
            ResponseHelper rh = this.ObtenerById(Id);
            if (rh.Response)
            {
                Propietario modelo = (Propietario)rh.Result;
                modelo.esBorrado = true;
                rh = this.Guardar(modelo);

            }
            return rh;
        }

    }
}
