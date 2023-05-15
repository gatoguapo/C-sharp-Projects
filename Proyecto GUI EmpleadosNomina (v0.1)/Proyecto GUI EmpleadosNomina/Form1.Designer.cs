namespace Proyecto_GUI_EmpleadosNomina
{
    partial class frmMenuEmpleadosNomina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaRegistroLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaRegistroLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.nominaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaEmpleadoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregaEmpleadoToolStripMenuItem
            // 
            this.agregaEmpleadoToolStripMenuItem.Name = "agregaEmpleadoToolStripMenuItem";
            this.agregaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregaEmpleadoToolStripMenuItem.Text = "Agrega Empleado";
            this.agregaEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregaEmpleadoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem,
            this.individualToolStripMenuItem,
            this.datosPersonalesToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            this.individualToolStripMenuItem.Click += new System.EventHandler(this.individualToolStripMenuItem_Click);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaDepartamentoToolStripMenuItem,
            this.consultaToolStripMenuItem1});
            this.departamentosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // agregaDepartamentoToolStripMenuItem
            // 
            this.agregaDepartamentoToolStripMenuItem.Name = "agregaDepartamentoToolStripMenuItem";
            this.agregaDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.agregaDepartamentoToolStripMenuItem.Text = "Agrega Departamento";
            this.agregaDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.agregaDepartamentoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem1,
            this.individualToolStripMenuItem1,
            this.depActivosToolStripMenuItem});
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // totalToolStripMenuItem1
            // 
            this.totalToolStripMenuItem1.Name = "totalToolStripMenuItem1";
            this.totalToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.totalToolStripMenuItem1.Text = "Total";
            this.totalToolStripMenuItem1.Click += new System.EventHandler(this.totalToolStripMenuItem1_Click);
            // 
            // individualToolStripMenuItem1
            // 
            this.individualToolStripMenuItem1.Name = "individualToolStripMenuItem1";
            this.individualToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.individualToolStripMenuItem1.Text = "Individual";
            this.individualToolStripMenuItem1.Click += new System.EventHandler(this.individualToolStripMenuItem1_Click);
            // 
            // depActivosToolStripMenuItem
            // 
            this.depActivosToolStripMenuItem.Name = "depActivosToolStripMenuItem";
            this.depActivosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.depActivosToolStripMenuItem.Text = "Dep Activos";
            this.depActivosToolStripMenuItem.Click += new System.EventHandler(this.depActivosToolStripMenuItem_Click);
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaRegistroLaboralToolStripMenuItem,
            this.mostrarNominaToolStripMenuItem,
            this.consultaRegistroLaboralToolStripMenuItem});
            this.nominaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.nominaToolStripMenuItem.Text = "Nomina y Registro Laboral";
            this.nominaToolStripMenuItem.Click += new System.EventHandler(this.nominaToolStripMenuItem_Click);
            this.nominaToolStripMenuItem.MouseEnter += new System.EventHandler(this.nominaToolStripMenuItem_MouseEnter);
            this.nominaToolStripMenuItem.MouseLeave += new System.EventHandler(this.nominaToolStripMenuItem_MouseLeave);
            // 
            // agregaRegistroLaboralToolStripMenuItem
            // 
            this.agregaRegistroLaboralToolStripMenuItem.Name = "agregaRegistroLaboralToolStripMenuItem";
            this.agregaRegistroLaboralToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.agregaRegistroLaboralToolStripMenuItem.Text = "Agrega Registro Laboral";
            this.agregaRegistroLaboralToolStripMenuItem.Click += new System.EventHandler(this.agregaRegistroLaboralToolStripMenuItem_Click);
            // 
            // mostrarNominaToolStripMenuItem
            // 
            this.mostrarNominaToolStripMenuItem.Name = "mostrarNominaToolStripMenuItem";
            this.mostrarNominaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.mostrarNominaToolStripMenuItem.Text = "Mostrar Nomina";
            this.mostrarNominaToolStripMenuItem.Click += new System.EventHandler(this.mostrarNominaToolStripMenuItem_Click);
            // 
            // consultaRegistroLaboralToolStripMenuItem
            // 
            this.consultaRegistroLaboralToolStripMenuItem.Name = "consultaRegistroLaboralToolStripMenuItem";
            this.consultaRegistroLaboralToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultaRegistroLaboralToolStripMenuItem.Text = "Consulta Registro Laboral";
            this.consultaRegistroLaboralToolStripMenuItem.Click += new System.EventHandler(this.consultaRegistroLaboralToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(531, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 45);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuEmpleadosNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_GUI_EmpleadosNomina.Properties.Resources.Menu_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuEmpleadosNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Empleados Nomina";
            this.Load += new System.EventHandler(this.frmMenuEmpleadosNomina_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaRegistroLaboralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaRegistroLaboralToolStripMenuItem;
    }
}

