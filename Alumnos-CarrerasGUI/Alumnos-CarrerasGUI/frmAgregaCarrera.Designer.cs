namespace Alumnos_CarrerasGUI
{
    partial class frmAgregaCarrera
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
            this.chkActiva = new System.Windows.Forms.CheckBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Location = new System.Drawing.Point(303, 174);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(56, 17);
            this.chkActiva.TabIndex = 0;
            this.chkActiva.Text = "Activa";
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(247, 56);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(18, 13);
            this.lblCarrera.TabIndex = 1;
            this.lblCarrera.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(345, 53);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(230, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(342, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(460, 224);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Location = new System.Drawing.Point(247, 106);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(81, 13);
            this.lblNombreCarrera.TabIndex = 6;
            this.lblNombreCarrera.Text = "Nombre Carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCarrera.Location = new System.Drawing.Point(345, 103);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCarrera.TabIndex = 7;
            this.txtNombreCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCarrera_KeyPress);
            this.txtNombreCarrera.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreCarrera_Validating);
            this.txtNombreCarrera.Validated += new System.EventHandler(this.txtNombreCarrera_Validated);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.lblNombreCarrera);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.chkActiva);
            this.Name = "frmAgregaCarrera";
            this.Text = "Agregar Carrera";
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}