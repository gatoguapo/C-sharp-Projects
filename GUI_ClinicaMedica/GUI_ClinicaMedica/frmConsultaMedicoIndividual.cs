using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace GUI_ClinicaMedica
{
    public partial class frmConsultaMedicosIndv : Form
    {
        public frmConsultaMedicosIndv()
        {
            InitializeComponent();
        }

        private void frmConsultaMedica_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=DESKTOP-72TPBNU;Initial Catalog=ClinicaMedica;Integrated Security=True";
            SqlConnection con = UsoBD.ConectaBD(strCon);

            if (con.Equals(null))
            {
                MessageBox.Show("Imposible conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach(SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
                return;
            }

            SqlDataReader lector = null;
            string strComando = "select clave from Medico";

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
                cmbClave.Items.Clear();
                while (lector.Read())
                {
                    cmbClave.Items.Add(lector.GetValue(0).ToString());
                }
            }
            con.Close();
        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clave = cmbClave.SelectedItem.ToString();
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
            string strComando = "select * from Medico where clave ="+clave;

            lector = UsoBD.Consulta(strComando, con);
            if (lector.Equals(null)) return;
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    txtNombre.Text = lector.GetValue(1).ToString();
                    txtEspecialidad.Text = lector.GetValue(2).ToString();
                    txtSubespecialidad.Text = lector.GetValue(3).ToString();
                    txtTelefono.Text = lector.GetValue(4).ToString();
                    txtConsultorio.Text = lector.GetValue(5).ToString();
                }
            }
            con.Close();
        }
    }
}
