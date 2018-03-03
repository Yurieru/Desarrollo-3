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
    public partial class FrmRepVentas : Form
    {
        private AutoRepository VLista;
        public void MostrarDatos()
        {
            this.dgbVenta.DataSource = this.VLista.Listar(!this.checkDescuento.Checked).Result;
        }
        public FrmRepVentas()
        {
            InitializeComponent();
            this.VLista = new AutoRepository();
        }

        private void dgbVenta_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void FrmRepVentas_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
