using System;
using System.Windows.Forms;
using ClinicaM.Entidades;
using ClinicaM.Negocio;

namespace ClinicaM.Front
{
    public partial class frmAgregaConsultorios : Form
    {
        public frmAgregaConsultorios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaNombre()) return;
            if (!validaDomicilio()) return;

            string respuesta = "";
            int idConsultorio = Convert.ToInt32(numConsultorioID.Value);
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;
            Consultorio consultorio = new Consultorio(idConsultorio, nombre, domicilio);
            try
            {
                respuesta = NConsultorio.Agregar(consultorio);
                if (respuesta.Equals("Ya existe clave consultorio"))
                {
                    MessageBox.Show("Ya existe esa clave de consultorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (respuesta.Equals("Ya existe nombre consultorio"))
                {
                    MessageBox.Show("Ya existe ese nombre de consultorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Consultorio agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            numConsultorioID.Value = 1;
            txtNombre.Clear();
            txtDomicilio.Clear();
        }

        private void numConsultorioID_Validated(object sender, EventArgs e)
        {}

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            validaNombre();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorP.SetError(txtNombre, "Solo puedes ingresar letras y espacios");
                e.Handled = true;
                return;
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            validaDomicilio();
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != ',')
            {
                errorP.SetError(txtDomicilio, "No puedes ingresar caracteres especiales, solo letras, numeros, comas y '#'");
                e.Handled = true;
                return;
            }
        }

        private bool validaNombre()
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(nombre))
            {
                errorP.SetError(txtNombre, "No puedes dejar este espacio vacio");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private bool validaDomicilio()
        {
            string domicilio = txtDomicilio.Text;
            if (string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrEmpty(domicilio))
            {
                errorP.SetError(txtDomicilio, "No puedes dejar este espacio vacio");
                txtDomicilio.Focus();
                return false;
            }
            return true;
        }
    }
}
