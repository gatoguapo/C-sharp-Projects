namespace ClinicaM.Front
{
    partial class frmConsultaConsultoriosTotal
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
            this.dgvConsultorios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultorios
            // 
            this.dgvConsultorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultorios.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultorios.Name = "dgvConsultorios";
            this.dgvConsultorios.Size = new System.Drawing.Size(585, 470);
            this.dgvConsultorios.TabIndex = 0;
            // 
            // frmConsultaConsultoriosTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 470);
            this.Controls.Add(this.dgvConsultorios);
            this.Name = "frmConsultaConsultoriosTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Consultorios";
            this.Load += new System.EventHandler(this.frmConsultaConsultoriosTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultorios;
    }
}