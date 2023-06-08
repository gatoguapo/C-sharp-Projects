using ConE.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmConsultaCalificacion : Form
    {
        public frmConsultaCalificacion()
        {
            InitializeComponent();
        }

        private void frmConsultaCalificacion_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NCalificacion.ObtenCalificaciones();
                dgvCalificaciones.DataSource = data;
                dgvCalificaciones.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConsultaCalificacion_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                string buscar = textBox.Text;
                DataTable data = NCalificacion.BuscarEstudianteCal(buscar);
                dgvCalificaciones.DataSource = data;
                dgvCalificaciones.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
