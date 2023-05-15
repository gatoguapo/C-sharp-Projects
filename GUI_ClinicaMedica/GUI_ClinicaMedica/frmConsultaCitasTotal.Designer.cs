namespace GUI_ClinicaMedica
{
    partial class frmConsultaCitasTotal
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
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.claveCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveCita,
            this.claveMedico,
            this.nombreMedico,
            this.fecha,
            this.hora,
            this.nombrePaciente,
            this.telefonoPaciente,
            this.observaciones});
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(0, 0);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(1124, 450);
            this.dgvCitas.TabIndex = 0;
            // 
            // claveCita
            // 
            this.claveCita.HeaderText = "Clave Cita";
            this.claveCita.Name = "claveCita";
            // 
            // claveMedico
            // 
            this.claveMedico.HeaderText = "Clave Medico";
            this.claveMedico.Name = "claveMedico";
            // 
            // nombreMedico
            // 
            this.nombreMedico.HeaderText = "Medico";
            this.nombreMedico.Name = "nombreMedico";
            this.nombreMedico.Width = 200;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 120;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.Width = 60;
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.HeaderText = "Nombre Paciente";
            this.nombrePaciente.Name = "nombrePaciente";
            this.nombrePaciente.Width = 200;
            // 
            // telefonoPaciente
            // 
            this.telefonoPaciente.HeaderText = "Telefono Paciente";
            this.telefonoPaciente.Name = "telefonoPaciente";
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.Width = 200;
            // 
            // frmConsultaCitasTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.dgvCitas);
            this.Name = "frmConsultaCitasTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Citas Total";
            this.Load += new System.EventHandler(this.frmConsultaCitasTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
    }
}