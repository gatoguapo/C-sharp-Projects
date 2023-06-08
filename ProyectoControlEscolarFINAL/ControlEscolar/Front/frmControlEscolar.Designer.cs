
using System;

namespace ConE.Front
{
    partial class frmControlEscolar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAcademicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(622, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 50);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.calificacionToolStripMenuItem,
            this.cargaAcademicaToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.actualizaToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.estudianteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // actualizaToolStripMenuItem
            // 
            this.actualizaToolStripMenuItem.Name = "actualizaToolStripMenuItem";
            this.actualizaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.actualizaToolStripMenuItem.Text = "Actualiza";
            this.actualizaToolStripMenuItem.Click += new System.EventHandler(this.actualizaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.totalToolStripMenuItem.Text = "Total";
            this.totalToolStripMenuItem.Click += new System.EventHandler(this.totalToolStripMenuItem_Click);
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.eliminarToolStripMenuItem,
            this.consultaToolStripMenuItem1});
            this.carreraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.carreraToolStripMenuItem.Text = "Carrera";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem1});
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // totalToolStripMenuItem1
            // 
            this.totalToolStripMenuItem1.Name = "totalToolStripMenuItem1";
            this.totalToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.totalToolStripMenuItem1.Text = "Total";
            this.totalToolStripMenuItem1.Click += new System.EventHandler(this.totalToolStripMenuItem1_Click);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.actualizaToolStripMenuItem1,
            this.consultaToolStripMenuItem2});
            this.materiaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // actualizaToolStripMenuItem1
            // 
            this.actualizaToolStripMenuItem1.Name = "actualizaToolStripMenuItem1";
            this.actualizaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.actualizaToolStripMenuItem1.Text = "Actualiza";
            this.actualizaToolStripMenuItem1.Click += new System.EventHandler(this.actualizaToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem2
            // 
            this.consultaToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem2});
            this.consultaToolStripMenuItem2.Name = "consultaToolStripMenuItem2";
            this.consultaToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.consultaToolStripMenuItem2.Text = "Consulta";
            // 
            // totalToolStripMenuItem2
            // 
            this.totalToolStripMenuItem2.Name = "totalToolStripMenuItem2";
            this.totalToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.totalToolStripMenuItem2.Text = "Total";
            this.totalToolStripMenuItem2.Click += new System.EventHandler(this.totalToolStripMenuItem2_Click);
            // 
            // calificacionToolStripMenuItem
            // 
            this.calificacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaToolStripMenuItem,
            this.consultaToolStripMenuItem3});
            this.calificacionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calificacionToolStripMenuItem.Name = "calificacionToolStripMenuItem";
            this.calificacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.calificacionToolStripMenuItem.Text = "Calificacion";
            // 
            // agregaToolStripMenuItem
            // 
            this.agregaToolStripMenuItem.Name = "agregaToolStripMenuItem";
            this.agregaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.agregaToolStripMenuItem.Text = "Agrega";
            this.agregaToolStripMenuItem.Click += new System.EventHandler(this.agregaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem3
            // 
            this.consultaToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem3});
            this.consultaToolStripMenuItem3.Name = "consultaToolStripMenuItem3";
            this.consultaToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.consultaToolStripMenuItem3.Text = "Consulta ";
            // 
            // totalToolStripMenuItem3
            // 
            this.totalToolStripMenuItem3.Name = "totalToolStripMenuItem3";
            this.totalToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.totalToolStripMenuItem3.Text = "Total";
            this.totalToolStripMenuItem3.Click += new System.EventHandler(this.totalToolStripMenuItem3_Click);
            // 
            // cargaAcademicaToolStripMenuItem1
            // 
            this.cargaAcademicaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.consultaToolStripMenuItem4});
            this.cargaAcademicaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cargaAcademicaToolStripMenuItem1.Name = "cargaAcademicaToolStripMenuItem1";
            this.cargaAcademicaToolStripMenuItem1.Size = new System.Drawing.Size(112, 20);
            this.cargaAcademicaToolStripMenuItem1.Text = "Carga Academica";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
            this.agregarToolStripMenuItem3.Text = "Agregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // consultaToolStripMenuItem4
            // 
            this.consultaToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalToolStripMenuItem4});
            this.consultaToolStripMenuItem4.Name = "consultaToolStripMenuItem4";
            this.consultaToolStripMenuItem4.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem4.Text = "Consulta";
            // 
            // totalToolStripMenuItem4
            // 
            this.totalToolStripMenuItem4.Name = "totalToolStripMenuItem4";
            this.totalToolStripMenuItem4.Size = new System.Drawing.Size(99, 22);
            this.totalToolStripMenuItem4.Text = "Total";
            this.totalToolStripMenuItem4.Click += new System.EventHandler(this.totalToolStripMenuItem4_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmControlEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConE.Front.Properties.Resources.Menu_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmControlEscolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControlEscolar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem actualizaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem calificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cargaAcademicaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}