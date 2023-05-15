using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaM.Front
{
    public partial class frmMenuClinicaMedica : Form
    {
        public frmMenuClinicaMedica()
        {
            InitializeComponent();
        }

        private void agregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaMedico agregaMedico = new frmAgregaMedico();
            agregaMedico.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedicoIndv consultaMedIndv = new frmConsultaMedicoIndv();
            consultaMedIndv.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedicoTotal consultaMedTotal = new frmConsultaMedicoTotal();
            consultaMedTotal.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCitaIndv consultaCitaIndv = new frmConsultaCitaIndv();
            consultaCitaIndv.ShowDialog();
        }

        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCitaTotal consultaCitaTotal = new frmConsultaCitaTotal();
            consultaCitaTotal.ShowDialog();
        }

        private void agregaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregaCitaMedica agregaCitaMedica = new frmAgregaCitaMedica();
            agregaCitaMedica.ShowDialog();
        }

        private void totalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaConsultoriosTotal consultaConsultoriosTotal = new frmConsultaConsultoriosTotal();
            consultaConsultoriosTotal.ShowDialog();
        }

        private void individualToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaConsultoriosIndv consultaConsultoriosIndv = new frmConsultaConsultoriosIndv();
            consultaConsultoriosIndv.ShowDialog();
        }

        private void agregaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregaConsultorios agregaConsultorios = new frmAgregaConsultorios();
            agregaConsultorios.ShowDialog();
        }
    }
}
