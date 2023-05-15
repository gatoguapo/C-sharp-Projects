namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmConsultaDeptoIndv
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
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.txtNombreJefe = new System.Windows.Forms.TextBox();
            this.txtNombreDep = new System.Windows.Forms.TextBox();
            this.lblJefeNombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.BackColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(272, 48);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(42, 13);
            this.lblEstatus.TabIndex = 13;
            this.lblEstatus.Text = "Estatus";
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(320, 45);
            this.txtEstatus.MaxLength = 3;
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(85, 20);
            this.txtEstatus.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(335, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 38);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbClave
            // 
            this.cmbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(136, 44);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(121, 21);
            this.cmbClave.TabIndex = 23;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // txtNombreJefe
            // 
            this.txtNombreJefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreJefe.Location = new System.Drawing.Point(136, 155);
            this.txtNombreJefe.MaxLength = 35;
            this.txtNombreJefe.Name = "txtNombreJefe";
            this.txtNombreJefe.ReadOnly = true;
            this.txtNombreJefe.Size = new System.Drawing.Size(268, 20);
            this.txtNombreJefe.TabIndex = 29;
            // 
            // txtNombreDep
            // 
            this.txtNombreDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDep.Location = new System.Drawing.Point(136, 102);
            this.txtNombreDep.MaxLength = 30;
            this.txtNombreDep.Name = "txtNombreDep";
            this.txtNombreDep.ReadOnly = true;
            this.txtNombreDep.Size = new System.Drawing.Size(268, 20);
            this.txtNombreDep.TabIndex = 28;
            // 
            // lblJefeNombre
            // 
            this.lblJefeNombre.AutoSize = true;
            this.lblJefeNombre.BackColor = System.Drawing.Color.White;
            this.lblJefeNombre.Location = new System.Drawing.Point(46, 158);
            this.lblJefeNombre.Name = "lblJefeNombre";
            this.lblJefeNombre.Size = new System.Drawing.Size(84, 13);
            this.lblJefeNombre.TabIndex = 26;
            this.lblJefeNombre.Text = "Nombre del Jefe";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(16, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(114, 13);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre Departamento";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(26, 48);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(104, 13);
            this.lblClave.TabIndex = 24;
            this.lblClave.Text = "Clave Departamento";
            // 
            // frmConsultaDeptoIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.txtNombreJefe);
            this.Controls.Add(this.txtNombreDep);
            this.Controls.Add(this.lblJefeNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cmbClave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.lblEstatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultaDeptoIndv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Individual de Departamentos";
            this.Load += new System.EventHandler(this.frmConsultaDeptoIndv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.TextBox txtNombreJefe;
        private System.Windows.Forms.TextBox txtNombreDep;
        private System.Windows.Forms.Label lblJefeNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
    }
}