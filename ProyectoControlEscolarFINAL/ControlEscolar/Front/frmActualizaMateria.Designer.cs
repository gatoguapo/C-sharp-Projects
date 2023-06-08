
namespace ConE.Front
{
    partial class frmActualizaMateria
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
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.txtAlumIns = new System.Windows.Forms.TextBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.txtNomMaestro = new System.Windows.Forms.TextBox();
            this.txtMaxAlum = new System.Windows.Forms.TextBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMaxAlumnos = new System.Windows.Forms.Label();
            this.lblAlumInscritos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombreMaestro = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(160, 204);
            this.txtCreditos.MaxLength = 1;
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(68, 20);
            this.txtCreditos.TabIndex = 60;
            this.txtCreditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditos_KeyPress);
            // 
            // cmbClave
            // 
            this.cmbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(160, 15);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(121, 21);
            this.cmbClave.TabIndex = 59;
            this.cmbClave.SelectedIndexChanged += new System.EventHandler(this.cmbClave_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(431, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 56);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualiza
            // 
            this.btnActualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiza.Location = new System.Drawing.Point(230, 270);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(100, 56);
            this.btnActualiza.TabIndex = 57;
            this.btnActualiza.Text = "Actualiza";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // txtAlumIns
            // 
            this.txtAlumIns.Location = new System.Drawing.Point(603, 206);
            this.txtAlumIns.MaxLength = 2;
            this.txtAlumIns.Name = "txtAlumIns";
            this.txtAlumIns.Size = new System.Drawing.Size(68, 20);
            this.txtAlumIns.TabIndex = 56;
            this.txtAlumIns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlumIns_KeyPress);
            this.txtAlumIns.Validated += new System.EventHandler(this.txtAlumIns_Validated);
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "00:00:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00"});
            this.cmbHora.Location = new System.Drawing.Point(160, 152);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 21);
            this.cmbHora.TabIndex = 55;
            // 
            // txtNomMaestro
            // 
            this.txtNomMaestro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomMaestro.Location = new System.Drawing.Point(160, 108);
            this.txtNomMaestro.MaxLength = 100;
            this.txtNomMaestro.Name = "txtNomMaestro";
            this.txtNomMaestro.Size = new System.Drawing.Size(511, 20);
            this.txtNomMaestro.TabIndex = 54;
            this.txtNomMaestro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomMaestro_KeyPress);
            this.txtNomMaestro.Validated += new System.EventHandler(this.txtNomMaestro_Validated);
            // 
            // txtMaxAlum
            // 
            this.txtMaxAlum.Location = new System.Drawing.Point(380, 207);
            this.txtMaxAlum.MaxLength = 2;
            this.txtMaxAlum.Name = "txtMaxAlum";
            this.txtMaxAlum.Size = new System.Drawing.Size(68, 20);
            this.txtMaxAlum.TabIndex = 53;
            this.txtMaxAlum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxAlum_KeyPress);
            this.txtMaxAlum.Validated += new System.EventHandler(this.txtMaxAlum_Validated);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(503, 60);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(168, 21);
            this.cmbCarrera.TabIndex = 52;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(160, 61);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 20);
            this.txtNombre.TabIndex = 51;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // lblMaxAlumnos
            // 
            this.lblMaxAlumnos.AutoSize = true;
            this.lblMaxAlumnos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaxAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAlumnos.Location = new System.Drawing.Point(272, 206);
            this.lblMaxAlumnos.Name = "lblMaxAlumnos";
            this.lblMaxAlumnos.Size = new System.Drawing.Size(102, 18);
            this.lblMaxAlumnos.TabIndex = 50;
            this.lblMaxAlumnos.Text = "Max. Alumnos";
            // 
            // lblAlumInscritos
            // 
            this.lblAlumInscritos.AutoSize = true;
            this.lblAlumInscritos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlumInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumInscritos.Location = new System.Drawing.Point(492, 208);
            this.lblAlumInscritos.Name = "lblAlumInscritos";
            this.lblAlumInscritos.Size = new System.Drawing.Size(105, 18);
            this.lblAlumInscritos.TabIndex = 49;
            this.lblAlumInscritos.Text = "Alum. Inscritos";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(113, 155);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 18);
            this.lblHora.TabIndex = 48;
            this.lblHora.Text = "Hora";
            // 
            // lblNombreMaestro
            // 
            this.lblNombreMaestro.AutoSize = true;
            this.lblNombreMaestro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaestro.Location = new System.Drawing.Point(33, 110);
            this.lblNombreMaestro.Name = "lblNombreMaestro";
            this.lblNombreMaestro.Size = new System.Drawing.Size(121, 18);
            this.lblNombreMaestro.TabIndex = 47;
            this.lblNombreMaestro.Text = "Nombre Maestro";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(90, 206);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(64, 18);
            this.lblCreditos.TabIndex = 46;
            this.lblCreditos.Text = "Creditos";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(439, 63);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(58, 18);
            this.lblCarrera.TabIndex = 45;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(39, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(115, 18);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre Materia";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(109, 19);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(45, 18);
            this.lblClave.TabIndex = 43;
            this.lblClave.Text = "Clave";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmActualizaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConE.Front.Properties.Resources.Background___copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.cmbClave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualiza);
            this.Controls.Add(this.txtAlumIns);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.txtNomMaestro);
            this.Controls.Add(this.txtMaxAlum);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMaxAlumnos);
            this.Controls.Add(this.lblAlumInscritos);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNombreMaestro);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.DoubleBuffered = true;
            this.Name = "frmActualizaMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualiza Materia";
            this.Load += new System.EventHandler(this.frmActualizaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.TextBox txtAlumIns;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.TextBox txtNomMaestro;
        private System.Windows.Forms.TextBox txtMaxAlum;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMaxAlumnos;
        private System.Windows.Forms.Label lblAlumInscritos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNombreMaestro;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ErrorProvider error;
    }
}