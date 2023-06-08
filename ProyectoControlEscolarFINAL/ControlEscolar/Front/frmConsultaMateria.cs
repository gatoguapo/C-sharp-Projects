using ConE.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmConsultaMateria : Form
    {
        public frmConsultaMateria()
        {
            InitializeComponent();
        }

        private void frmConsultaMateria_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NMateria.ObtenMaterias();
                dgvMaterias.DataSource = data;
                dgvMaterias.Columns[1].Width = 200;
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
                DataTable data = NMateria.BuscarMaterias(buscar);
                dgvMaterias.DataSource = data;
                dgvMaterias.Columns[1].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
