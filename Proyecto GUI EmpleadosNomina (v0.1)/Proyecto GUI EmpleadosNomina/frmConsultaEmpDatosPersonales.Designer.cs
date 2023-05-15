namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaEmpDatosPersonales
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
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cmbApellidos = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(12, 20);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 0;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(12, 57);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(12, 98);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(30, 137);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(256, 137);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // cmbApellidos
            // 
            this.cmbApellidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApellidos.FormattingEnabled = true;
            this.cmbApellidos.Location = new System.Drawing.Point(67, 17);
            this.cmbApellidos.Name = "cmbApellidos";
            this.cmbApellidos.Size = new System.Drawing.Size(304, 21);
            this.cmbApellidos.TabIndex = 5;
            this.cmbApellidos.SelectedIndexChanged += new System.EventHandler(this.cmbApellidos_SelectedIndexChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(67, 57);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(304, 20);
            this.txtNombres.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(67, 95);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(304, 20);
            this.txtDomicilio.TabIndex = 7;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(67, 134);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(129, 20);
            this.txtSexo.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(294, 130);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(77, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(266, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 43);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmConsultaEmpDatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.cmbApellidos);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaEmpDatosPersonales";
            this.Text = "Consulta de Datos Personales";
            this.Load += new System.EventHandler(this.frmConsultaEmpDatosPersonales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox cmbApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnSalir;
    }
}