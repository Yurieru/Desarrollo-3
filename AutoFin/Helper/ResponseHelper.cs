using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFin.Helper
{
    public class ResponseHelper
    {
        public bool Response { get; set; }
        public string Message { get; set; }
        public string href { get; set; }
        public string function { get; set; }
        public dynamic Result { get; set; }

        public void SetResponse(bool r, string m = "")
        {
            this.Response = r;
            this.Message = m;
            if (!r && m == "") this.Message = "Ocurrio un Error Inesperado.";
        }

        public ResponseHelper()
        {
            this.Result = false;
            this.Message = "Ocurrio un Error Inesperado.";
        }
    }
}
