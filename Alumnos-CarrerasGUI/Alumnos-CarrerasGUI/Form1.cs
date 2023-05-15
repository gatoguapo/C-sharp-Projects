using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos_CarrerasGUI
{
    public partial class frmAlumnos : Form
    {
        private ManejaAlumno manejaAlumno;
        private ManejaCarrera manejaCarrera;
        public frmAlumnos(ManejaAlumno manejaAlumno, ManejaCarrera manejaCarrera)
        {
            InitializeComponent();
            this.manejaAlumno = manejaAlumno;
            this.manejaCarrera = manejaCarrera;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            txtNControl.Text = manejaAlumno.CalculaNumero().ToString();
            AgregaCarrerasCMB();
        }

        private bool ValidaVacio(string nombre)
        {
            if (nombre.Length == 0 || nombre.StartsWith(" "))
            {
                return false;
            }
            return true;
        }

        private bool ValidaCarreraVacia()
        {
            try
            {
                string carrera = cmbCarrera.SelectedItem.ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorp.SetError(cmbCarrera, "");
            errorp.SetError(txtNombre, "");
            errorp.SetError(txtDomicilio, "");
            if (!ValidaCarreraVacia())
            {
                errorp.SetError(cmbCarrera, "CARRERA VACIA");
                return;
            }
            string carrera = cmbCarrera.SelectedItem.ToString();
            int edad = Convert.ToInt32(numEdad.Value);
            long nCon = long.Parse(txtNControl.Text);
            string sexo;
            if (rbFemenino.Checked)
            {
                sexo = rbFemenino.Text.ToString();
            }
            else
            {
                sexo = rbMasculino.Text.ToString();
            }
            string nombre = txtNombre.Text.ToString();
            if (!ValidaVacio(nombre))
            {
                errorp.SetError(txtNombre, "NOMBRE INVALIDO");
                return;
            }
            if (manejaAlumno.BuscarNombreAlum(nombre))
            {
                errorp.SetError(txtNombre, "EL NOMBRE YA EXISTE");
                return;
            }
            string domicilio = txtDomicilio.Text.ToString();
            if (!ValidaVacio(domicilio))
            {
                errorp.SetError(txtDomicilio, "ERROR EN DOMICILIO");
                txtNombre.Focus();
                return;
            }
            
            manejaAlumno.AgregaAlumno(nCon, nombre, domicilio, edad, carrera, sexo);
            MessageBox.Show("AGREGADO EXITOSO", "AGREGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNControl.Text = manejaAlumno.CalculaNumero().ToString();
            Limpiar();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDomicilio.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaAlumnos frmConsulta = new frmConsultaAlumnos(manejaAlumno);
            frmConsulta.ShowDialog();
        }

        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
            frmAgregaCarrera agregarCarrera = new frmAgregaCarrera(manejaCarrera);
            agregarCarrera.ShowDialog();
            AgregaCarrerasCMB();
        }

        public void AgregaCarrerasCMB()
        {
            string[] arregloCarreras = manejaCarrera.getCarreras();
            cmbCarrera.DataSource = arregloCarreras;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)
                && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorp.SetError(txtNombre, "ERROR NOMBRE SOLO PUEDE CONTENER LETRAS");
                e.Handled = true;
            }
            else
            {
                errorp.SetError(txtNombre, "");
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)
               && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorp.SetError(txtDomicilio, "ERROR DOMICILIO SOLO PUEDE CONTENER LETRAS Y NUMEROS");
                e.Handled = true;
            }
            else
            {
                errorp.SetError(txtDomicilio, "");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string dato = txtNombre.Text;
            if (ValidaVacio(dato))
            {
                errorp.SetError(txtNombre, "");
            }
            else
            {
                errorp.SetError(txtNombre, "ERROR EN NOMBRE VALIDATED");
                txtNombre.Focus();
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            string dato = txtDomicilio.Text;
            if (ValidaVacio(dato))
            {
                errorp.SetError(txtDomicilio, "");
            }
            else
            {
                errorp.SetError(txtDomicilio, "ERROR EN DOMICILIO VALIDATED");
                txtDomicilio.Focus();
            }
        }
    }
}
