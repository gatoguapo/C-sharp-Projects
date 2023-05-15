namespace ClinicaM.Front
{
    partial class frmAgregaMedico
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
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSubespecialidad = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtSubespecialidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.maskTTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbConsultorio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(57, 39);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(42, 133);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblSubespecialidad
            // 
            this.lblSubespecialidad.AutoSize = true;
            this.lblSubespecialidad.Location = new System.Drawing.Point(8, 176);
            this.lblSubespecialidad.Name = "lblSubespecialidad";
            this.lblSubespecialidad.Size = new System.Drawing.Size(85, 13);
            this.lblSubespecialidad.TabIndex = 3;
            this.lblSubespecialidad.Text = "Subespecialidad";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(324, 9);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(282, 136);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(59, 13);
            this.lblConsultorio.TabIndex = 5;
            this.lblConsultorio.Text = "Consultorio";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(120, 36);
            this.txtClave.MaxLength = 5;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 1;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // txtSubespecialidad
            // 
            this.txtSubespecialidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubespecialidad.Location = new System.Drawing.Point(120, 175);
            this.txtSubespecialidad.MaxLength = 20;
            this.txtSubespecialidad.Name = "txtSubespecialidad";
            this.txtSubespecialidad.Size = new System.Drawing.Size(297, 20);
            this.txtSubespecialidad.TabIndex = 6;
            this.txtSubespecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubespecialidad_KeyPress);
            this.txtSubespecialidad.Validated += new System.EventHandler(this.txtSubespecialidad_Validated);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(120, 79);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // maskTTelefono
            // 
            this.maskTTelefono.Location = new System.Drawing.Point(120, 133);
            this.maskTTelefono.Mask = "000-000-0000";
            this.maskTTelefono.Name = "maskTTelefono";
            this.maskTTelefono.Size = new System.Drawing.Size(75, 20);
            this.maskTTelefono.TabIndex = 8;
            this.maskTTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskTTelefono_KeyPress);
            this.maskTTelefono.Validated += new System.EventHandler(this.maskTTelefono_Validated);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Neumologia",
            "Pediatra",
            "Oncologia",
            "Psiquiatria",
            "Dermatologia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(296, 36);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(120, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 37);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(222, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 37);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(326, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 37);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // cmbConsultorio
            // 
            this.cmbConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorio.FormattingEnabled = true;
            this.cmbConsultorio.Location = new System.Drawing.Point(349, 130);
            this.cmbConsultorio.Name = "cmbConsultorio";
            this.cmbConsultorio.Size = new System.Drawing.Size(68, 21);
            this.cmbConsultorio.TabIndex = 14;
            // 
            // frmAgregaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 273);
            this.Controls.Add(this.cmbConsultorio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.maskTTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSubespecialidad);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblConsultorio);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblSubespecialidad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.Name = "frmAgregaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Medicos";
            this.Load += new System.EventHandler(this.frmAgregaMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSubespecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtSubespecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox maskTTelefono;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.ComboBox cmbConsultorio;
    }
}