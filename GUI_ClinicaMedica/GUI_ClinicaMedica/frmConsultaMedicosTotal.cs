using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace GUI_ClinicaMedica
{
    public partial class frmConsultaMedicosTotal : Form
    {
        public frmConsultaMedicosTotal()
        {
            InitializeComponent();
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
            string strComando = "select * from Medico";

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
                while (lector.Read())
                {
                    dgvMedicos.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(),
                        lector.GetValue(4).ToString(), lector.GetValue(5).ToString());
                }
            }
            con.Close();
        }
    }
}
