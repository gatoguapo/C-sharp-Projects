
namespace ConE.Front
{
    partial class frmAgregaCargaAcademica
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpCargaAcademica = new System.Windows.Forms.GroupBox();
            this.txtCveMateria5 = new System.Windows.Forms.TextBox();
            this.txtCveMateria4 = new System.Windows.Forms.TextBox();
            this.txtCveMateria3 = new System.Windows.Forms.TextBox();
            this.txtCveMateria2 = new System.Windows.Forms.TextBox();
            this.txtCveMateria1 = new System.Windows.Forms.TextBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cmbCveMateria5 = new System.Windows.Forms.ComboBox();
            this.cmbCveMateria4 = new System.Windows.Forms.ComboBox();
            this.cmbCveMateria3 = new System.Windows.Forms.ComboBox();
            this.cmbCveMateria2 = new System.Windows.Forms.ComboBox();
            this.cmbCveMateria1 = new System.Windows.Forms.ComboBox();
            this.cmbCveEstudiante = new System.Windows.Forms.ComboBox();
            this.lblCveMateria5 = new System.Windows.Forms.Label();
            this.lblCveMateria4 = new System.Windows.Forms.Label();
            this.lblCveMateria3 = new System.Windows.Forms.Label();
            this.lblCveMateria2 = new System.Windows.Forms.Label();
            this.lblCveMateria1 = new System.Windows.Forms.Label();
            this.lblCveEstudiante = new System.Windows.Forms.Label();
            this.grpCargaAcademica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(556, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 60);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(383, 367);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(110, 60);
            this.btnPDF.TabIndex = 8;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(198, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 60);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 367);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 60);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpCargaAcademica
            // 
            this.grpCargaAcademica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpCargaAcademica.Controls.Add(this.txtCveMateria5);
            this.grpCargaAcademica.Controls.Add(this.txtCveMateria4);
            this.grpCargaAcademica.Controls.Add(this.txtCveMateria3);
            this.grpCargaAcademica.Controls.Add(this.txtCveMateria2);
            this.grpCargaAcademica.Controls.Add(this.txtCveMateria1);
            this.grpCargaAcademica.Controls.Add(this.txtAlumno);
            this.grpCargaAcademica.Controls.Add(this.lblAlumno);
            this.grpCargaAcademica.Controls.Add(this.cmbCveMateria5);
            this.grpCargaAcademica.Controls.Add(this.cmbCveMateria4);
            this.grpCargaAcademica.Controls.Add(this.cmbCveMateria3);
            this.grpCargaAcademica.Controls.Add(this.cmbCveMateria2);
            this.grpCargaAcademica.Controls.Add(this.cmbCveMateria1);
            this.grpCargaAcademica.Controls.Add(this.cmbCveEstudiante);
            this.grpCargaAcademica.Controls.Add(this.lblCveMateria5);
            this.grpCargaAcademica.Controls.Add(this.lblCveMateria4);
            this.grpCargaAcademica.Controls.Add(this.lblCveMateria3);
            this.grpCargaAcademica.Controls.Add(this.lblCveMateria2);
            this.grpCargaAcademica.Controls.Add(this.lblCveMateria1);
            this.grpCargaAcademica.Controls.Add(this.lblCveEstudiante);
            this.grpCargaAcademica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCargaAcademica.Location = new System.Drawing.Point(12, 12);
            this.grpCargaAcademica.Name = "grpCargaAcademica";
            this.grpCargaAcademica.Size = new System.Drawing.Size(647, 335);
            this.grpCargaAcademica.TabIndex = 5;
            this.grpCargaAcademica.TabStop = false;
            this.grpCargaAcademica.Text = "Carga Academica";
            // 
            // txtCveMateria5
            // 
            this.txtCveMateria5.Location = new System.Drawing.Point(279, 276);
            this.txtCveMateria5.Name = "txtCveMateria5";
            this.txtCveMateria5.ReadOnly = true;
            this.txtCveMateria5.Size = new System.Drawing.Size(344, 24);
            this.txtCveMateria5.TabIndex = 18;
            // 
            // txtCveMateria4
            // 
            this.txtCveMateria4.Location = new System.Drawing.Point(279, 230);
            this.txtCveMateria4.Name = "txtCveMateria4";
            this.txtCveMateria4.ReadOnly = true;
            this.txtCveMateria4.Size = new System.Drawing.Size(344, 24);
            this.txtCveMateria4.TabIndex = 17;
            // 
            // txtCveMateria3
            // 
            this.txtCveMateria3.Location = new System.Drawing.Point(279, 189);
            this.txtCveMateria3.Name = "txtCveMateria3";
            this.txtCveMateria3.ReadOnly = true;
            this.txtCveMateria3.Size = new System.Drawing.Size(344, 24);
            this.txtCveMateria3.TabIndex = 16;
            // 
            // txtCveMateria2
            // 
            this.txtCveMateria2.Location = new System.Drawing.Point(279, 140);
            this.txtCveMateria2.Name = "txtCveMateria2";
            this.txtCveMateria2.ReadOnly = true;
            this.txtCveMateria2.Size = new System.Drawing.Size(344, 24);
            this.txtCveMateria2.TabIndex = 15;
            // 
            // txtCveMateria1
            // 
            this.txtCveMateria1.Location = new System.Drawing.Point(279, 92);
            this.txtCveMateria1.Name = "txtCveMateria1";
            this.txtCveMateria1.ReadOnly = true;
            this.txtCveMateria1.Size = new System.Drawing.Size(344, 24);
            this.txtCveMateria1.TabIndex = 14;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(340, 42);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(283, 24);
            this.txtAlumno.TabIndex = 13;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(276, 48);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(58, 18);
            this.lblAlumno.TabIndex = 12;
            this.lblAlumno.Text = "Alumno";
            // 
            // cmbCveMateria5
            // 
            this.cmbCveMateria5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveMateria5.FormattingEnabled = true;
            this.cmbCveMateria5.Items.AddRange(new object[] {
            "0"});
            this.cmbCveMateria5.Location = new System.Drawing.Point(132, 274);
            this.cmbCveMateria5.Name = "cmbCveMateria5";
            this.cmbCveMateria5.Size = new System.Drawing.Size(121, 26);
            this.cmbCveMateria5.TabIndex = 11;
            this.cmbCveMateria5.SelectedIndexChanged += new System.EventHandler(this.cmbCveMateria5_SelectedIndexChanged);
            // 
            // cmbCveMateria4
            // 
            this.cmbCveMateria4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveMateria4.FormattingEnabled = true;
            this.cmbCveMateria4.Items.AddRange(new object[] {
            "0"});
            this.cmbCveMateria4.Location = new System.Drawing.Point(132, 228);
            this.cmbCveMateria4.Name = "cmbCveMateria4";
            this.cmbCveMateria4.Size = new System.Drawing.Size(121, 26);
            this.cmbCveMateria4.TabIndex = 10;
            this.cmbCveMateria4.SelectedIndexChanged += new System.EventHandler(this.cmbCveMateria4_SelectedIndexChanged);
            // 
            // cmbCveMateria3
            // 
            this.cmbCveMateria3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveMateria3.FormattingEnabled = true;
            this.cmbCveMateria3.Items.AddRange(new object[] {
            "0"});
            this.cmbCveMateria3.Location = new System.Drawing.Point(132, 181);
            this.cmbCveMateria3.Name = "cmbCveMateria3";
            this.cmbCveMateria3.Size = new System.Drawing.Size(121, 26);
            this.cmbCveMateria3.TabIndex = 9;
            this.cmbCveMateria3.SelectedIndexChanged += new System.EventHandler(this.cmbCveMateria3_SelectedIndexChanged);
            // 
            // cmbCveMateria2
            // 
            this.cmbCveMateria2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveMateria2.FormattingEnabled = true;
            this.cmbCveMateria2.Items.AddRange(new object[] {
            "0"});
            this.cmbCveMateria2.Location = new System.Drawing.Point(132, 135);
            this.cmbCveMateria2.Name = "cmbCveMateria2";
            this.cmbCveMateria2.Size = new System.Drawing.Size(121, 26);
            this.cmbCveMateria2.TabIndex = 8;
            this.cmbCveMateria2.SelectedIndexChanged += new System.EventHandler(this.cmbCveMateria2_SelectedIndexChanged);
            // 
            // cmbCveMateria1
            // 
            this.cmbCveMateria1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveMateria1.FormattingEnabled = true;
            this.cmbCveMateria1.Location = new System.Drawing.Point(132, 90);
            this.cmbCveMateria1.Name = "cmbCveMateria1";
            this.cmbCveMateria1.Size = new System.Drawing.Size(121, 26);
            this.cmbCveMateria1.TabIndex = 7;
            this.cmbCveMateria1.SelectedIndexChanged += new System.EventHandler(this.cmbCveMateria1_SelectedIndexChanged);
            // 
            // cmbCveEstudiante
            // 
            this.cmbCveEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveEstudiante.FormattingEnabled = true;
            this.cmbCveEstudiante.Location = new System.Drawing.Point(132, 40);
            this.cmbCveEstudiante.Name = "cmbCveEstudiante";
            this.cmbCveEstudiante.Size = new System.Drawing.Size(121, 26);
            this.cmbCveEstudiante.TabIndex = 6;
            this.cmbCveEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmbCveEstudiante_SelectedIndexChanged);
            // 
            // lblCveMateria5
            // 
            this.lblCveMateria5.AutoSize = true;
            this.lblCveMateria5.Location = new System.Drawing.Point(27, 282);
            this.lblCveMateria5.Name = "lblCveMateria5";
            this.lblCveMateria5.Size = new System.Drawing.Size(99, 18);
            this.lblCveMateria5.TabIndex = 5;
            this.lblCveMateria5.Text = "Cve. Materia5";
            // 
            // lblCveMateria4
            // 
            this.lblCveMateria4.AutoSize = true;
            this.lblCveMateria4.Location = new System.Drawing.Point(27, 236);
            this.lblCveMateria4.Name = "lblCveMateria4";
            this.lblCveMateria4.Size = new System.Drawing.Size(99, 18);
            this.lblCveMateria4.TabIndex = 4;
            this.lblCveMateria4.Text = "Cve. Materia4";
            // 
            // lblCveMateria3
            // 
            this.lblCveMateria3.AutoSize = true;
            this.lblCveMateria3.Location = new System.Drawing.Point(27, 189);
            this.lblCveMateria3.Name = "lblCveMateria3";
            this.lblCveMateria3.Size = new System.Drawing.Size(99, 18);
            this.lblCveMateria3.TabIndex = 3;
            this.lblCveMateria3.Text = "Cve. Materia3";
            // 
            // lblCveMateria2
            // 
            this.lblCveMateria2.AutoSize = true;
            this.lblCveMateria2.Location = new System.Drawing.Point(27, 143);
            this.lblCveMateria2.Name = "lblCveMateria2";
            this.lblCveMateria2.Size = new System.Drawing.Size(99, 18);
            this.lblCveMateria2.TabIndex = 2;
            this.lblCveMateria2.Text = "Cve. Materia2";
            // 
            // lblCveMateria1
            // 
            this.lblCveMateria1.AutoSize = true;
            this.lblCveMateria1.Location = new System.Drawing.Point(27, 98);
            this.lblCveMateria1.Name = "lblCveMateria1";
            this.lblCveMateria1.Size = new System.Drawing.Size(99, 18);
            this.lblCveMateria1.TabIndex = 1;
            this.lblCveMateria1.Text = "Cve. Materia1";
            // 
            // lblCveEstudiante
            // 
            this.lblCveEstudiante.AutoSize = true;
            this.lblCveEstudiante.Location = new System.Drawing.Point(15, 48);
            this.lblCveEstudiante.Name = "lblCveEstudiante";
            this.lblCveEstudiante.Size = new System.Drawing.Size(111, 18);
            this.lblCveEstudiante.TabIndex = 0;
            this.lblCveEstudiante.Text = "Cve. Estudiante";
            // 
            // frmAgregaCargaAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConE.Front.Properties.Resources.Background___copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 473);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpCargaAcademica);
            this.DoubleBuffered = true;
            this.Name = "frmAgregaCargaAcademica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Academica";
            this.Load += new System.EventHandler(this.frmAgregaCargaAcademica_Load);
            this.grpCargaAcademica.ResumeLayout(false);
            this.grpCargaAcademica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpCargaAcademica;
        private System.Windows.Forms.TextBox txtCveMateria5;
        private System.Windows.Forms.TextBox txtCveMateria4;
        private System.Windows.Forms.TextBox txtCveMateria3;
        private System.Windows.Forms.TextBox txtCveMateria2;
        private System.Windows.Forms.TextBox txtCveMateria1;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cmbCveMateria5;
        private System.Windows.Forms.ComboBox cmbCveMateria4;
        private System.Windows.Forms.ComboBox cmbCveMateria3;
        private System.Windows.Forms.ComboBox cmbCveMateria2;
        private System.Windows.Forms.ComboBox cmbCveMateria1;
        private System.Windows.Forms.ComboBox cmbCveEstudiante;
        private System.Windows.Forms.Label lblCveMateria5;
        private System.Windows.Forms.Label lblCveMateria4;
        private System.Windows.Forms.Label lblCveMateria3;
        private System.Windows.Forms.Label lblCveMateria2;
        private System.Windows.Forms.Label lblCveMateria1;
        private System.Windows.Forms.Label lblCveEstudiante;
    }
}