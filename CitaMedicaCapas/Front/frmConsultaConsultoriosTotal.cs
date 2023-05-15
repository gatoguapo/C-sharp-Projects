using ClinicaM.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicaM.Front
{
    public partial class frmConsultaConsultoriosTotal : Form
    {
        public frmConsultaConsultoriosTotal()
        {
            InitializeComponent();
        }

        private void frmConsultaConsultoriosTotal_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NConsultorio.ObtenConsultorios();
                dgvConsultorios.DataSource = data;
                dgvConsultorios.Columns[1].Width = 220;
                dgvConsultorios.Columns[2].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
