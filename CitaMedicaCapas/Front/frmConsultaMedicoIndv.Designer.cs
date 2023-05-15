namespace ClinicaM.Front
{
    partial class frmConsultaMedicoIndv
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
            this.cmbClaves = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.lblSubespecialidad = new System.Windows.Forms.Label();
            this.txtSubespecialidad = new System.Windows.Forms.TextBox();
            this.txtConsultorio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbClaves
            // 
            this.cmbClaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaves.FormattingEnabled = true;
            this.cmbClaves.Location = new System.Drawing.Point(106, 40);
            this.cmbClaves.Name = "cmbClaves";
            this.cmbClaves.Size = new System.Drawing.Size(121, 21);
            this.cmbClaves.TabIndex = 0;
            this.cmbClaves.SelectedIndexChanged += new System.EventHandler(this.cmbClaves_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(327, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(44, 43);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(309, 13);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(258, 40);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(175, 20);
            this.txtEspecialidad.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(44, 125);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Location = new System.Drawing.Point(106, 122);
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.ReadOnly = true;
            this.mtxtTelefono.Size = new System.Drawing.Size(134, 20);
            this.mtxtTelefono.TabIndex = 7;
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(291, 125);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(59, 13);
            this.lblConsultorio.TabIndex = 8;
            this.lblConsultorio.Text = "Consultorio";
            // 
            // lblSubespecialidad
            // 
            this.lblSubespecialidad.AutoSize = true;
            this.lblSubespecialidad.Location = new System.Drawing.Point(12, 161);
            this.lblSubespecialidad.Name = "lblSubespecialidad";
            this.lblSubespecialidad.Size = new System.Drawing.Size(85, 13);
            this.lblSubespecialidad.TabIndex = 10;
            this.lblSubespecialidad.Text = "Subespecialidad";
            // 
            // txtSubespecialidad
            // 
            this.txtSubespecialidad.Location = new System.Drawing.Point(106, 158);
            this.txtSubespecialidad.Name = "txtSubespecialidad";
            this.txtSubespecialidad.ReadOnly = true;
            this.txtSubespecialidad.Size = new System.Drawing.Size(327, 20);
            this.txtSubespecialidad.TabIndex = 11;
            // 
            // txtConsultorio
            // 
            this.txtConsultorio.Location = new System.Drawing.Point(356, 122);
            this.txtConsultorio.Name = "txtConsultorio";
            this.txtConsultorio.ReadOnly = true;
            this.txtConsultorio.Size = new System.Drawing.Size(77, 20);
            this.txtConsultorio.TabIndex = 12;
            // 
            // frmConsultaMedicoIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 211);
            this.Controls.Add(this.txtConsultorio);
            this.Controls.Add(this.txtSubespecialidad);
            this.Controls.Add(this.lblSubespecialidad);
            this.Controls.Add(this.lblConsultorio);
            this.Controls.Add(this.mtxtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbClaves);
            this.Name = "frmConsultaMedicoIndv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Medico Individual";
            this.Load += new System.EventHandler(this.frmConsultaMedicoIndv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClaves;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.Label lblSubespecialidad;
        private System.Windows.Forms.TextBox txtSubespecialidad;
        private System.Windows.Forms.TextBox txtConsultorio;
    }
}