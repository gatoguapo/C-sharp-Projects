namespace Alumnos_CarrerasGUI
{
    partial class frmConsultaAlumnoIndividual
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
            this.cmbNumControl = new System.Windows.Forms.ComboBox();
            this.lblNumCon = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNumControl
            // 
            this.cmbNumControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumControl.FormattingEnabled = true;
            this.cmbNumControl.Location = new System.Drawing.Point(324, 31);
            this.cmbNumControl.Name = "cmbNumControl";
            this.cmbNumControl.Size = new System.Drawing.Size(121, 21);
            this.cmbNumControl.TabIndex = 0;
            this.cmbNumControl.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblNumCon
            // 
            this.lblNumCon.AutoSize = true;
            this.lblNumCon.Location = new System.Drawing.Point(205, 34);
            this.lblNumCon.Name = "lblNumCon";
            this.lblNumCon.Size = new System.Drawing.Size(65, 13);
            this.lblNumCon.TabIndex = 1;
            this.lblNumCon.Text = "Num Control";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(205, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(205, 131);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 3;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(205, 174);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(205, 264);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(205, 221);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(324, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(277, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(324, 131);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(277, 20);
            this.txtDomicilio.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(324, 174);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(48, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(324, 257);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.ReadOnly = true;
            this.txtCarrera.Size = new System.Drawing.Size(165, 20);
            this.txtCarrera.TabIndex = 10;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(324, 214);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(76, 20);
            this.txtSexo.TabIndex = 11;
            // 
            // frmConsultaAlumnoIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumCon);
            this.Controls.Add(this.cmbNumControl);
            this.Name = "frmConsultaAlumnoIndividual";
            this.Text = "Consulta Alumno";
            this.Load += new System.EventHandler(this.frmConsultaAlumnoIndividual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNumControl;
        private System.Windows.Forms.Label lblNumCon;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtSexo;
    }
}