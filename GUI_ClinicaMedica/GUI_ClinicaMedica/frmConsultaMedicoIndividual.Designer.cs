namespace GUI_ClinicaMedica
{
    partial class frmConsultaMedicosIndv
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblSubespecialidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtSubespecialidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtConsultorio = new System.Windows.Forms.TextBox();
            this.grbDatosMedicos = new System.Windows.Forms.GroupBox();
            this.grbDatosMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(20, 30);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbClave
            // 
            this.cmbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(120, 27);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(121, 21);
            this.cmbClave.TabIndex = 2;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(268, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 127);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblSubespecialidad
            // 
            this.lblSubespecialidad.AutoSize = true;
            this.lblSubespecialidad.Location = new System.Drawing.Point(20, 179);
            this.lblSubespecialidad.Name = "lblSubespecialidad";
            this.lblSubespecialidad.Size = new System.Drawing.Size(85, 13);
            this.lblSubespecialidad.TabIndex = 5;
            this.lblSubespecialidad.Text = "Subespecialidad";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 229);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(19, 275);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(59, 13);
            this.lblConsultorio.TabIndex = 7;
            this.lblConsultorio.Text = "Consultorio";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(121, 124);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(268, 20);
            this.txtEspecialidad.TabIndex = 8;
            // 
            // txtSubespecialidad
            // 
            this.txtSubespecialidad.Location = new System.Drawing.Point(120, 176);
            this.txtSubespecialidad.Name = "txtSubespecialidad";
            this.txtSubespecialidad.ReadOnly = true;
            this.txtSubespecialidad.Size = new System.Drawing.Size(268, 20);
            this.txtSubespecialidad.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(120, 226);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(268, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtConsultorio
            // 
            this.txtConsultorio.Location = new System.Drawing.Point(120, 272);
            this.txtConsultorio.Name = "txtConsultorio";
            this.txtConsultorio.ReadOnly = true;
            this.txtConsultorio.Size = new System.Drawing.Size(268, 20);
            this.txtConsultorio.TabIndex = 11;
            // 
            // grbDatosMedicos
            // 
            this.grbDatosMedicos.Controls.Add(this.lblClave);
            this.grbDatosMedicos.Controls.Add(this.txtConsultorio);
            this.grbDatosMedicos.Controls.Add(this.lblNombre);
            this.grbDatosMedicos.Controls.Add(this.txtTelefono);
            this.grbDatosMedicos.Controls.Add(this.cmbClave);
            this.grbDatosMedicos.Controls.Add(this.txtSubespecialidad);
            this.grbDatosMedicos.Controls.Add(this.txtNombre);
            this.grbDatosMedicos.Controls.Add(this.txtEspecialidad);
            this.grbDatosMedicos.Controls.Add(this.lblEspecialidad);
            this.grbDatosMedicos.Controls.Add(this.lblConsultorio);
            this.grbDatosMedicos.Controls.Add(this.lblSubespecialidad);
            this.grbDatosMedicos.Controls.Add(this.lblTelefono);
            this.grbDatosMedicos.Location = new System.Drawing.Point(12, 12);
            this.grbDatosMedicos.Name = "grbDatosMedicos";
            this.grbDatosMedicos.Size = new System.Drawing.Size(421, 311);
            this.grbDatosMedicos.TabIndex = 12;
            this.grbDatosMedicos.TabStop = false;
            this.grbDatosMedicos.Text = "Datos Medicos";
            // 
            // frmConsultaMedicosIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 348);
            this.Controls.Add(this.grbDatosMedicos);
            this.Name = "frmConsultaMedicosIndv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Medicos";
            this.Load += new System.EventHandler(this.frmConsultaMedica_Load);
            this.grbDatosMedicos.ResumeLayout(false);
            this.grbDatosMedicos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblSubespecialidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtSubespecialidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtConsultorio;
        private System.Windows.Forms.GroupBox grbDatosMedicos;
    }
}

