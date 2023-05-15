namespace GUI_ClinicaMedica
{
    partial class frmConsultaCitasIndv
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
            this.lblClaveCita = new System.Windows.Forms.Label();
            this.lblClaveMedico = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.grbDatosCitas = new System.Windows.Forms.GroupBox();
            this.cmbClaveCita = new System.Windows.Forms.ComboBox();
            this.txtClaveMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.grbDatosCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClaveCita
            // 
            this.lblClaveCita.AutoSize = true;
            this.lblClaveCita.Location = new System.Drawing.Point(20, 27);
            this.lblClaveCita.Name = "lblClaveCita";
            this.lblClaveCita.Size = new System.Drawing.Size(55, 13);
            this.lblClaveCita.TabIndex = 0;
            this.lblClaveCita.Text = "Clave Cita";
            // 
            // lblClaveMedico
            // 
            this.lblClaveMedico.AutoSize = true;
            this.lblClaveMedico.Location = new System.Drawing.Point(20, 65);
            this.lblClaveMedico.Name = "lblClaveMedico";
            this.lblClaveMedico.Size = new System.Drawing.Size(72, 13);
            this.lblClaveMedico.TabIndex = 1;
            this.lblClaveMedico.Text = "Clave Medico";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 147);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(20, 186);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(20, 231);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(106, 13);
            this.lblNombrePaciente.TabIndex = 4;
            this.lblNombrePaciente.Text = "Nombre del Paciente";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(20, 277);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(111, 13);
            this.lblTelefonoPaciente.TabIndex = 5;
            this.lblTelefonoPaciente.Text = "Telefono del Paciente";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 319);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 6;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Location = new System.Drawing.Point(20, 106);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(99, 13);
            this.lblNombreMedico.TabIndex = 7;
            this.lblNombreMedico.Text = "Nombre del Medico";
            // 
            // grbDatosCitas
            // 
            this.grbDatosCitas.Controls.Add(this.txtObservaciones);
            this.grbDatosCitas.Controls.Add(this.txtTelefonoPaciente);
            this.grbDatosCitas.Controls.Add(this.txtNombrePaciente);
            this.grbDatosCitas.Controls.Add(this.txtHora);
            this.grbDatosCitas.Controls.Add(this.txtFecha);
            this.grbDatosCitas.Controls.Add(this.txtNombreMedico);
            this.grbDatosCitas.Controls.Add(this.txtClaveMedico);
            this.grbDatosCitas.Controls.Add(this.cmbClaveCita);
            this.grbDatosCitas.Controls.Add(this.lblClaveCita);
            this.grbDatosCitas.Controls.Add(this.lblNombreMedico);
            this.grbDatosCitas.Controls.Add(this.lblClaveMedico);
            this.grbDatosCitas.Controls.Add(this.lblObservaciones);
            this.grbDatosCitas.Controls.Add(this.lblFecha);
            this.grbDatosCitas.Controls.Add(this.lblTelefonoPaciente);
            this.grbDatosCitas.Controls.Add(this.lblHora);
            this.grbDatosCitas.Controls.Add(this.lblNombrePaciente);
            this.grbDatosCitas.Location = new System.Drawing.Point(31, 27);
            this.grbDatosCitas.Name = "grbDatosCitas";
            this.grbDatosCitas.Size = new System.Drawing.Size(448, 357);
            this.grbDatosCitas.TabIndex = 8;
            this.grbDatosCitas.TabStop = false;
            this.grbDatosCitas.Text = "Datos";
            // 
            // cmbClaveCita
            // 
            this.cmbClaveCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaveCita.FormattingEnabled = true;
            this.cmbClaveCita.Location = new System.Drawing.Point(153, 24);
            this.cmbClaveCita.Name = "cmbClaveCita";
            this.cmbClaveCita.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveCita.TabIndex = 8;
            this.cmbClaveCita.SelectedIndexChanged += new System.EventHandler(this.cmbClaveCita_SelectedIndexChanged);
            // 
            // txtClaveMedico
            // 
            this.txtClaveMedico.Location = new System.Drawing.Point(153, 62);
            this.txtClaveMedico.Name = "txtClaveMedico";
            this.txtClaveMedico.ReadOnly = true;
            this.txtClaveMedico.Size = new System.Drawing.Size(100, 20);
            this.txtClaveMedico.TabIndex = 9;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(153, 103);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(243, 20);
            this.txtNombreMedico.TabIndex = 10;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(153, 144);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 11;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(153, 183);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 12;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(153, 228);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(243, 20);
            this.txtNombrePaciente.TabIndex = 13;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(153, 274);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.ReadOnly = true;
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(142, 20);
            this.txtTelefonoPaciente.TabIndex = 14;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(153, 316);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(243, 20);
            this.txtObservaciones.TabIndex = 15;
            // 
            // frmConsultaCitasIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.grbDatosCitas);
            this.Name = "frmConsultaCitasIndv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Citas Individual";
            this.Load += new System.EventHandler(this.frmConsultaCitasIndv_Load);
            this.grbDatosCitas.ResumeLayout(false);
            this.grbDatosCitas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClaveCita;
        private System.Windows.Forms.Label lblClaveMedico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblTelefonoPaciente;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.GroupBox grbDatosCitas;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtClaveMedico;
        private System.Windows.Forms.ComboBox cmbClaveCita;
    }
}