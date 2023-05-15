namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaNomina
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
            this.drgNomina = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drgNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // drgNomina
            // 
            this.drgNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.totalBruto,
            this.impuestos,
            this.totalNeto,
            this.fecha});
            this.drgNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgNomina.Location = new System.Drawing.Point(0, 0);
            this.drgNomina.Name = "drgNomina";
            this.drgNomina.Size = new System.Drawing.Size(590, 367);
            this.drgNomina.TabIndex = 0;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave Emp";
            this.clave.Name = "clave";
            // 
            // totalBruto
            // 
            this.totalBruto.HeaderText = "Total Bruto";
            this.totalBruto.Name = "totalBruto";
            // 
            // impuestos
            // 
            this.impuestos.HeaderText = "Impuestos";
            this.impuestos.Name = "impuestos";
            // 
            // totalNeto
            // 
            this.totalNeto.HeaderText = "Total Neto";
            this.totalNeto.Name = "totalNeto";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // frmConsultaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 367);
            this.Controls.Add(this.drgNomina);
            this.Name = "frmConsultaNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Nomina";
            this.Load += new System.EventHandler(this.frmConsultaNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drgNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drgNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}