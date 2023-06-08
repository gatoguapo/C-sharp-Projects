using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmControlEscolar : Form
    {
        public frmControlEscolar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaEstudiante agregaEstudiante = new frmAgregaEstudiante();
            agregaEstudiante.ShowDialog();
        }

        private void actualizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizaEstudiante actualizaEstudiante = new frmActualizaEstudiante();
            actualizaEstudiante.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstudiante consultaEstudiante = new frmConsultaEstudiante();
            consultaEstudiante.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregaCarrera agregaCarrera = new frmAgregaCarrera();
            agregaCarrera.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminaCarrera eliminaCarrera = new frmEliminaCarrera();
            eliminaCarrera.ShowDialog();
        }

        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCarrera consultaCarrera = new frmConsultaCarrera();
            consultaCarrera.ShowDialog();
        }

        

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregaMateria agregaMateria = new frmAgregaMateria();
            agregaMateria.ShowDialog();
        }

        private void actualizaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmActualizaMateria actualizaMateria = new frmActualizaMateria();
            actualizaMateria.ShowDialog();
        }

        private void totalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaMateria consultaMateria = new frmConsultaMateria();
            consultaMateria.ShowDialog();
        }

        private void agregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaCalificacion agregaCalificacion = new frmAgregaCalificacion();
            agregaCalificacion.ShowDialog();
        }

        private void totalToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultaCalificacion consultaCalificacion = new frmConsultaCalificacion();
            consultaCalificacion.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAgregaCargaAcademica agregaCargaAcademica = new frmAgregaCargaAcademica();
            agregaCargaAcademica.ShowDialog();
        }

        private void totalToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmConsultaCargaAcademica consultaCargaAcademica = new frmConsultaCargaAcademica();
            consultaCargaAcademica.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            acercaDe.ShowDialog();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
