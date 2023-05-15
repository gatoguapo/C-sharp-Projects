namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmAgregaEmpleados
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
            this.lblClaveEmp = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblClaveDepto = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtClaveEmp = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.cmbClaveDepto = new System.Windows.Forms.ComboBox();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.grbSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveEmp
            // 
            this.lblClaveEmp.AutoSize = true;
            this.lblClaveEmp.BackColor = System.Drawing.Color.White;
            this.lblClaveEmp.Location = new System.Drawing.Point(29, 27);
            this.lblClaveEmp.Name = "lblClaveEmp";
            this.lblClaveEmp.Size = new System.Drawing.Size(84, 13);
            this.lblClaveEmp.TabIndex = 0;
            this.lblClaveEmp.Text = "Clave Empleado";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(64, 67);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(64, 105);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(64, 144);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 3;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(81, 185);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblClaveDepto
            // 
            this.lblClaveDepto.AutoSize = true;
            this.lblClaveDepto.BackColor = System.Drawing.Color.White;
            this.lblClaveDepto.Location = new System.Drawing.Point(228, 27);
            this.lblClaveDepto.Name = "lblClaveDepto";
            this.lblClaveDepto.Size = new System.Drawing.Size(104, 13);
            this.lblClaveDepto.TabIndex = 6;
            this.lblClaveDepto.Text = "Clave Departamento";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.Color.White;
            this.lblSueldo.Location = new System.Drawing.Point(228, 185);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(70, 13);
            this.lblSueldo.TabIndex = 7;
            this.lblSueldo.Text = "Sueldo Diario";
            // 
            // txtClaveEmp
            // 
            this.txtClaveEmp.Location = new System.Drawing.Point(119, 24);
            this.txtClaveEmp.Name = "txtClaveEmp";
            this.txtClaveEmp.ReadOnly = true;
            this.txtClaveEmp.Size = new System.Drawing.Size(100, 20);
            this.txtClaveEmp.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(119, 64);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(285, 20);
            this.txtNombres.TabIndex = 9;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            this.txtNombres.Validated += new System.EventHandler(this.txtNombres_Validated);
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Location = new System.Drawing.Point(119, 102);
            this.txtApellidos.MaxLength = 30;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(285, 20);
            this.txtApellidos.TabIndex = 10;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            this.txtApellidos.Validated += new System.EventHandler(this.txtApellidos_Validated);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(119, 141);
            this.txtDomicilio.MaxLength = 30;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(285, 20);
            this.txtDomicilio.TabIndex = 11;
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            this.txtDomicilio.Validated += new System.EventHandler(this.txtDomicilio_Validated);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(304, 182);
            this.txtSueldo.MaxLength = 7;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 12;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            this.txtSueldo.Validated += new System.EventHandler(this.txtSueldo_Validated);
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(119, 183);
            this.numEdad.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numEdad.Minimum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(41, 20);
            this.numEdad.TabIndex = 13;
            this.numEdad.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(6, 42);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 14;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 15;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cmbClaveDepto
            // 
            this.cmbClaveDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaveDepto.FormattingEnabled = true;
            this.cmbClaveDepto.Location = new System.Drawing.Point(335, 24);
            this.cmbClaveDepto.Name = "cmbClaveDepto";
            this.cmbClaveDepto.Size = new System.Drawing.Size(69, 21);
            this.cmbClaveDepto.TabIndex = 16;
            // 
            // grbSexo
            // 
            this.grbSexo.BackColor = System.Drawing.Color.White;
            this.grbSexo.Controls.Add(this.rbNoBinario);
            this.grbSexo.Controls.Add(this.rbMasculino);
            this.grbSexo.Controls.Add(this.rbFemenino);
            this.grbSexo.Location = new System.Drawing.Point(419, 28);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(86, 94);
            this.grbSexo.TabIndex = 17;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(6, 65);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(74, 17);
            this.rbNoBinario.TabIndex = 18;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(32, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 38);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(288, 225);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 38);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(159, 225);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 38);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(418, 225);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 38);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.cmbClaveDepto);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtClaveEmp);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblClaveDepto);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblClaveEmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAgregaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Empleados";
            this.Load += new System.EventHandler(this.frmAgregaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveEmp;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblClaveDepto;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtClaveEmp;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.ComboBox cmbClaveDepto;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}