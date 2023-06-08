using ConE.Entidades;
using ConE.Negocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmAgregaMateria : Form
    {
        DataTable dataCarreras;

        public frmAgregaMateria()
        {
            InitializeComponent();
        }

        private void frmAgregaMateria_Load(object sender, EventArgs e)
        {
            cmbHora.SelectedIndex = 0;
            try
            {
                string clave = NMateria.ObtenerClaveMateria();
                txtClave.Text = clave;
                dataCarreras = NCarrera.ObtenCarreras();
                cmbCarrera.DataSource = dataCarreras;
                cmbCarrera.DisplayMember = "NOMBRE CARRERA";
                cmbCarrera.ValueMember = "NOMBRE CARRERA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaNombreMateria()) return;
            if (!validaNombreMaestro()) return;
            if (!validaAlumIns()) return;
            if (!validaMaxAlum()) return;
            if (!validaHora()) return;

            string respuesta = "";
            string nomMateria = txtNombre.Text;
            int valorInt = cmbCarrera.SelectedIndex;
            int carrera = Convert.ToInt32(dataCarreras.Rows[valorInt][0].ToString());
            int creditos = Convert.ToInt32(numCreditos.Value);
            string nomMaestro = txtNomMaestro.Text;
            string hora = cmbHora.SelectedItem.ToString();
            int maxAlum = Convert.ToInt32(txtMaxAlum.Text);
            int alumIns = Convert.ToInt32(txtAlumIns.Text);
            Materia materia = new Materia(nomMateria, carrera, creditos, nomMaestro, hora, alumIns, maxAlum);
            try
            {
                respuesta = NMateria.Agregar(materia);
                if (respuesta.Equals("Ya existe materia"))
                {
                    MessageBox.Show("Ya existe una materia registrada con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Materia agregada con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                string clave = NMateria.ObtenerClaveMateria();
                txtClave.Text = clave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtNomMaestro.Clear();
            cmbHora.SelectedIndex = 0;
            numCreditos.Value = 4;
            txtMaxAlum.Clear();
            txtAlumIns.Clear();
            cmbCarrera.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool validaNombreMateria()
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(nombre))
            {
                error.SetError(txtNombre, "No puedes dejar este espacio vacio");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private bool validaNombreMaestro()
        {
            string nombre = txtNomMaestro.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(nombre))
            {
                error.SetError(txtNomMaestro, "No puedes dejar este espacio vacio");
                txtNomMaestro.Focus();
                return false;
            }
            return true;
        }

        private bool validaHora()
        {
            if (cmbHora.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una hora primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool validaMaxAlum()
        {
            try
            {
                int maxAlumnos = Convert.ToInt32(txtMaxAlum.Text);
                if (maxAlumnos > 35)
                {
                    error.SetError(txtMaxAlum, "No se permite ingresar un maximo de alumnos mayor a 35");
                    return false;
                }
                return true;
            }
            catch
            {
                error.SetError(txtMaxAlum, "No puedes dejar este espacio vacio");
                return false;
            }
        }

        private bool validaAlumIns()
        {
            try
            {
                int alumIns = Convert.ToInt32(txtAlumIns.Text);
                string maxAlum = txtMaxAlum.Text;
                if (string.IsNullOrWhiteSpace(maxAlum) || string.IsNullOrEmpty(maxAlum))
                {
                    error.SetError(txtAlumIns, "Debes ingresar un maximo de alumnos primero");
                    return false;
                }

                if (alumIns > Convert.ToInt32(maxAlum))
                {
                    error.SetError(txtAlumIns, "El numero de alumnos inscritos no puede sobrepasar el maximo");
                    return false;
                }
                return true;
            }
            catch
            {
                error.SetError(txtAlumIns, "No puedes dejar este espacio vacio");
                return false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            validaNombreMateria();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !(char.IsWhiteSpace(e.KeyChar)))
            {
                error.SetError(txtNombre, "Solo puedes ingresar letras y espacios");
                e.Handled = true;
                return;
            }
        }

        private void txtNomMaestro_Validated(object sender, EventArgs e)
        {
            validaNombreMaestro();
        }

        private void txtNomMaestro_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !(char.IsWhiteSpace(e.KeyChar)))
            {
                error.SetError(txtNomMaestro, "Solo puedes ingresar letras y espacios");
                e.Handled = true;
                return;
            }
        }

        private void txtMaxAlum_Validated(object sender, EventArgs e)
        {
            validaMaxAlum();
        }

        private void txtMaxAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                error.SetError(txtMaxAlum, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtAlumIns_Validated(object sender, EventArgs e)
        {
            validaAlumIns();
        }

        private void txtAlumIns_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                error.SetError(txtAlumIns, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
