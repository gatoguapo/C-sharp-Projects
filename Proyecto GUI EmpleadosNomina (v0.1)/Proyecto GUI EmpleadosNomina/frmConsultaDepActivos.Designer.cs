namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaDepActivos
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
            this.drgDepartamentos = new System.Windows.Forms.DataGridView();
            this.claveDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jefeNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drgDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // drgDepartamentos
            // 
            this.drgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDep,
            this.jefeNombre,
            this.nombreDep});
            this.drgDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgDepartamentos.Location = new System.Drawing.Point(0, 0);
            this.drgDepartamentos.Name = "drgDepartamentos";
            this.drgDepartamentos.Size = new System.Drawing.Size(743, 435);
            this.drgDepartamentos.TabIndex = 0;
            // 
            // claveDep
            // 
            this.claveDep.HeaderText = "Clave";
            this.claveDep.Name = "claveDep";
            // 
            // jefeNombre
            // 
            this.jefeNombre.HeaderText = "Jefe";
            this.jefeNombre.Name = "jefeNombre";
            this.jefeNombre.Width = 300;
            // 
            // nombreDep
            // 
            this.nombreDep.HeaderText = "Nombre Departamento";
            this.nombreDep.Name = "nombreDep";
            this.nombreDep.Width = 300;
            // 
            // frmConsultaDepActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 435);
            this.Controls.Add(this.drgDepartamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaDepActivos";
            this.Text = "Departamentos Activos";
            this.Load += new System.EventHandler(this.frmConsultaDepActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drgDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drgDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn jefeNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDep;
    }
}