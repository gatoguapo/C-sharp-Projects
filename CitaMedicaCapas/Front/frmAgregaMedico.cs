using System;
using System.Data;
using System.Windows.Forms;
using ClinicaM.Entidades;
using ClinicaM.Negocio;

namespace ClinicaM.Front
{
    public partial class frmAgregaMedico : Form
    {
        DataTable dataConsultorios;
        public frmAgregaMedico()
        {
            InitializeComponent();
        }

        private void frmAgregaMedico_Load(object sender, EventArgs e)
        {
            try
            {
                dataConsultorios = NConsultorio.ObtenConsultorios();
                cmbConsultorio.DataSource = dataConsultorios;
                cmbConsultorio.DisplayMember = "CLAVE CONSULTORIO";
                cmbConsultorio.ValueMember = "CLAVE CONSULTORIO";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaClave()) return;
            if (!validaNombre()) return;
            if (!validaEspecialidad()) return;
            errorP.Clear();
            if (!validaTelefono()) return;

            string respuesta = "";
            int clave = Convert.ToInt32(txtClave.Text);
            string nombre = txtNombre.Text;
            string especialidad = cmbEspecialidad.SelectedItem.ToString();
            string subespecialidad = txtSubespecialidad.Text;
            string telefono = maskTTelefono.Text;
            int valorInt = cmbConsultorio.SelectedIndex;
            byte consultorio = Convert.ToByte(dataConsultorios.Rows[valorInt][0].ToString());
            Medico medico = new Medico(clave, nombre, especialidad, subespecialidad, telefono, consultorio);
            try
            {
                respuesta = NMedico.Agregar(medico);
                if (respuesta.Equals("Ya existe nombre"))
                {
                    MessageBox.Show("Ya existe ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (respuesta.Equals("Ya existe clave"))
                {
                    MessageBox.Show("Clave duplicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Medico agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void txtClave_Validated(object sender, EventArgs e)
        {
            validaClave();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(txtClave, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

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

        private void maskTTelefono_Validated(object sender, EventArgs e)
        {
            validaTelefono();
        }

        private void maskTTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(maskTTelefono, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtSubespecialidad_Validated(object sender, EventArgs e)
        {}

        private void txtSubespecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorP.SetError(txtSubespecialidad, "Solo puedes ingresar letras");
                e.Handled = true;
                return;
            }
        }

        private bool validaClave()
        {
            try
            {
                int clave = Convert.ToInt32(txtClave.Text);
                return true;
            }
            catch
            {
                errorP.SetError(txtClave, "No puedes dejar este espacio vacio");
                txtClave.Focus();
                return false;
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

        private bool validaTelefono()
        {
            string telefono = maskTTelefono.Text;
            if (string.IsNullOrWhiteSpace(telefono) || string.IsNullOrEmpty(telefono) || telefono.Length<12)
            {
                errorP.SetError(maskTTelefono, "Ingresa un numero valido");
                maskTTelefono.Focus();
                return false;
            }
            return true;
        }


        private bool validaEspecialidad()
        {
            try
            {
                string especialidad = cmbEspecialidad.SelectedItem.ToString();
                return true;
            }
            catch
            {
                errorP.SetError(cmbEspecialidad, "Debes seleccionar una de las opciones");
                return false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtNombre.Clear();
            maskTTelefono.Clear();
            txtSubespecialidad.Clear();
            cmbConsultorio.SelectedIndex = 0;
            cmbEspecialidad.SelectedIndex = 0;
        }

        
    }
}
