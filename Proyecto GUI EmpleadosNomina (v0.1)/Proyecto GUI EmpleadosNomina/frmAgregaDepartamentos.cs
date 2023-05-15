using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_GUI_EmpleadosNomina
{
    public partial class frmAgregaDepartamentos : Form
    {
        ManejaDepartamentos maneja;
        public frmAgregaDepartamentos(ManejaDepartamentos maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }


        private void AgregaDepartamentos_Load(object sender, EventArgs e)
        {
            rbActivo.Checked = true; //<= Estatus activo por defecto.
        }

        private void Limpiar()
        {
            txtClaveDep.Clear();
            txtNombreDep.Clear();
            txtNombreJefe.Clear();
            rbActivo.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int clave;
            string nombreDep = txtNombreDep.Text;
            string nombreJefe = txtNombreJefe.Text;
            string estatus = rbActivo.Text;

            if (!validaClave()) return;
            clave = Int32.Parse(txtClaveDep.Text);
            if (!validaNombreDep()) return;
            if (!validaNombreJefe()) return;
            if (rbBaja.Checked)
            {
                estatus = rbBaja.Text;
            }
            if (maneja.buscaClave(clave))
            {
                MessageBox.Show("Clave duplicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClaveDep.Focus();
                return;
            }
            if (maneja.buscaNombreDep(nombreDep))
            {
                MessageBox.Show("Nombre de departamento duplicado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreDep.Focus();
                return;
            }
            //DialogResult guarda la opcion seleccionada en el message box.
            DialogResult agrega = MessageBox.Show("¿Deseas Agregar el Departamento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (agrega == DialogResult.Yes) //Si selecciona "Yes" se agrega el departamento.
            {
                MessageBox.Show("Departamento Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maneja.agregaDepartamento(clave, nombreDep, nombreJefe, estatus);
                Limpiar();
            }
            else //Si selecciona "No" no se agrega.
            {
                MessageBox.Show("Departamento No Agregado", "No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

        }

        //Valida que la clave no este vacia.
        private void txtClaveDep_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            try
            {
                int clave = Int32.Parse(txtClaveDep.Text);
                errorP.SetError(txtClaveDep, "");
            }
            catch
            {
                errorP.SetError(txtClaveDep, "No puedes dejar vacio este espacio");
                txtClaveDep.Focus();
            }
        }

        //Valida que el nombre del departamento no este vacio.
        private void txtNombreDep_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            string nombre = txtNombreDep.Text;
            if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrEmpty(nombre))
            {
                errorP.SetError(txtNombreDep, "No puedes dejar vacio este espacio");
                txtNombreDep.Focus();
            }
        }

        //Valida que el nombre del jefe no este vacio.
        private void txtNombreJefe_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            string nombre = txtNombreJefe.Text;
            if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrEmpty(nombre))
            {
                errorP.SetError(txtNombreJefe, "No puedes dejar vacio este espacio");
                txtNombreJefe.Focus();
            }
        }

        //Valida que la clave solo contenga numeros.
        private void txtClaveDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if(!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(txtClaveDep, "Solo se permiten numeros");
                e.Handled = true;
            }
        }

        //Valida que el nombre del departamento solo contenga letras y espacios.
        private void txtNombreDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                errorP.SetError(txtNombreDep, "Solo se permiten letras y espacios en el nombre del departamento");
                e.Handled = true;
            }
        }

        //Valida que el nombre del jefe solo contenga letras y espacios.
        private void txtNombreJefe_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                errorP.SetError(txtNombreJefe, "Solo se permiten letras y espacios en el nombre del jefe");
                e.Handled = true;
            }
        }

        private bool validaClave()
        {
            errorP.Clear();
            try
            {
                int clave = int.Parse(txtClaveDep.Text);
                return true;
            } 
            catch
            {
                errorP.SetError(txtClaveDep, "No puedes dejar este campo vacio");
                return false;
            }
        }

        private bool validaNombreDep()
        {
            errorP.Clear();
            string nombreDep = txtNombreDep.Text;
            if (string.IsNullOrWhiteSpace(nombreDep) || string.IsNullOrEmpty(nombreDep))
            {
                errorP.SetError(txtNombreDep, "No puedes dejar este campo vacio");
                return false;
            }
            return true;
        }

        private bool validaNombreJefe()
        {
            errorP.Clear();
            string nombreJefe = txtNombreJefe.Text;
            if (string.IsNullOrWhiteSpace(nombreJefe) || string.IsNullOrEmpty(nombreJefe))
            {
                errorP.SetError(txtNombreJefe, "No puedes dejar este campo vacio");
                return false;
            }
            return true;
        }
    }
}
