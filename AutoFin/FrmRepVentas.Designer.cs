namespace AutoFin
{
    partial class FrmRepVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatePiker = new System.Windows.Forms.DateTimePicker();
            this.dgbVenta = new System.Windows.Forms.DataGridView();
            this.checkDescuento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // DatePiker
            // 
            this.DatePiker.Location = new System.Drawing.Point(53, 8);
            this.DatePiker.Name = "DatePiker";
            this.DatePiker.Size = new System.Drawing.Size(200, 20);
            this.DatePiker.TabIndex = 2;
            // 
            // dgbVenta
            // 
            this.dgbVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbVenta.Location = new System.Drawing.Point(10, 34);
            this.dgbVenta.Name = "dgbVenta";
            this.dgbVenta.Size = new System.Drawing.Size(383, 223);
            this.dgbVenta.TabIndex = 3;
            this.dgbVenta.DataSourceChanged += new System.EventHandler(this.dgbVenta_DataSourceChanged);
            // 
            // checkDescuento
            // 
            this.checkDescuento.AutoSize = true;
            this.checkDescuento.Checked = true;
            this.checkDescuento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDescuento.Location = new System.Drawing.Point(313, 263);
            this.checkDescuento.Name = "checkDescuento";
            this.checkDescuento.Size = new System.Drawing.Size(78, 17);
            this.checkDescuento.TabIndex = 23;
            this.checkDescuento.Text = "Descuento";
            this.checkDescuento.UseVisualStyleBackColor = true;
            // 
            // FrmRepVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 292);
            this.Controls.Add(this.checkDescuento);
            this.Controls.Add(this.dgbVenta);
            this.Controls.Add(this.DatePiker);
            this.Controls.Add(this.label1);
            this.Name = "FrmRepVentas";
            this.Text = "FrmRepVentas";
            this.Load += new System.EventHandler(this.FrmRepVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePiker;
        private System.Windows.Forms.DataGridView dgbVenta;
        private System.Windows.Forms.CheckBox checkDescuento;
    }
}