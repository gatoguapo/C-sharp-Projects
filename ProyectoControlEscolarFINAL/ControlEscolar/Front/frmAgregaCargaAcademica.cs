using ConE.Entidades;
using ConE.Negocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmAgregaCargaAcademica : Form
    {
        DataTable data, data2, data3, data4, data5, data6;

        private void cmbCveEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveEstudiante.SelectedIndex;
            txtAlumno.Text = data.Rows[valorInt][1].ToString();
            carreraId = Convert.ToInt32(data.Rows[valorInt][3].ToString());
            try
            {
                actualizaInterfaz();
                data2 = NMateria.BuscarMateriasPorCarrera(carreraId);
                cmbCveMateria1.DataSource = data2;
                cmbCveMateria1.DisplayMember = "CLAVE MATERIA";
                cmbCveMateria1.ValueMember = "CLAVE MATERIA";

                data3 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data3.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria2.Items.Add(clave);
                }

                data4 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data4.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria3.Items.Add(clave);
                }

                data5 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data5.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria4.Items.Add(clave);
                }


                data6 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data6.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria5.Items.Add(clave);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            if (!validaCmbs()) return;
            int cveEst = int.Parse(cmbCveEstudiante.Text);
            int cveMat1 = int.Parse(cmbCveMateria1.Text);
            int cveMat2 = int.Parse(cmbCveMateria2.Text);
            int cveMat3 = int.Parse(cmbCveMateria3.Text);
            int cveMat4 = int.Parse(cmbCveMateria4.Text);
            int cveMat5 = int.Parse(cmbCveMateria5.Text);
            try
            {
                CargaAcademica cargaAcademica = new CargaAcademica(cveEst, cveMat1, cveMat2, cveMat3, cveMat4, cveMat5);
                respuesta = NCargaAcademica.AgregaCargaAcademica(cargaAcademica);
                if (respuesta.Equals("Ya existe carga"))
                {
                    MessageBox.Show("Ya existe una carga academica para este alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Carga realizada con exito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        int carreraId;

        private void cmbCveMateria1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveMateria1.SelectedIndex;
            if (!valorInt.Equals(-1))
            {
                txtCveMateria1.Text = data2.Rows[valorInt][1].ToString();
            }
            else
            {
                txtCveMateria1.Text = "Seleccione";
            }
        }

        private void cmbCveMateria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveMateria2.SelectedIndex;
            if (!valorInt.Equals(0))
            {
                txtCveMateria2.Text = data3.Rows[valorInt - 1][1].ToString();
            }
            else
            {
                txtCveMateria2.Text = "NINGUNA";
            }
        }

        private void cmbCveMateria3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveMateria3.SelectedIndex;
            if (!valorInt.Equals(0))
            {
                txtCveMateria3.Text = data4.Rows[valorInt - 1][1].ToString();
            }
            else
            {
                txtCveMateria3.Text = "NINGUNA";
            }
        }

        private void cmbCveMateria4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveMateria4.SelectedIndex;
            if (!valorInt.Equals(0))
            {
                txtCveMateria4.Text = data5.Rows[valorInt - 1][1].ToString();
            }
            else
            {
                txtCveMateria4.Text = "NINGUNA";
            }
        }

        private void cmbCveMateria5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveMateria5.SelectedIndex;
            if (!valorInt.Equals(0))
            {
                txtCveMateria5.Text = data6.Rows[valorInt - 1][1].ToString();
            }
            else
            {
                txtCveMateria5.Text = "NINGUNA";
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public frmAgregaCargaAcademica()
        {
            InitializeComponent();
        }

        private void frmAgregaCargaAcademica_Load(object sender, EventArgs e)
        {
            try
            {
                data = NEstudiante.ObtenEstudiantesTotal();
                cmbCveEstudiante.DataSource = data;
                cmbCveEstudiante.DisplayMember = "CLAVE ESTUDIANTE";
                cmbCveEstudiante.ValueMember = "CLAVE ESTUDIANTE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                actualizaInterfaz();
                data2 = NMateria.BuscarMateriasPorCarrera(carreraId);
                cmbCveMateria1.DataSource = data2;
                cmbCveMateria1.DisplayMember = "CLAVE MATERIA";
                cmbCveMateria1.ValueMember = "CLAVE MATERIA";

                data3 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data3.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria2.Items.Add(clave);
                }

                data4 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data4.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria3.Items.Add(clave);
                }

                data5 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data5.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria4.Items.Add(clave);
                }

                data6 = NMateria.BuscarMateriasPorCarrera(carreraId);
                foreach (DataRow row in data6.Rows)
                {
                    string clave = row["CLAVE MATERIA"].ToString();
                    cmbCveMateria5.Items.Add(clave);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizaInterfaz()
        {
            cmbCveMateria1.DataSource = null;
            cmbCveMateria1.Items.Clear();
            cmbCveMateria2.DataSource = null;
            cmbCveMateria2.Items.Clear();
            cmbCveMateria2.Items.Add(0);
            cmbCveMateria3.DataSource = null;
            cmbCveMateria3.Items.Clear();
            cmbCveMateria3.Items.Add(0);
            cmbCveMateria4.DataSource = null;
            cmbCveMateria4.Items.Clear();
            cmbCveMateria4.Items.Add(0);
            cmbCveMateria5.DataSource = null;
            cmbCveMateria5.Items.Clear();
            cmbCveMateria5.Items.Add(0);
            txtCveMateria1.Clear();
            txtCveMateria2.Clear();
            txtCveMateria3.Clear();
            txtCveMateria4.Clear();
            txtCveMateria5.Clear();
        }
        private bool validaCmbs()
        {
            try
            {
                int cveEst = int.Parse(cmbCveEstudiante.Text);
                int cveMat1 = int.Parse(cmbCveMateria1.Text);
                int cveMat2 = int.Parse(cmbCveMateria2.Text);
                int cveMat3 = int.Parse(cmbCveMateria3.Text);
                int cveMat4 = int.Parse(cmbCveMateria4.Text);
                int cveMat5 = int.Parse(cmbCveMateria5.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("No puedes dejar ningun combo vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void limpiar()
        {
            cmbCveEstudiante.SelectedIndex = 0;
            cmbCveMateria1.SelectedIndex = 0;
            cmbCveMateria2.SelectedIndex = 0;
            cmbCveMateria3.SelectedIndex = 0;
            cmbCveMateria4.SelectedIndex = 0;
            cmbCveMateria5.SelectedIndex = 0;
        }
    }
}
