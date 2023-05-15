using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace GUI_ClinicaMedica
{
    public partial class frmConsultaCitasIndv : Form
    {
        public frmConsultaCitasIndv()
        {
            InitializeComponent();
        }

        private void frmConsultaCitasIndv_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=DESKTOP-72TPBNU;Initial Catalog=ClinicaMedica;Integrated Security=True";
            SqlConnection con = UsoBD.ConectaBD(strCon);

            if (con.Equals(null))
            {
                MessageBox.Show("Imposible conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
            }

            SqlDataReader lector = null;
            string strComando = "Select ClaveCita from CitaMedica";

            lector = UsoBD.Consulta(strComando, con);
            if (lector.Equals(null))
            {
                MessageBox.Show("Error en Consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                con.Close();
                return;
            }

            if (lector.HasRows)
            {
                cmbClaveCita.Items.Clear();
                while (lector.Read())
                {
                    cmbClaveCita.Items.Add(lector.GetValue(0).ToString());
                }
            }
            con.Close();
        }

        private void cmbClaveCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClaveCita.SelectedItem.ToString();
            string strCon = "Data Source=DESKTOP-72TPBNU;Initial Catalog=ClinicaMedica;Integrated Security=True";
            SqlConnection con = UsoBD.ConectaBD(strCon);

            if (con.Equals(null))
            {
                MessageBox.Show("Imposible conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
            }

            SqlDataReader lector = null;
            string strComando = "Select c.*, 'Nombre Medico' = m.Nombre from CitaMedica c " +
                "inner join Medico m on c.ClaveMedico = m.Clave where c.ClaveCita ="+clave;

            lector = UsoBD.Consulta(strComando, con);
            if (lector.Equals(null)) return;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    txtClaveMedico.Text = lector.GetValue(1).ToString();
                    txtNombreMedico.Text = lector.GetValue(7).ToString();
                    txtFecha.Text = lector.GetValue(2).ToString();
                    txtHora.Text = lector.GetValue(3).ToString();
                    txtNombrePaciente.Text = lector.GetValue(4).ToString();
                    txtTelefonoPaciente.Text = lector.GetValue(5).ToString();
                    txtObservaciones.Text = lector.GetValue(6).ToString();
                }
            }
            con.Close();
        }
    }
}
