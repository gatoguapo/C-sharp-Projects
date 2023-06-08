using System;
using System.Data;
using System.Windows.Forms;
using ConE.Negocio;

namespace ConE.Front
{
    public partial class frmEliminaCarrera : Form
    {
        DataTable data;

        public frmEliminaCarrera()
        {
            InitializeComponent();
        }

        private void frmEliminaCarrera_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                data = NCarrera.ObtenCarreras();
                cmbClaveCarr.DataSource = data;
                cmbClaveCarr.DisplayMember = "CLAVE CARRERA";
                cmbClaveCarr.ValueMember = "CLAVE CARRERA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string resp = "";

            int vInt = cmbClaveCarr.SelectedIndex;
            int claveCarr = Convert.ToInt32(data.Rows[vInt][0].ToString());

            try
            {
                resp = NCarrera.EliminarCarrera(claveCarr);
                if (resp.Equals("OK"))
                {
                    MessageBox.Show("Carrera eliminado exitosamente");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbClaveCarr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbClaveCarr.SelectedIndex;
            txtNombre.Text = data.Rows[valorInt][1].ToString();
            txtFecha.Text = data.Rows[valorInt][2].ToString();
        }
    }
}
