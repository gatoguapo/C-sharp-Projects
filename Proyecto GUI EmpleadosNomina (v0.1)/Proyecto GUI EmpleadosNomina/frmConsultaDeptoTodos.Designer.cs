namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaDeptoTodos
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
            this.dgvDepto = new System.Windows.Forms.DataGridView();
            this.claveDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jefeDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepto
            // 
            this.dgvDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDepto,
            this.nombreDepto,
            this.jefeDepto,
            this.estatusDepto});
            this.dgvDepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepto.Location = new System.Drawing.Point(0, 0);
            this.dgvDepto.Name = "dgvDepto";
            this.dgvDepto.Size = new System.Drawing.Size(643, 361);
            this.dgvDepto.TabIndex = 0;
            // 
            // claveDepto
            // 
            this.claveDepto.HeaderText = "Clave";
            this.claveDepto.Name = "claveDepto";
            // 
            // nombreDepto
            // 
            this.nombreDepto.HeaderText = "Departamento";
            this.nombreDepto.Name = "nombreDepto";
            this.nombreDepto.Width = 200;
            // 
            // jefeDepto
            // 
            this.jefeDepto.HeaderText = "Jefe";
            this.jefeDepto.Name = "jefeDepto";
            this.jefeDepto.Width = 200;
            // 
            // estatusDepto
            // 
            this.estatusDepto.HeaderText = "Estatus";
            this.estatusDepto.Name = "estatusDepto";
            // 
            // frmConsultaDeptoTodos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(643, 361);
            this.Controls.Add(this.dgvDepto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaDeptoTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Total de Departamentos";
            this.Load += new System.EventHandler(this.frmConsultaDeptoTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn jefeDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDepto;
    }
}