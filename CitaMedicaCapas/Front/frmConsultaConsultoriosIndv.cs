using ClinicaM.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaM.Front
{
    public partial class frmConsultaConsultoriosIndv : Form
    {
        DataTable data;
        public frmConsultaConsultoriosIndv()
        {
            InitializeComponent();
        }

        private void frmConsultaConsultoriosIndv_Load(object sender, EventArgs e)
        {
            try
            {
                data = NConsultorio.ObtenConsultorios();
                cmbConsultorioID.DataSource = data;
                cmbConsultorioID.DisplayMember = "CLAVE CONSULTORIO";
                cmbConsultorioID.ValueMember = "CLAVE CONSULTORIO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbConsultorioID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbConsultorioID.SelectedIndex;
            txtNombre.Text = data.Rows[valorInt][1].ToString();
            txtDomicilio.Text = data.Rows[valorInt][2].ToString();
        }
    }
}
