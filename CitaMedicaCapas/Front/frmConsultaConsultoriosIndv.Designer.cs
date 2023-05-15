namespace ClinicaM.Front
{
    partial class frmConsultaConsultoriosIndv
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
            this.cmbConsultorioID = new System.Windows.Forms.ComboBox();
            this.lblConsultorioID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbConsultorioID
            // 
            this.cmbConsultorioID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorioID.FormattingEnabled = true;
            this.cmbConsultorioID.Location = new System.Drawing.Point(139, 22);
            this.cmbConsultorioID.Name = "cmbConsultorioID";
            this.cmbConsultorioID.Size = new System.Drawing.Size(121, 21);
            this.cmbConsultorioID.TabIndex = 0;
            this.cmbConsultorioID.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorioID_SelectedIndexChanged);
            // 
            // lblConsultorioID
            // 
            this.lblConsultorioID.AutoSize = true;
            this.lblConsultorioID.Location = new System.Drawing.Point(35, 25);
            this.lblConsultorioID.Name = "lblConsultorioID";
            this.lblConsultorioID.Size = new System.Drawing.Size(73, 13);
            this.lblConsultorioID.TabIndex = 1;
            this.lblConsultorioID.Text = "Consultorio ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Consultorio";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(59, 118);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(139, 115);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(247, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // frmConsultaConsultoriosIndv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 171);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblConsultorioID);
            this.Controls.Add(this.cmbConsultorioID);
            this.Name = "frmConsultaConsultoriosIndv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Consultorios Individual";
            this.Load += new System.EventHandler(this.frmConsultaConsultoriosIndv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbConsultorioID;
        private System.Windows.Forms.Label lblConsultorioID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
    }
}