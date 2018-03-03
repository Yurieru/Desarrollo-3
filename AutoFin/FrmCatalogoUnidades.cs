using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoFin.Repository;

namespace AutoFin
{
    public partial class FrmCatalogoUnidades : Form
    {
        private AutoRepository cLista;
        /// <summary>
        /// 
        /// </summary>!this.checkstatus.Checked
        public void MostrarDatos()
        {
            this.DgbCatalogoUnidades.DataSource = this.cLista.Listar(!this.checkvendidos.Checked).Result;
        }
        public FrmCatalogoUnidades()
        {
            InitializeComponent();
            this.cLista = new AutoRepository();
            //DgbCatalogoUnidades.AutoGenerateColumns = false;
            //prueba numero 1
        }

        private void DgbCatalogoUnidades_DataSourceChanged(object sender, EventArgs e)
        {
            lblcantidad.Text = "Total de Registros: " + (this.DgbCatalogoUnidades.Rows.Count).ToString();
        }

        private void FrmCatalogoUnidades_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            DgbCatalogoUnidades.AutoGenerateColumns = false;
        }
    }
}
