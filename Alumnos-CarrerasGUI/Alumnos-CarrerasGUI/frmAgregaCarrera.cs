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
    public partial class frmAgregaCarrera : Form
    {
        ManejaCarrera manejaCarrera;
        public frmAgregaCarrera(ManejaCarrera manejaCarrera)
        {
            InitializeComponent();
            this.manejaCarrera = manejaCarrera;
        }

        public bool ValidaNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(nombre))
            {
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            chkActiva.Checked = false;
            txtID.Text = "";
            txtNombreCarrera.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorP.SetError(txtID, "");
            errorP.SetError(txtNombreCarrera, "");
            char estatus = 'C';
            if (chkActiva.Checked)
            {
                estatus = 'A';
            }
            if(!ValidaCarrera())
            {
                errorP.SetError(txtID, "ERROR EN ID");
                return;
            }
            int id = Convert.ToInt32(txtID.Text);
            if (!manejaCarrera.ValidaIdDuplicado(id))
            {
                MessageBox.Show("ID DUPLICADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombre = txtNombreCarrera.Text.ToString();
            if (!ValidaNombre(nombre))
            {
                errorP.SetError(txtNombreCarrera, "ERROR EN NOMBRE");
                return;
            }
            manejaCarrera.AgregaCarrera(id,nombre,estatus);
            MessageBox.Show("AGREGADO EXITOSAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaCarreraTotal consultaCarreraTotal = new frmConsultaCarreraTotal(manejaCarrera);
            consultaCarreraTotal.ShowDialog();
        }

        private bool ValidaCarrera()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                return true;
            } catch
            {
                return false;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)
                && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorP.SetError(txtID, "ERROR ID SOLO PUEDE CONTENER NUMEROS");
                e.Handled = true;
            }
            else
            {
                errorP.SetError(txtID, "");
            }
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidaCarrera())
            {
                errorP.SetError(txtID, "ERROR EN ID VALIDATING");
                txtID.Focus();
            }
            else
            {
                errorP.SetError(txtID, "");
            }
        }

        private void txtNombreCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)
                && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorP.SetError(txtNombreCarrera, "Solo se permiten letras");
                e.Handled = true;
            }
            else
            {
                errorP.SetError(txtNombreCarrera, "");
            }
        }

        private void txtNombreCarrera_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNombreCarrera.Text.ToString();
            if (!ValidaNombre(nombre))
            {
                errorP.SetError(txtNombreCarrera, "ERROR EN NOMBRE VALIDATING");
                txtID.Focus();
            }
            else
            {
                errorP.SetError(txtNombreCarrera, "");
            }
        }

        private void txtNombreCarrera_Validated(object sender, EventArgs e)
        {
            string dato = txtNombreCarrera.Text;
            if (ValidaNombre(dato))
            {
                errorP.SetError(txtNombreCarrera, "");
            }
            else
            {
                errorP.SetError(txtNombreCarrera, "ERROR EN NOMBRE VALIDATED");
                txtNombreCarrera.Focus();
            }
        }
    }
}
