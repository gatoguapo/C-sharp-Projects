using ClinicaM.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicaM.Front
{
    public partial class frmConsultaCitaTotal : Form
    {
        public frmConsultaCitaTotal()
        {
            InitializeComponent();
        }

        private void frmConsultaCitaTotal_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NCitaMedica.ObtenCitas();
                dgvCitas.DataSource = data;
                dgvCitas.Columns[2].Width = 220;
                dgvCitas.Columns[5].Width = 220;
                dgvCitas.Columns[7].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
