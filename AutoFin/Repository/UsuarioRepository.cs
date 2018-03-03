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
    class UsuarioRepository
    {
        public ResponseHelper Listar(bool estado)
        {
            ResponseHelper rh = new ResponseHelper();
            try
            {
                using (var base_de_datos = new DataModel())
                {

                    rh.Result = base_de_datos.Usuarios.Include("Rol")
                        .Include("Ventas")
                        .Where(r => r.EsBorrado == estado).ToList();
                }
                rh.SetResponse(true);
            }
            catch (DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }

        public ResponseHelper Guardar(Usuario model)
        {
            ResponseHelper rh = new ResponseHelper();

            try {
                using(var ctx = new DataModel())
                {
                    if(model.UsuarioId > 0)
                    {
                        ctx.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(model).State = System.Data.Entity.EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            } catch(DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(this, ex);
            }

            return rh;
        }

        public ResponseHelper ObtenerById(int Id)
        {
            ResponseHelper rh = new ResponseHelper();

            try {
                using(var ctx=new DataModel())
                {
                    rh.Result = ctx.Usuarios.Where(r => r.UsuarioId == Id)
                        .FirstOrDefault();
                }
                rh.SetResponse(true);
            } catch(DbEntityValidationException ex)
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
                Usuario modelo = (Usuario)rh.Result;
                modelo.EsBorrado = true;
                rh = this.Guardar(modelo);

            }
            return rh;
        }


        //FUNCIONES EXTRAS
        public static ResponseHelper Autentificar(string email, string password)
        {
            ResponseHelper rh = new ResponseHelper();
            password = ToolsEncript.GetMD5(password);
            try { 
            using(var ctx = new DataModel())
            {
                Usuario usuario = ctx.Usuarios.Where(r => r.Email == email).FirstOrDefault();
                if(usuario != null)
                {
                    if (usuario.Password == password)
                    {
                        rh.SetResponse(true);
                        rh.Result = usuario;
                    }
                    else
                    {
                        rh.SetResponse(false, "Los datos ingresados son incorrectos, favor de intentarlo de nuevo");
                        Log.save(null, "El usuario " +usuario.Email +" intento igresar con clave incorrecta")
;                    }
                }
                else
                {
                    rh.SetResponse(false, "Los datos ingresados son incorrectos, favor de intentarlo de nuevo");
                }
            }
            }
            catch(DbEntityValidationException ex)
            {
                EntityValidationExceptionHelper.ProcesarErrores(null, ex);
            }
            return rh;
        }


    }
}
