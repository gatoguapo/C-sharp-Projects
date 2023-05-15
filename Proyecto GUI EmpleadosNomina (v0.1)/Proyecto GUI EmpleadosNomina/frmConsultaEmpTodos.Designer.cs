namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaEmpTodos
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.claveEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveEmp,
            this.nombresEmp,
            this.apellidosEmp,
            this.domicilioEmp,
            this.sexoEmp,
            this.edadEmp,
            this.claveDep,
            this.sueldoEmp});
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1063, 461);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // claveEmp
            // 
            this.claveEmp.HeaderText = "Clave Emp";
            this.claveEmp.Name = "claveEmp";
            this.claveEmp.Width = 70;
            // 
            // nombresEmp
            // 
            this.nombresEmp.HeaderText = "Nombres";
            this.nombresEmp.Name = "nombresEmp";
            this.nombresEmp.Width = 200;
            // 
            // apellidosEmp
            // 
            this.apellidosEmp.HeaderText = "Apellidos";
            this.apellidosEmp.Name = "apellidosEmp";
            this.apellidosEmp.Width = 200;
            // 
            // domicilioEmp
            // 
            this.domicilioEmp.HeaderText = "Domicilio";
            this.domicilioEmp.Name = "domicilioEmp";
            this.domicilioEmp.Width = 200;
            // 
            // sexoEmp
            // 
            this.sexoEmp.HeaderText = "Sexo";
            this.sexoEmp.Name = "sexoEmp";
            // 
            // edadEmp
            // 
            this.edadEmp.HeaderText = "Edad";
            this.edadEmp.Name = "edadEmp";
            this.edadEmp.Width = 70;
            // 
            // claveDep
            // 
            this.claveDep.HeaderText = "Clave Departamento";
            this.claveDep.Name = "claveDep";
            this.claveDep.Width = 80;
            // 
            // sueldoEmp
            // 
            this.sueldoEmp.HeaderText = "Sueldo Diario";
            this.sueldoEmp.Name = "sueldoEmp";
            // 
            // frmConsultaEmpTodos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1063, 461);
            this.Controls.Add(this.dgvEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaEmpTodos";
            this.Text = "Consulta Total de Empleados";
            this.Load += new System.EventHandler(this.frmConsultaEmpTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
    }
}