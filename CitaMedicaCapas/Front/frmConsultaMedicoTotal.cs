using System;
using System.Data;
using System.Windows.Forms;
using ClinicaM.Negocio;

namespace ClinicaM.Front
{
    public partial class frmConsultaMedicoTotal : Form
    {
        public frmConsultaMedicoTotal()
        {
            InitializeComponent();
        }

        private void frmConsultaMedicos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NMedico.ObtenMedicos();
                dgvMedicos.DataSource = data;
                dgvMedicos.Columns[1].Width = 200;
                dgvMedicos.Columns[3].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
