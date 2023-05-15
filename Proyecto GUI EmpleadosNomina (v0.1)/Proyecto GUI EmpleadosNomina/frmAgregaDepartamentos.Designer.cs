namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmAgregaDepartamentos
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
            this.lblJefeNombre = new System.Windows.Forms.Label();
            this.txtClaveDep = new System.Windows.Forms.TextBox();
            this.txtNombreDep = new System.Windows.Forms.TextBox();
            this.txtNombreJefe = new System.Windows.Forms.TextBox();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbBaja = new System.Windows.Forms.RadioButton();
            this.grbEstatus = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbEstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(25, 31);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(104, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave Departamento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(15, 88);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Departamento";
            // 
            // lblJefeNombre
            // 
            this.lblJefeNombre.AutoSize = true;
            this.lblJefeNombre.BackColor = System.Drawing.Color.White;
            this.lblJefeNombre.Location = new System.Drawing.Point(45, 141);
            this.lblJefeNombre.Name = "lblJefeNombre";
            this.lblJefeNombre.Size = new System.Drawing.Size(84, 13);
            this.lblJefeNombre.TabIndex = 2;
            this.lblJefeNombre.Text = "Nombre del Jefe";
            // 
            // txtClaveDep
            // 
            this.txtClaveDep.Location = new System.Drawing.Point(135, 28);
            this.txtClaveDep.MaxLength = 3;
            this.txtClaveDep.Name = "txtClaveDep";
            this.txtClaveDep.Size = new System.Drawing.Size(100, 20);
            this.txtClaveDep.TabIndex = 4;
            this.txtClaveDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveDep_KeyPress);
            this.txtClaveDep.Validated += new System.EventHandler(this.txtClaveDep_Validated);
            // 
            // txtNombreDep
            // 
            this.txtNombreDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDep.Location = new System.Drawing.Point(135, 85);
            this.txtNombreDep.MaxLength = 30;
            this.txtNombreDep.Name = "txtNombreDep";
            this.txtNombreDep.Size = new System.Drawing.Size(268, 20);
            this.txtNombreDep.TabIndex = 5;
            this.txtNombreDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDep_KeyPress);
            this.txtNombreDep.Validated += new System.EventHandler(this.txtNombreDep_Validated);
            // 
            // txtNombreJefe
            // 
            this.txtNombreJefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreJefe.Location = new System.Drawing.Point(135, 138);
            this.txtNombreJefe.MaxLength = 35;
            this.txtNombreJefe.Name = "txtNombreJefe";
            this.txtNombreJefe.Size = new System.Drawing.Size(268, 20);
            this.txtNombreJefe.TabIndex = 6;
            this.txtNombreJefe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreJefe_KeyPress);
            this.txtNombreJefe.Validated += new System.EventHandler(this.txtNombreJefe_Validated);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(6, 19);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 7;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Location = new System.Drawing.Point(93, 19);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(46, 17);
            this.rbBaja.TabIndex = 8;
            this.rbBaja.Text = "Baja";
            this.rbBaja.UseVisualStyleBackColor = true;
            // 
            // grbEstatus
            // 
            this.grbEstatus.BackColor = System.Drawing.Color.White;
            this.grbEstatus.Controls.Add(this.rbBaja);
            this.grbEstatus.Controls.Add(this.rbActivo);
            this.grbEstatus.Location = new System.Drawing.Point(262, 12);
            this.grbEstatus.Name = "grbEstatus";
            this.grbEstatus.Size = new System.Drawing.Size(141, 46);
            this.grbEstatus.TabIndex = 9;
            this.grbEstatus.TabStop = false;
            this.grbEstatus.Text = "Estatus";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 42);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(169, 182);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(298, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 42);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregaDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbEstatus);
            this.Controls.Add(this.txtNombreJefe);
            this.Controls.Add(this.txtNombreDep);
            this.Controls.Add(this.txtClaveDep);
            this.Controls.Add(this.lblJefeNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAgregaDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Departamentos";
            this.Load += new System.EventHandler(this.AgregaDepartamentos_Load);
            this.grbEstatus.ResumeLayout(false);
            this.grbEstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblJefeNombre;
        private System.Windows.Forms.TextBox txtClaveDep;
        private System.Windows.Forms.TextBox txtNombreDep;
        private System.Windows.Forms.TextBox txtNombreJefe;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbBaja;
        private System.Windows.Forms.GroupBox grbEstatus;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}