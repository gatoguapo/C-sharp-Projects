using ConE.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmConsultaCargaAcademica : Form
    {
        public frmConsultaCargaAcademica()
        {
            InitializeComponent();
        }

        private void frmConsultaCargaAcademica_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NCargaAcademica.ObtenCargaAcademica();
                dgvCargaAcademica.DataSource = data;
                dgvCargaAcademica.Columns[1].Width = 220;
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
                DataTable data = NCargaAcademica.BuscarEstudianteCarga(buscar);
                dgvCargaAcademica.DataSource = data;
                dgvCargaAcademica.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
