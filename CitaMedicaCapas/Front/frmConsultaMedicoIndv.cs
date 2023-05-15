using System;
using System.Data;
using System.Windows.Forms;
using ClinicaM.Negocio;


namespace ClinicaM.Front
{
    public partial class frmConsultaMedicoIndv : Form
    {
        DataTable data;
        public frmConsultaMedicoIndv()
        {
            InitializeComponent();
        }

        private void frmConsultaMedicoIndv_Load(object sender, EventArgs e)
        {
            try
            {
                data = NMedico.ObtenMedicos();
                cmbClaves.DataSource = data;
                cmbClaves.DisplayMember = "CLAVE MEDICO";
                cmbClaves.ValueMember = "CLAVE MEDICO";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbClaves.SelectedIndex;
            txtNombre.Text = data.Rows[valorInt][1].ToString();
            txtEspecialidad.Text = data.Rows[valorInt][2].ToString();
            txtSubespecialidad.Text = data.Rows[valorInt][3].ToString();
            mtxtTelefono.Text = data.Rows[valorInt][4].ToString();
            txtConsultorio.Text = data.Rows[valorInt][5].ToString();
        }
    }
}
