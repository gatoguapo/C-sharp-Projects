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
    public partial class frmAgregaEmpleados : Form
    {
        ManejaEmpleados manejaEmp;
        ManejaDepartamentos manejaDep;

        public frmAgregaEmpleados(ManejaEmpleados manejaEmp, ManejaDepartamentos manejaDep)
        {
            InitializeComponent();
            this.manejaEmp = manejaEmp;
            this.manejaDep = manejaDep;
        }

        private void frmAgregaEmpleados_Load(object sender, EventArgs e)
        {
            List<Empleado> listEmp = manejaEmp.getListEmpleados();
            //Esta parte del codigo actualiza el txtClaveEmp para que se muestre la clave actual.
            if (listEmp.Count.Equals(0))
            {
                txtClaveEmp.Text = "20230000"; //<= Clave generada por defecto.
            }
            else 
            {
                txtClaveEmp.Text = Convert.ToString(listEmp.Last().pClave+2); //En caso de que ya exista una, regresa el valor de la ultima clave registrada + 2.
            }
            rbMasculino.Checked = true; // <= Selecciona el rbMasculino por defecto.
            List<Departamento> listDep = manejaDep.getDepartamentosActivos();
            listDep.ForEach(clave => cmbClaveDepto.Items.Add(clave.pClaveDepto ));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int clave = manejaEmp.generaClave();
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string domicilio = txtDomicilio.Text;
            string sexo = rbMasculino.Text;
            int edad = Convert.ToInt32(numEdad.Value);
            int cveDepto = Convert.ToInt32(cmbClaveDepto.SelectedItem);
            double sueldo;

            if (rbFemenino.Checked)
            {
                sexo = rbFemenino.Text;
            }
            if (rbNoBinario.Checked)
            {
                sexo = rbNoBinario.Text;
            }
            if (!validaNombres()) return;
            if (!validaApellidos()) return;
            if (!validaDomicilio()) return;
            if (!validaCMB()) return;
            if (!validaSueldoVacio()) return;

            sueldo = Double.Parse(txtSueldo.Text);

            //DialogResult guarda la opcion seleccionada en el message box.
            DialogResult agrega = MessageBox.Show("¿Deseas Agregar al Empleado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (agrega == DialogResult.Yes) //Si selecciona "Yes" se agrega el empleado.
            {
                MessageBox.Show("Empleado Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manejaEmp.agregaEmpleado(clave, nombres, apellidos, domicilio, sexo, edad, cveDepto, sueldo);
                txtClaveEmp.Text = Convert.ToString(clave+2); //Esta parte del codigo actualiza el txtClaveEmp para que se muestre la clave actual.
                Limpiar();
            }
            else //Si selecciona "No" no se agrega.
            {
                MessageBox.Show("Empleado No Agregado", "No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Valida que el nombre no este vacio.
        private void txtNombres_Validated(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrEmpty(nombres))
            {
                errorP.SetError(txtNombres, "No puedes dejar vacio este espacio");
                txtNombres.Focus();
            }
            else
            {
                errorP.SetError(txtNombres, "");
            }
        }

        //Valida que el apellido no este vacio.
        private void txtApellidos_Validated(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            if (string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrEmpty(apellidos))
            {
                errorP.SetError(txtApellidos, "No puedes dejar vacio este espacio");
                txtApellidos.Focus();
            }
            else
            {
                errorP.SetError(txtApellidos, "");
            }
        }

        //Valida que el domicilio no este vacio.
        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            string domicilio = txtDomicilio.Text;
            if (string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrEmpty(domicilio))
            {
                errorP.SetError(txtDomicilio, "No puedes dejar vacio este espacio");
                txtDomicilio.Focus();
            }
        }

        //Valida que el sueldo no este vacio.
        private void txtSueldo_Validated(object sender, EventArgs e)
        {
            try
            {
                double sueldo = double.Parse(txtSueldo.Text);
                errorP.Clear();
            }
            catch
            {
                errorP.SetError(txtSueldo, "No puedes dejar vacio este espacio");
                txtSueldo.Focus();
            }
        }

        //Valida que el nombre solo contenga letras y espacios.
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                errorP.SetError(txtNombres, "Solo se permiten letras y espacios en los nombres");
                e.Handled = true;
            } 
        }

        //Valida que el apellido solo contenga letras y espacios.
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                errorP.SetError(txtApellidos, "Solo se permiten letras y espacios en los apellidos");
                e.Handled = true;
            }
        }

        //Valida que el nombre solo contenga letras, espacios y numeros.
        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                errorP.SetError(txtDomicilio, "No se permiten caracteres especiales");
                e.Handled = true;
            }
        }

        //Valida que el sueldo solo contenga numeros y un punto o coma.
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != ',')
            {
                errorP.SetError(txtSueldo, "Solo se permiten numeros decimales");
                e.Handled = true;
            }

            //El '(sender as TextBox)' nos permite convertir el objeto sender a TextBox para asi poder utilizar sus propiedades y metodos.
            if ((e.KeyChar == '0') && (sender as TextBox).SelectionStart == 0) //<= Con esto validaremos que no pueda capturar un saldo de 0.
            {
                errorP.SetError(txtSueldo, $"No se permite ingresar saldo de cero");
                e.Handled = true;
            }

            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            { 
                if ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1) //<= Con esto validaremos que solo pueda introducir un "." o ",".
                {
                    errorP.SetError(txtSueldo, $"Solo se permite un {"."} o {","} ");
                    e.Handled = true;
                }
            }
        }

        private void Limpiar()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDomicilio.Clear();
            txtSueldo.Clear();
            rbMasculino.Checked = true;
            numEdad.Value = 21;
            cmbClaveDepto.SelectedIndex = -1;
        }

        private bool validaSueldoVacio()
        {
            errorP.Clear();
            try
            {
                double sueldo = Double.Parse(txtSueldo.Text);
                return true;
            }
            catch
            {
                errorP.SetError(txtSueldo, "Debes ingresar un sueldo valido");
                return false;
            }
        }

        private bool validaCMB()
        {
            if (cmbClaveDepto.SelectedItem == (null))
            {
                MessageBox.Show("Debes ingresar una carrera primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool validaNombres()
        {
            errorP.Clear();
            string nombres = txtNombres.Text;
            if (string.IsNullOrWhiteSpace(nombres) || string.IsNullOrEmpty(nombres))
            {
                errorP.SetError(txtNombres, "No puedes dejar este campo vacio");
                return false;
            }
            return true;
        }

        private bool validaApellidos()
        {
            errorP.Clear();
            string apellidos = txtApellidos.Text;
            if (string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrEmpty(apellidos))
            {
                errorP.SetError(txtApellidos, "No puedes dejar este campo vacio");
                return false;
            }
            return true;
        }

        private bool validaDomicilio()
        {
            errorP.Clear();
            string domicilio = txtDomicilio.Text;
            if (string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrEmpty(domicilio))
            {
                errorP.SetError(txtDomicilio, "No puedes dejar este campo vacio");
                return false;
            }
            return true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaEmpTodos consultaEmpTodos = new frmConsultaEmpTodos(manejaEmp);
            consultaEmpTodos.ShowDialog();
        }
    }
}
