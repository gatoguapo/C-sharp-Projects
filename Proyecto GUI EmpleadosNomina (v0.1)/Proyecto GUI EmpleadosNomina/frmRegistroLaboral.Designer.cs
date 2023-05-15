namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmRegistroLaboral
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
            this.lblDiasLaborados = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.cmbClaves = new System.Windows.Forms.ComboBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveEmp
            // 
            this.lblClaveEmp.AutoSize = true;
            this.lblClaveEmp.BackColor = System.Drawing.Color.White;
            this.lblClaveEmp.Location = new System.Drawing.Point(103, 21);
            this.lblClaveEmp.Name = "lblClaveEmp";
            this.lblClaveEmp.Size = new System.Drawing.Size(84, 13);
            this.lblClaveEmp.TabIndex = 0;
            this.lblClaveEmp.Text = "Clave Empleado";
            // 
            // lblDiasLaborados
            // 
            this.lblDiasLaborados.AutoSize = true;
            this.lblDiasLaborados.BackColor = System.Drawing.Color.White;
            this.lblDiasLaborados.Location = new System.Drawing.Point(106, 59);
            this.lblDiasLaborados.Name = "lblDiasLaborados";
            this.lblDiasLaborados.Size = new System.Drawing.Size(81, 13);
            this.lblDiasLaborados.TabIndex = 1;
            this.lblDiasLaborados.Text = "Dias Laborados";
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.BackColor = System.Drawing.Color.White;
            this.lblHorasExtras.Location = new System.Drawing.Point(120, 94);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(67, 13);
            this.lblHorasExtras.TabIndex = 2;
            this.lblHorasExtras.Text = "Horas Extras";
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.BackColor = System.Drawing.Color.White;
            this.lblFaltas.Location = new System.Drawing.Point(152, 129);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(35, 13);
            this.lblFaltas.TabIndex = 3;
            this.lblFaltas.Text = "Faltas";
            // 
            // cmbClaves
            // 
            this.cmbClaves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaves.FormattingEnabled = true;
            this.cmbClaves.Location = new System.Drawing.Point(193, 18);
            this.cmbClaves.Name = "cmbClaves";
            this.cmbClaves.Size = new System.Drawing.Size(121, 21);
            this.cmbClaves.TabIndex = 4;
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(193, 56);
            this.txtDiasLaborados.MaxLength = 3;
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(100, 20);
            this.txtDiasLaborados.TabIndex = 5;
            this.txtDiasLaborados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasLaborados_KeyPress);
            this.txtDiasLaborados.Validated += new System.EventHandler(this.txtDiasLaborados_Validated);
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Location = new System.Drawing.Point(193, 91);
            this.txtHorasExtras.MaxLength = 2;
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(100, 20);
            this.txtHorasExtras.TabIndex = 6;
            this.txtHorasExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasExtras_KeyPress);
            this.txtHorasExtras.Validating += new System.ComponentModel.CancelEventHandler(this.txtHorasExtras_Validating);
            this.txtHorasExtras.Validated += new System.EventHandler(this.txtHorasExtras_Validated);
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(193, 126);
            this.txtFaltas.MaxLength = 2;
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 20);
            this.txtFaltas.TabIndex = 7;
            this.txtFaltas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFaltas_KeyPress);
            this.txtFaltas.Validated += new System.EventHandler(this.txtFaltas_Validated);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(41, 180);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(174, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 42);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(312, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 42);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmRegistroLaboral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.cmbClaves);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.lblDiasLaborados);
            this.Controls.Add(this.lblClaveEmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegistroLaboral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Laboral 📝";
            this.Load += new System.EventHandler(this.frmRegistroLaboral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveEmp;
        private System.Windows.Forms.Label lblDiasLaborados;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.ComboBox cmbClaves;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}