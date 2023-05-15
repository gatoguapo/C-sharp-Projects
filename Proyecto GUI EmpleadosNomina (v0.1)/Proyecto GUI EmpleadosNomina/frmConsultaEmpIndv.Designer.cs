namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaEmpIndv
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
            this.cmbClaveEmp = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblClaveDep = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtClaveDep = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbClaveEmp
            // 
            this.cmbClaveEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaveEmp.FormattingEnabled = true;
            this.cmbClaveEmp.Location = new System.Drawing.Point(111, 27);
            this.cmbClaveEmp.Name = "cmbClaveEmp";
            this.cmbClaveEmp.Size = new System.Drawing.Size(90, 21);
            this.cmbClaveEmp.TabIndex = 0;
            this.cmbClaveEmp.SelectedIndexChanged += new System.EventHandler(this.cmbClaveEmp_SelectedIndexChanged);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(47, 30);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(58, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave Emp";
            this.lblClave.Click += new System.EventHandler(this.lblClave_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(56, 68);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombres";
            this.lblNombres.Click += new System.EventHandler(this.lblNombres_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(56, 104);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.Click += new System.EventHandler(this.lblApellidos_Click);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.White;
            this.lblDomicilio.Location = new System.Drawing.Point(56, 139);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.Click += new System.EventHandler(this.lblDomicilio_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(170, 174);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(73, 174);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // lblClaveDep
            // 
            this.lblClaveDep.AutoSize = true;
            this.lblClaveDep.BackColor = System.Drawing.Color.White;
            this.lblClaveDep.Location = new System.Drawing.Point(253, 30);
            this.lblClaveDep.Name = "lblClaveDep";
            this.lblClaveDep.Size = new System.Drawing.Size(57, 13);
            this.lblClaveDep.TabIndex = 7;
            this.lblClaveDep.Text = "Clave Dep";
            this.lblClaveDep.Click += new System.EventHandler(this.lblClaveDep_Click);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.Color.White;
            this.lblSueldo.Location = new System.Drawing.Point(35, 210);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(70, 13);
            this.lblSueldo.TabIndex = 8;
            this.lblSueldo.Text = "Sueldo Diario";
            this.lblSueldo.Click += new System.EventHandler(this.lblSueldo_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(111, 65);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(275, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(111, 101);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(275, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(111, 136);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(275, 20);
            this.txtDomicilio.TabIndex = 11;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(207, 171);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(121, 20);
            this.txtSexo.TabIndex = 12;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(111, 171);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(45, 20);
            this.txtEdad.TabIndex = 13;
            // 
            // txtClaveDep
            // 
            this.txtClaveDep.Location = new System.Drawing.Point(316, 27);
            this.txtClaveDep.Name = "txtClaveDep";
            this.txtClaveDep.ReadOnly = true;
            this.txtClaveDep.Size = new System.Drawing.Size(70, 20);
            this.txtClaveDep.TabIndex = 14;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(111, 207);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(99, 20);
            this.txtSueldo.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(316, 242);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 43);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaEmpIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtClaveDep);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblClaveDep);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbClaveEmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaEmpIndv";
            this.Text = " Consulta Individual de Empleados";
            this.Load += new System.EventHandler(this.frmConsultaEmpIndv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClaveEmp;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblClaveDep;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtClaveDep;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnSalir;
    }
}