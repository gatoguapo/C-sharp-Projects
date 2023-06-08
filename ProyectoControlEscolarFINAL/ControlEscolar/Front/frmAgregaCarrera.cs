using ConE.Entidades;
using ConE.Negocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmAgregaCarrera : Form
    {
        public frmAgregaCarrera()
        {
            InitializeComponent();
        }

        private void frmAgregaCarrera_Load(object sender, EventArgs e)
        {
            string clave = NCarrera.ObtenerClaveCarrera();
            txtClave.Text = clave;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaNombre()) return;
            if (!validaFecha()) return;
            error.Clear();

            string respuesta = "";
            string nombre = txtNombre.Text;
            string fecha = mktFecha.Text.ToString();
            Carrera carrera = new Carrera(nombre, fecha);
            try
            {
                respuesta = NCarrera.Agregar(carrera);
                if (respuesta.Equals("Ya existe carrera"))
                {
                    MessageBox.Show("Ya existe una carrera con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Carrera agregada con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                string clave = NCarrera.ObtenerClaveCarrera();
                txtClave.Text = clave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            txtNombre.Clear();
            mktFecha.Clear();
        }

        private bool validaFecha()
        {
            string fecha = mktFecha.Text;
            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrEmpty(fecha) || fecha.Length < 10)
            {
                error.SetError(mktFecha, "Ingresa una fecha valida");
                mktFecha.Focus();
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

        private void mktFecha_Validated(object sender, EventArgs e)
        {
            validaFecha();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
