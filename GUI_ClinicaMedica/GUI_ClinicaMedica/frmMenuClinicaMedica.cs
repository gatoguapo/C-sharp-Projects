using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ClinicaMedica
{
    public partial class frmMenuClinicaMedica : Form
    {
        public frmMenuClinicaMedica()
        {
            InitializeComponent();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedicosIndv medicosConsultaIndividual = new frmConsultaMedicosIndv();
            medicosConsultaIndividual.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMedicosTotal medicosConsultaTotal = new frmConsultaMedicosTotal();
            medicosConsultaTotal.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCitasIndv citasConsultaIndv = new frmConsultaCitasIndv();
            citasConsultaIndv.ShowDialog();
        }

        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCitasTotal citasConsultaTotal = new frmConsultaCitasTotal();
            citasConsultaTotal.ShowDialog();
        }
    }
}
