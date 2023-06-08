
namespace ConE.Front
{
    partial class frmAgregaCalificacion
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.cmbCveMateria = new System.Windows.Forms.ComboBox();
            this.cmbCveEstudiante = new System.Windows.Forms.ComboBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblCveMateria = new System.Windows.Forms.Label();
            this.lblCveEstudiante = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(534, 261);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 56);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(370, 262);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(95, 55);
            this.btnPDF.TabIndex = 8;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(209, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 55);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(38, 262);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 55);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtCalificacion);
            this.groupBox1.Controls.Add(this.cmbCveMateria);
            this.groupBox1.Controls.Add(this.cmbCveEstudiante);
            this.groupBox1.Controls.Add(this.txtMateria);
            this.groupBox1.Controls.Add(this.txtEstudiante);
            this.groupBox1.Controls.Add(this.lblEstudiante);
            this.groupBox1.Controls.Add(this.lblMateria);
            this.groupBox1.Controls.Add(this.lblCalificacion);
            this.groupBox1.Controls.Add(this.lblCveMateria);
            this.groupBox1.Controls.Add(this.lblCveEstudiante);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificaciones";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(132, 163);
            this.txtCalificacion.MaxLength = 3;
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 24);
            this.txtCalificacion.TabIndex = 9;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.txtCalificacion_TextChanged);
            this.txtCalificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalificacion_KeyPress);
            this.txtCalificacion.Validated += new System.EventHandler(this.txtCalificacion_Validated);
            // 
            // cmbCveMateria
            // 
            this.cmbCveMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveMateria.FormattingEnabled = true;
            this.cmbCveMateria.Location = new System.Drawing.Point(132, 98);
            this.cmbCveMateria.Name = "cmbCveMateria";
            this.cmbCveMateria.Size = new System.Drawing.Size(121, 26);
            this.cmbCveMateria.TabIndex = 8;
            this.cmbCveMateria.SelectedIndexChanged += new System.EventHandler(this.cmbCveMateria_SelectedIndexChanged);
            // 
            // cmbCveEstudiante
            // 
            this.cmbCveEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCveEstudiante.FormattingEnabled = true;
            this.cmbCveEstudiante.Location = new System.Drawing.Point(132, 37);
            this.cmbCveEstudiante.Name = "cmbCveEstudiante";
            this.cmbCveEstudiante.Size = new System.Drawing.Size(121, 26);
            this.cmbCveEstudiante.TabIndex = 7;
            this.cmbCveEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmbCveEstudiante_SelectedIndexChanged);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(363, 100);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(205, 24);
            this.txtMateria.TabIndex = 6;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(363, 39);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.Size = new System.Drawing.Size(205, 24);
            this.txtEstudiante.TabIndex = 5;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(280, 45);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(77, 18);
            this.lblEstudiante.TabIndex = 4;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(300, 106);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(57, 18);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(42, 169);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(84, 18);
            this.lblCalificacion.TabIndex = 2;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // lblCveMateria
            // 
            this.lblCveMateria.AutoSize = true;
            this.lblCveMateria.Location = new System.Drawing.Point(35, 107);
            this.lblCveMateria.Name = "lblCveMateria";
            this.lblCveMateria.Size = new System.Drawing.Size(91, 18);
            this.lblCveMateria.TabIndex = 1;
            this.lblCveMateria.Text = "Cve. Materia";
            // 
            // lblCveEstudiante
            // 
            this.lblCveEstudiante.AutoSize = true;
            this.lblCveEstudiante.Location = new System.Drawing.Point(15, 45);
            this.lblCveEstudiante.Name = "lblCveEstudiante";
            this.lblCveEstudiante.Size = new System.Drawing.Size(111, 18);
            this.lblCveEstudiante.TabIndex = 0;
            this.lblCveEstudiante.Text = "Cve. Estudiante";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmAgregaCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConE.Front.Properties.Resources.Background___copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmAgregaCalificacion";
            this.Text = "Agrega Calificacion";
            this.Load += new System.EventHandler(this.frmAgregaCalificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.ComboBox cmbCveMateria;
        private System.Windows.Forms.ComboBox cmbCveEstudiante;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblCveMateria;
        private System.Windows.Forms.Label lblCveEstudiante;
        private System.Windows.Forms.ErrorProvider error;
    }
}