using ClinicaM.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicaM.Front
{
    public partial class frmConsultaCitaIndv : Form
    {
        DataTable data;
        public frmConsultaCitaIndv()
        {
            InitializeComponent();
        }

        private void frmConsultaCitaIndv_Load(object sender, EventArgs e)
        {
            try
            {
                data = NCitaMedica.ObtenCitas();
                cmbClaveCita.DataSource = data;
                cmbClaveCita.DisplayMember = "CLAVE DE LA CITA";
                cmbClaveCita.ValueMember = "CLAVE DE LA CITA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbClaveCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbClaveCita.SelectedIndex;
            txtClaveMedico.Text = data.Rows[valorInt][1].ToString();
            txtNombreMedico.Text = data.Rows[valorInt][2].ToString();
            txtFecha.Text = data.Rows[valorInt][3].ToString();
            txtHora.Text = data.Rows[valorInt][4].ToString();
            txtNombrePaciente.Text = data.Rows[valorInt][5].ToString();
            txtTelefonoPaciente.Text = data.Rows[valorInt][6].ToString();
            txtObservaciones.Text = data.Rows[valorInt][7].ToString();
        }
    }
}
