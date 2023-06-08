using ConE.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmConsultaCarrera : Form
    {
        public frmConsultaCarrera()
        {
            InitializeComponent();
        }

        private void frmConsultaCarrera_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NCarrera.ObtenCarreras();
                dgvCarreras.DataSource = data;
                dgvCarreras.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                string buscar = textBox.Text;
                DataTable data = NCarrera.BuscarCarreras(buscar);
                dgvCarreras.DataSource = data;
                dgvCarreras.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
