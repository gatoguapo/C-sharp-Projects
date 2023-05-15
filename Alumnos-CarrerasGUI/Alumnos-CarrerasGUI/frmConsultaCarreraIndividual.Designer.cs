namespace Alumnos_CarrerasGUI
{
    partial class frmConsultaCarreraIndividual
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(211, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Location = new System.Drawing.Point(211, 133);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblNombreCarrera.TabIndex = 1;
            this.lblNombreCarrera.Text = "Carrera";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(211, 211);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(42, 13);
            this.lblEstatus.TabIndex = 2;
            this.lblEstatus.Text = "Estatus";
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(303, 60);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 21);
            this.cmbID.TabIndex = 3;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(303, 130);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.ReadOnly = true;
            this.txtCarrera.Size = new System.Drawing.Size(179, 20);
            this.txtCarrera.TabIndex = 4;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(303, 211);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(77, 20);
            this.txtEstatus.TabIndex = 5;
            // 
            // frmConsultaCarreraIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.lblID);
            this.Name = "frmConsultaCarreraIndividual";
            this.Text = "Consulta Carrera";
            this.Load += new System.EventHandler(this.frmConsultaCarreraIndividual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtEstatus;
    }
}