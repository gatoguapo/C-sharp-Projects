using System;
using System.Data;
using System.Windows.Forms;
using ConE.Negocio;
using ConE.Entidades;

namespace ConE.Front
{
    public partial class frmActualizaMateria : Form
    {
        DataTable data, data2;

        public frmActualizaMateria()
        {
            InitializeComponent();
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
        private void frmActualizaMateria_Load(object sender, EventArgs e)
        {
            CargarDatos();
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
        public bool validaCreditos()
        {
            if (txtCreditos.Text.Equals(""))
            {
                error.SetError(txtCreditos, "No puedes dejar este espacio vacio");
                txtCreditos.Focus();
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
        public void CargarDatos()
        {
            try
            {
                data = NMateria.ObtenMaterias();
                cmbClave.DataSource = data;
                cmbClave.DisplayMember = "CLAVE MATERIA";
                cmbClave.ValueMember = "CLAVE MATERIA";

                data2 = NCarrera.ObtenCarreras();
                cmbCarrera.DataSource = data2;
                cmbCarrera.DisplayMember = "NOMBRE CARRERA";
                cmbCarrera.ValueMember = "NOMBRE CARRERA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (!validaNombreMateria()) return;
            if (!validaNombreMaestro()) return;
            if (!validaCreditos()) return;
            if (!validaAlumIns()) return;
            if (!validaMaxAlum()) return;
            if (!validaHora()) return;
            string resp = "";

            int vInt = cmbClave.SelectedIndex;
            int claveMat = Convert.ToInt32(data.Rows[vInt][0].ToString());
            
            string nombre = txtNombre.Text;
            int vInt2 = cmbCarrera.SelectedIndex;
            int carrera = Convert.ToInt32(data2.Rows[vInt2][0].ToString());
            int creditos = Convert.ToInt32(txtCreditos.Text);
            string nombreMaestro = txtNomMaestro.Text;
            string hora = cmbHora.SelectedItem.ToString();
            int alumnosinscrito = Convert.ToInt32(txtAlumIns.Text);
            int maxAlumnos = Convert.ToInt32(txtMaxAlum.Text);


            Materia materia = new Materia(nombre, carrera, creditos, nombreMaestro, hora, alumnosinscrito, maxAlumnos);

            try
            {
                resp = NMateria.ActualizarMateria(claveMat, materia);
                if (resp.Equals("OK"))
                {
                    MessageBox.Show("Materia actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
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

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            validaNombreMateria();
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

        private void txtNomMaestro_Validated(object sender, EventArgs e)
        {
            validaNombreMaestro();
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

        private void txtMaxAlum_Validated(object sender, EventArgs e)
        {
            validaMaxAlum();
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

        private void txtAlumIns_Validated(object sender, EventArgs e)
        {
            validaAlumIns();
        }

        private void txtCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                error.SetError(txtCreditos, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbClave.SelectedIndex;
            txtNombre.Text = data.Rows[valorInt][1].ToString();
            cmbCarrera.Text = data.Rows[valorInt][3].ToString();
            txtNomMaestro.Text = data.Rows[valorInt][5].ToString();
            cmbHora.Text = data.Rows[valorInt][6].ToString();
            txtCreditos.Text = data.Rows[valorInt][4].ToString();
            txtMaxAlum.Text = data.Rows[valorInt][8].ToString();
            txtAlumIns.Text = data.Rows[valorInt][7].ToString();
        }
    }
}
