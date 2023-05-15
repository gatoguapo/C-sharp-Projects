namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmMostrarNomina
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
            this.btnCalculaNomina = new System.Windows.Forms.Button();
            this.btnMostrarNomina = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarNom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculaNomina
            // 
            this.btnCalculaNomina.Location = new System.Drawing.Point(39, 31);
            this.btnCalculaNomina.Name = "btnCalculaNomina";
            this.btnCalculaNomina.Size = new System.Drawing.Size(85, 46);
            this.btnCalculaNomina.TabIndex = 0;
            this.btnCalculaNomina.Text = "Calcular Nomina";
            this.btnCalculaNomina.UseVisualStyleBackColor = true;
            this.btnCalculaNomina.Click += new System.EventHandler(this.btnCalculaNomina_Click);
            // 
            // btnMostrarNomina
            // 
            this.btnMostrarNomina.Location = new System.Drawing.Point(167, 31);
            this.btnMostrarNomina.Name = "btnMostrarNomina";
            this.btnMostrarNomina.Size = new System.Drawing.Size(85, 46);
            this.btnMostrarNomina.TabIndex = 1;
            this.btnMostrarNomina.Text = "Mostrar Nomina";
            this.btnMostrarNomina.UseVisualStyleBackColor = true;
            this.btnMostrarNomina.Click += new System.EventHandler(this.btnMostrarNomina_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 124);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 46);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarNom
            // 
            this.btnBorrarNom.Location = new System.Drawing.Point(39, 124);
            this.btnBorrarNom.Name = "btnBorrarNom";
            this.btnBorrarNom.Size = new System.Drawing.Size(85, 46);
            this.btnBorrarNom.TabIndex = 3;
            this.btnBorrarNom.Text = "Borrar la nomina";
            this.btnBorrarNom.UseVisualStyleBackColor = true;
            this.btnBorrarNom.Click += new System.EventHandler(this.btnBorrarNom_Click);
            // 
            // frmMostrarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.btnBorrarNom);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarNomina);
            this.Controls.Add(this.btnCalculaNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMostrarNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculaNomina;
        private System.Windows.Forms.Button btnMostrarNomina;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarNom;
    }
}