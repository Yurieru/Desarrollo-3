using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoFin.Helper;
using AutoFin.Repository;
using AutoFin.Model;

namespace AutoFin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuarioRepository uRepo = new UsuarioRepository();
            ResponseHelper rh = uRepo.Listar(false);
            if (!rh.Response)
            {
                Console.WriteLine("Error: " + rh.Message);
            }
            else
            {
                foreach(Usuario obj in rh.Result)
                {
                    Console.WriteLine("Id: {0} Nombre: {1}"
                        ,obj.UsuarioId, obj.Nombre);
                }
            }
        }
    }
}
