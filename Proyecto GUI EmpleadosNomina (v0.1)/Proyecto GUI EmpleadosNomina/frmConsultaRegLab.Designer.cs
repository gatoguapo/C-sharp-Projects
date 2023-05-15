namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaRegLab
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
            this.dgvRegistroLaboral = new System.Windows.Forms.DataGridView();
            this.cveEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasLaborados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroLaboral)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroLaboral
            // 
            this.dgvRegistroLaboral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroLaboral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cveEmp,
            this.diasLaborados,
            this.horasExt,
            this.faltas});
            this.dgvRegistroLaboral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroLaboral.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroLaboral.Name = "dgvRegistroLaboral";
            this.dgvRegistroLaboral.Size = new System.Drawing.Size(443, 311);
            this.dgvRegistroLaboral.TabIndex = 0;
            // 
            // cveEmp
            // 
            this.cveEmp.HeaderText = "Clave Empleado";
            this.cveEmp.Name = "cveEmp";
            // 
            // diasLaborados
            // 
            this.diasLaborados.HeaderText = "Dias Laborados";
            this.diasLaborados.Name = "diasLaborados";
            // 
            // horasExt
            // 
            this.horasExt.HeaderText = "Horas Extra";
            this.horasExt.Name = "horasExt";
            // 
            // faltas
            // 
            this.faltas.HeaderText = "Faltas";
            this.faltas.Name = "faltas";
            // 
            // frmConsultaRegLab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(443, 311);
            this.Controls.Add(this.dgvRegistroLaboral);
            this.Name = "frmConsultaRegLab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Registro Laboral";
            this.Load += new System.EventHandler(this.frmConsultaRegLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroLaboral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn cveEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasLaborados;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasExt;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas;
    }
}