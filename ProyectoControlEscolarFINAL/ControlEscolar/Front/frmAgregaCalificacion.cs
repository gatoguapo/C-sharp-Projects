using System;
using System.Data;
using System.Windows.Forms;
using ConE.Negocio;
using ConE.Entidades;
using System.Data.SqlClient;

namespace ConE.Front
{
    public partial class frmAgregaCalificacion : Form
    {
        DataTable dataAlumnos, dataMateria;
        int carreraId;

        public frmAgregaCalificacion()
        {
            InitializeComponent();
        }

        private void cmbCveMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveMateria.SelectedIndex;
            txtMateria.Text = dataMateria.Rows[valorInt][1].ToString();
        }

        private void frmAgregaCalificacion_Load(object sender, EventArgs e)
        {
            try
            {
                dataAlumnos = NEstudiante.ObtenEstudiantesTotal();
                cmbCveEstudiante.DataSource = dataAlumnos;
                cmbCveEstudiante.DisplayMember = "CLAVE ESTUDIANTE";
                cmbCveEstudiante.ValueMember = "CLAVE ESTUDIANTE";
                dataMateria = NMateria.BuscarMateriasPorCarrera(carreraId);
                cmbCveMateria.DataSource = dataMateria;
                cmbCveMateria.DisplayMember = "CLAVE MATERIA";
                cmbCveMateria.ValueMember = "CLAVE MATERIA";
                int valorInt = cmbCveMateria.SelectedIndex;
                cmbCveMateria.Text = dataMateria.Rows[valorInt][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                error.SetError(txtCalificacion, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaCalif()) return;
            string respuesta = "";
            int cveEst = Convert.ToInt32(cmbCveEstudiante.Text);
            int cveMateria = Convert.ToInt32(cmbCveMateria.Text);
            int cal = Convert.ToInt32(txtCalificacion.Text);
            try
            {
                Calificacion calificacion = new Calificacion(cveEst, cveMateria, cal);
                respuesta = NCalificacion.Agregar(calificacion);
                if (respuesta.Equals("Ya existe calificacion"))
                {
                    MessageBox.Show("Ya existe una calificacion para esta materia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Calificacion agregada con exito", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void limpiar()
        {
            txtCalificacion.Clear();
            cmbCveEstudiante.SelectedIndex = 0;
            cmbCveMateria.SelectedIndex = 0;
        }

        private void cmbCveEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbCveEstudiante.SelectedIndex;
            carreraId = Convert.ToInt32(dataAlumnos.Rows[valorInt][3].ToString());
            txtEstudiante.Text = dataAlumnos.Rows[valorInt][1].ToString();
            try
            {
                dataMateria = NMateria.BuscarMateriasPorCarrera(carreraId);
                cmbCveMateria.DataSource = dataMateria;
                cmbCveMateria.DisplayMember = "CLAVE MATERIA";
                cmbCveMateria.ValueMember = "CLAVE MATERIA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }

        private void txtCalificacion_Validated(object sender, EventArgs e)
        {
            validaCalif();
        }

        private bool validaCalif()
        {
            try
            {
                int cal = Convert.ToInt32(txtCalificacion.Text);
                if (cal < 0 || cal > 100)
                {
                    error.SetError(txtCalificacion, "La calificacion debe ser un numero entre 0 y 100");
                    return false;
                }
                return true;
            }
            catch
            {
                error.SetError(txtCalificacion, "Ingresa un numero valido");
                return false;
            }
        }

    }
}
