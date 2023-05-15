namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmBorrarNomina
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
            this.btnBorrarNominaTotal = new System.Windows.Forms.Button();
            this.btnBorrarIndv = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblClaveEmp = new System.Windows.Forms.Label();
            this.cmbClaveEmp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(265, 114);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 45);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarNominaTotal
            // 
            this.btnBorrarNominaTotal.Location = new System.Drawing.Point(135, 114);
            this.btnBorrarNominaTotal.Name = "btnBorrarNominaTotal";
            this.btnBorrarNominaTotal.Size = new System.Drawing.Size(92, 45);
            this.btnBorrarNominaTotal.TabIndex = 10;
            this.btnBorrarNominaTotal.Text = "Borrar Todas las Nominas";
            this.btnBorrarNominaTotal.UseVisualStyleBackColor = true;
            this.btnBorrarNominaTotal.Click += new System.EventHandler(this.btnBorrarNominaTotal_Click);
            // 
            // btnBorrarIndv
            // 
            this.btnBorrarIndv.Location = new System.Drawing.Point(16, 114);
            this.btnBorrarIndv.Name = "btnBorrarIndv";
            this.btnBorrarIndv.Size = new System.Drawing.Size(86, 45);
            this.btnBorrarIndv.TabIndex = 9;
            this.btnBorrarIndv.Text = "Borrar Nomina";
            this.btnBorrarIndv.UseVisualStyleBackColor = true;
            this.btnBorrarIndv.Click += new System.EventHandler(this.btnBorrarIndv_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(23, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(303, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Seleccione la clave del empleado que desea borrar su nomina.";
            // 
            // lblClaveEmp
            // 
            this.lblClaveEmp.AutoSize = true;
            this.lblClaveEmp.Location = new System.Drawing.Point(27, 69);
            this.lblClaveEmp.Name = "lblClaveEmp";
            this.lblClaveEmp.Size = new System.Drawing.Size(84, 13);
            this.lblClaveEmp.TabIndex = 7;
            this.lblClaveEmp.Text = "Clave Empleado";
            // 
            // cmbClaveEmp
            // 
            this.cmbClaveEmp.FormattingEnabled = true;
            this.cmbClaveEmp.Location = new System.Drawing.Point(135, 66);
            this.cmbClaveEmp.Name = "cmbClaveEmp";
            this.cmbClaveEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveEmp.TabIndex = 6;
            // 
            // frmBorrarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 190);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrarNominaTotal);
            this.Controls.Add(this.btnBorrarIndv);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblClaveEmp);
            this.Controls.Add(this.cmbClaveEmp);
            this.Name = "frmBorrarNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar Nominas";
            this.Load += new System.EventHandler(this.frmBorrarNomina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarNominaTotal;
        private System.Windows.Forms.Button btnBorrarIndv;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblClaveEmp;
        private System.Windows.Forms.ComboBox cmbClaveEmp;
    }
}