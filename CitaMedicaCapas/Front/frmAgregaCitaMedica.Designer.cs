namespace ClinicaM.Front
{
    partial class frmAgregaCitaMedica
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
            this.components = new System.ComponentModel.Container();
            this.lblClaveMedico = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.cmbClaveMedico = new System.Windows.Forms.ComboBox();
            this.mtxtFechaCita = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveMedico
            // 
            this.lblClaveMedico.AutoSize = true;
            this.lblClaveMedico.Location = new System.Drawing.Point(25, 22);
            this.lblClaveMedico.Name = "lblClaveMedico";
            this.lblClaveMedico.Size = new System.Drawing.Size(89, 13);
            this.lblClaveMedico.TabIndex = 0;
            this.lblClaveMedico.Text = "Clave del Medico";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(175, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de la cita";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(277, 22);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(76, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora de la cita";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(25, 79);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(106, 13);
            this.lblNombrePaciente.TabIndex = 3;
            this.lblNombrePaciente.Text = "Nombre del Paciente";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(25, 137);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(111, 13);
            this.lblTelefonoPaciente.TabIndex = 4;
            this.lblTelefonoPaciente.Text = "Telefono del Paciente";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(25, 196);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 5;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(28, 162);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Validated += new System.EventHandler(this.txtTelefono_Validated);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Location = new System.Drawing.Point(28, 222);
            this.txtObservaciones.MaxLength = 50;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(325, 20);
            this.txtObservaciones.TabIndex = 7;
            this.txtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservaciones_KeyPress);
            this.txtObservaciones.Validated += new System.EventHandler(this.txtObservaciones_Validated);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePaciente.Location = new System.Drawing.Point(28, 104);
            this.txtNombrePaciente.MaxLength = 30;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(325, 20);
            this.txtNombrePaciente.TabIndex = 2;
            this.txtNombrePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePaciente_KeyPress);
            this.txtNombrePaciente.Validated += new System.EventHandler(this.txtNombrePaciente_Validated);
            // 
            // cmbClaveMedico
            // 
            this.cmbClaveMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaveMedico.FormattingEnabled = true;
            this.cmbClaveMedico.Location = new System.Drawing.Point(28, 49);
            this.cmbClaveMedico.Name = "cmbClaveMedico";
            this.cmbClaveMedico.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveMedico.TabIndex = 1;
            // 
            // mtxtFechaCita
            // 
            this.mtxtFechaCita.Location = new System.Drawing.Point(178, 49);
            this.mtxtFechaCita.Mask = "0000-00-00";
            this.mtxtFechaCita.Name = "mtxtFechaCita";
            this.mtxtFechaCita.Size = new System.Drawing.Size(73, 20);
            this.mtxtFechaCita.TabIndex = 10;
            this.mtxtFechaCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtFechaCita_KeyPress);
            this.mtxtFechaCita.Validated += new System.EventHandler(this.mtxtFechaCita_Validated);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(28, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 50);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(256, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 50);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(142, 261);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 50);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "00:00-:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00"});
            this.cmbHora.Location = new System.Drawing.Point(270, 49);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(83, 21);
            this.cmbHora.TabIndex = 15;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(223, 146);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(102, 50);
            this.btnReporte.TabIndex = 16;
            this.btnReporte.Text = "Genera Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmAgregaCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 327);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mtxtFechaCita);
            this.Controls.Add(this.cmbClaveMedico);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblTelefonoPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblClaveMedico);
            this.Name = "frmAgregaCitaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Cita Medica";
            this.Load += new System.EventHandler(this.frmAgregaCitaMedica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveMedico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblTelefonoPaciente;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.ComboBox cmbClaveMedico;
        private System.Windows.Forms.MaskedTextBox mtxtFechaCita;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Button btnReporte;
    }
}