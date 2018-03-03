using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Validation;
using AutoFin.Tools;

namespace AutoFin.Helper
{
    public class EntityValidationExceptionHelper
    {
        public static void ProcesarErrores(object obj, DbEntityValidationException ex)
        {
            foreach (var eve in ex.EntityValidationErrors)
            {
                string str = "Entity oftype " + eve.Entry.Entity.GetType()
                    + " in state " + eve.Entry.State
                    + " has the following validation error:";
                Log.save(obj, str);
                foreach (var e in eve.ValidationErrors)
                {
                    str = "      -property" + e.PropertyName + " Error: " +
                        e.ErrorMessage;
                    Log.save(obj, str);
                }
            }
        }
    }
}
