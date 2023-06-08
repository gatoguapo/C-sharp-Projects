using System;
using System.Data;
using System.Windows.Forms;
using ConE.Negocio;
using ConE.Entidades;

namespace ConE.Front
{
    public partial class frmActualizaEstudiante : Form
    {
        DataTable data, data2;

        public frmActualizaEstudiante()
        {
            InitializeComponent();
        }
        private bool validaCarrera()
        {
            try
            {
                string carrera = cmbCarrera.SelectedItem.ToString();
                return true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar una carrera primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool validaTelefono()
        {
            string telefono = mtxtTelefono.Text;
            if (string.IsNullOrWhiteSpace(telefono) || string.IsNullOrEmpty(telefono) || telefono.Length < 12)
            {
                error.SetError(mtxtTelefono, "Ingresa un numero valido");
                mtxtTelefono.Focus();
                return false;
            }
            return true;
        }
        private bool validaCorreo()
        {
            string correo = txtCorreoElectronico.Text;
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrEmpty(correo))
            {
                error.SetError(txtCorreoElectronico, "No puedes dejar este espacio vacio");
                txtCorreoElectronico.Focus();
                return false;
            }
            return true;
        }

        private bool validaDomicilio()
        {
            string domicilio = txtDomicilio.Text;
            if (string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrEmpty(domicilio))
            {
                error.SetError(txtDomicilio, "No puedes dejar este espacio vacio");
                txtDomicilio.Focus();
                return false;
            }
            return true;
        }
        private bool validaNombre()
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
        private void frmActualizaEstudiante_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                data = NCarrera.ObtenCarreras();
                cmbCarrera.DataSource = data;
                cmbCarrera.DisplayMember = "NOMBRE CARRERA";
                cmbCarrera.ValueMember = "NOMBRE CARRERA";

                data2 = NEstudiante.ObtenEstudiante();
                cmbClaveEst.DataSource = data2;
                cmbClaveEst.DisplayMember = "CLAVE ESTUDIANTE";
                cmbClaveEst.ValueMember = "CLAVE ESTUDIANTE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            if (!validaCarrera()) return;
            if (!validaNombre()) return;
            if (!validaDomicilio()) return;
            if (!validaCorreo()) return;
            if (!validaTelefono()) return;
            string resp = "";
            int vInt = cmbClaveEst.SelectedIndex;
            int claveEst = Convert.ToInt32(data2.Rows[vInt][0].ToString());
            string nombre = txtNombre.Text;
            decimal semestre = Convert.ToDecimal(txtSemestre.Text);
            int vInt2 = cmbCarrera.SelectedIndex;
            int carrera = Convert.ToInt32(data.Rows[vInt2][0].ToString());
            string domicilio = txtDomicilio.Text;
            string correo = txtCorreoElectronico.Text;
            string telefono = mtxtTelefono.Text;

            Estudiante estudiante = new Estudiante(nombre,semestre, carrera, domicilio, correo, telefono);

            try
            {
                resp = NEstudiante.ActualizaEstudiante(claveEst, estudiante);
                if (resp.Equals("OK"))
                {
                    MessageBox.Show("Estudiante actualizado exitosamente");
                    CargarDatos();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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
            validaNombre();
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != ',')
            {
                error.SetError(txtDomicilio, "No puedes ingresar caracteres especiales, solo letras, numeros, comas y '#'");
                e.Handled = true;
                return;
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            validaDomicilio();
        }

        private void txtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (e.KeyChar == (char)Keys.Space)
            {
                error.SetError(txtCorreoElectronico, "No puedes ingresar espacios en el correo electronico");
                e.Handled = true;
                return;
            }
        }

        private void txtCorreoElectronico_Validated(object sender, EventArgs e)
        {
            validaCorreo();
        }

        private void mtxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                error.SetError(mtxtTelefono, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void mtxtTelefono_Validated(object sender, EventArgs e)
        {
            validaTelefono();
        }

        private void cmbClaveEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valorInt = cmbClaveEst.SelectedIndex;
            txtNombre.Text = data2.Rows[valorInt][1].ToString();
            txtDomicilio.Text = data2.Rows[valorInt][10].ToString();
            txtCorreoElectronico.Text = data2.Rows[valorInt][11].ToString();
            mtxtTelefono.Text = data2.Rows[valorInt][12].ToString();
            txtSemestre.Text = data2.Rows[valorInt][2].ToString();
        }
    }
}
