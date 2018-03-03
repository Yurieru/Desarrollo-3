namespace AutoFin
{
    partial class FrmCatalogoUnidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcantidad = new System.Windows.Forms.Label();
            this.DgbCatalogoUnidades = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkvendidos = new System.Windows.Forms.CheckBox();
            this.AutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietarioid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgbCatalogoUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(12, 289);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(28, 13);
            this.lblcantidad.TabIndex = 18;
            this.lblcantidad.Text = "XXX";
            // 
            // DgbCatalogoUnidades
            // 
            this.DgbCatalogoUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbCatalogoUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutoId,
            this.NumeroSerie,
            this.Modelo,
            this.Anio,
            this.Marca,
            this.Placa,
            this.Descripcion,
            this.Fotografia,
            this.esVendido,
            this.Precio,
            this.Propietarioid});
            this.DgbCatalogoUnidades.Location = new System.Drawing.Point(15, 34);
            this.DgbCatalogoUnidades.Name = "DgbCatalogoUnidades";
            this.DgbCatalogoUnidades.Size = new System.Drawing.Size(652, 246);
            this.DgbCatalogoUnidades.TabIndex = 17;
            this.DgbCatalogoUnidades.DataSourceChanged += new System.EventHandler(this.DgbCatalogoUnidades_DataSourceChanged);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(592, 5);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 16;
            this.btnnuevo.Text = "Nueva";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marca:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Modelo:";
            // 
            // checkvendidos
            // 
            this.checkvendidos.AutoSize = true;
            this.checkvendidos.Checked = true;
            this.checkvendidos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkvendidos.Location = new System.Drawing.Point(587, 288);
            this.checkvendidos.Name = "checkvendidos";
            this.checkvendidos.Size = new System.Drawing.Size(80, 17);
            this.checkvendidos.TabIndex = 22;
            this.checkvendidos.Text = "checkBox1";
            this.checkvendidos.UseVisualStyleBackColor = true;
            // 
            // AutoId
            // 
            this.AutoId.HeaderText = "Clave";
            this.AutoId.Name = "AutoId";
            // 
            // NumeroSerie
            // 
            this.NumeroSerie.HeaderText = "No. Serie";
            this.NumeroSerie.Name = "NumeroSerie";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Fotografia
            // 
            this.Fotografia.HeaderText = "Fotografia";
            this.Fotografia.Name = "Fotografia";
            // 
            // esVendido
            // 
            this.esVendido.HeaderText = "Vendido";
            this.esVendido.Name = "esVendido";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Propietarioid
            // 
            this.Propietarioid.HeaderText = "Propietario";
            this.Propietarioid.Name = "Propietarioid";
            // 
            // FrmCatalogoUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 311);
            this.Controls.Add(this.checkvendidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.DgbCatalogoUnidades);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmCatalogoUnidades";
            this.Text = "FrmCatalogoUnidades";
            this.Load += new System.EventHandler(this.FrmCatalogoUnidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbCatalogoUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.DataGridView DgbCatalogoUnidades;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkvendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn esVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietarioid;
    }
}