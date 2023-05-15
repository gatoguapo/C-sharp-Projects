namespace ClinicaM.Front
{
    partial class frmConsultaCitaIndv
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
            this.cmbClaveCita = new System.Windows.Forms.ComboBox();
            this.lblClaveCita = new System.Windows.Forms.Label();
            this.lblClaveMedico = new System.Windows.Forms.Label();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.lblNombrePacitente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtClaveMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbClaveCita
            // 
            this.cmbClaveCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaveCita.FormattingEnabled = true;
            this.cmbClaveCita.Location = new System.Drawing.Point(132, 17);
            this.cmbClaveCita.Name = "cmbClaveCita";
            this.cmbClaveCita.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveCita.TabIndex = 0;
            this.cmbClaveCita.SelectedIndexChanged += new System.EventHandler(this.cmbClaveCita_SelectedIndexChanged);
            // 
            // lblClaveCita
            // 
            this.lblClaveCita.AutoSize = true;
            this.lblClaveCita.Location = new System.Drawing.Point(62, 20);
            this.lblClaveCita.Name = "lblClaveCita";
            this.lblClaveCita.Size = new System.Drawing.Size(55, 13);
            this.lblClaveCita.TabIndex = 1;
            this.lblClaveCita.Text = "Clave Cita";
            // 
            // lblClaveMedico
            // 
            this.lblClaveMedico.AutoSize = true;
            this.lblClaveMedico.Location = new System.Drawing.Point(45, 62);
            this.lblClaveMedico.Name = "lblClaveMedico";
            this.lblClaveMedico.Size = new System.Drawing.Size(72, 13);
            this.lblClaveMedico.TabIndex = 2;
            this.lblClaveMedico.Text = "Clave Medico";
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Location = new System.Drawing.Point(18, 106);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(99, 13);
            this.lblNombreMedico.TabIndex = 3;
            this.lblNombreMedico.Text = "Nombre del Medico";
            // 
            // lblNombrePacitente
            // 
            this.lblNombrePacitente.AutoSize = true;
            this.lblNombrePacitente.Location = new System.Drawing.Point(12, 148);
            this.lblNombrePacitente.Name = "lblNombrePacitente";
            this.lblNombrePacitente.Size = new System.Drawing.Size(106, 13);
            this.lblNombrePacitente.TabIndex = 4;
            this.lblNombrePacitente.Text = "Nombre del Paciente";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(7, 194);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(111, 13);
            this.lblTelefonoPaciente.TabIndex = 5;
            this.lblTelefonoPaciente.Text = "Telefono del Paciente";
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Location = new System.Drawing.Point(417, 9);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(84, 13);
            this.lblFechaCita.TabIndex = 6;
            this.lblFechaCita.Text = "Fecha de la Cita";
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Location = new System.Drawing.Point(415, 69);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(77, 13);
            this.lblHoraCita.TabIndex = 7;
            this.lblHoraCita.Text = "Hora de la Cita";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(417, 145);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 8;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtClaveMedico
            // 
            this.txtClaveMedico.Location = new System.Drawing.Point(132, 62);
            this.txtClaveMedico.Name = "txtClaveMedico";
            this.txtClaveMedico.ReadOnly = true;
            this.txtClaveMedico.Size = new System.Drawing.Size(105, 20);
            this.txtClaveMedico.TabIndex = 9;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(132, 103);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(263, 20);
            this.txtNombreMedico.TabIndex = 10;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(132, 145);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(263, 20);
            this.txtNombrePaciente.TabIndex = 11;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(132, 191);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.ReadOnly = true;
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(72, 20);
            this.txtTelefonoPaciente.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(418, 34);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(68, 20);
            this.txtFecha.TabIndex = 13;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(420, 103);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(55, 20);
            this.txtHora.TabIndex = 14;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(420, 172);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(203, 20);
            this.txtObservaciones.TabIndex = 15;
            // 
            // frmConsultaCitaIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 231);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.txtClaveMedico);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblHoraCita);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.lblTelefonoPaciente);
            this.Controls.Add(this.lblNombrePacitente);
            this.Controls.Add(this.lblNombreMedico);
            this.Controls.Add(this.lblClaveMedico);
            this.Controls.Add(this.lblClaveCita);
            this.Controls.Add(this.cmbClaveCita);
            this.Name = "frmConsultaCitaIndv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cita Individual";
            this.Load += new System.EventHandler(this.frmConsultaCitaIndv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClaveCita;
        private System.Windows.Forms.Label lblClaveCita;
        private System.Windows.Forms.Label lblClaveMedico;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.Label lblNombrePacitente;
        private System.Windows.Forms.Label lblTelefonoPaciente;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtClaveMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}