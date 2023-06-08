using ConE.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmConsultaEstudiante : Form
    {
        public frmConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void frmConsultaEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NEstudiante.ObtenEstudiante();
                dgvEstudiantes.DataSource = data;
                dgvEstudiantes.Columns[1].Width = 220;
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
                DataTable data = NEstudiante.BuscarEstudiantes(buscar);
                dgvEstudiantes.DataSource = data;
                dgvEstudiantes.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
