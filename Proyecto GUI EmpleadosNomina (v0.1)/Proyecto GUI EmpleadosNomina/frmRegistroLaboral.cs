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
    public partial class frmRegistroLaboral : Form
    {
        ManejaRegistroLaboral manejaReg;
        ManejaEmpleados manejaEmp;
        public frmRegistroLaboral(ManejaRegistroLaboral manejaReg, ManejaEmpleados manejaEmp)
        {
            InitializeComponent();
            this.manejaReg = manejaReg;
            this.manejaEmp = manejaEmp;
        }

        private void frmRegistroLaboral_Load(object sender, EventArgs e)
        {
            List<Empleado> listEmp = manejaEmp.getListEmpleados();
            listEmp.ForEach(emp => cmbClaves.Items.Add(emp.pClave));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaCMB()) return;
            if (!validaDiasLaborados()) return;
            if (!validaHorasExtra()) return;
            if (!validaFaltas()) return;

            int claveEmp = Convert.ToInt32(cmbClaves.SelectedItem);
            int diasLab = Convert.ToInt32(txtDiasLaborados.Text);
            int horasExt = Convert.ToInt32(txtHorasExtras.Text);
            int faltas = Convert.ToInt32(txtFaltas.Text);

            if (horasExt > 10)
            {
                errorP.SetError(txtHorasExtras, "No se puede exceder las 10 horas extras trabajadas");
                txtHorasExtras.Focus();
                return;
            }
            else
            {
                errorP.Clear();
            }

            if (manejaReg.claveDuplicada(claveEmp))
            {
                DialogResult agregaDup = MessageBox.Show($"Ya existe un registro con esta clave de empleado\n¿Deseas borrar el registro que ya existe y guardar este?", "Clave Duplicada", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (agregaDup == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    manejaReg.borraRegistro(claveEmp);
                    manejaReg.agregaRegistroLaboral(claveEmp, diasLab, horasExt, faltas);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Registro No Agregado", "No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                return;
            }

            //DialogResult guarda la opcion seleccionada en el message box.
            DialogResult agrega = MessageBox.Show("¿Deseas Agregar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (agrega == DialogResult.Yes) //Si selecciona "Yes" se agrega el registro.
            {
                MessageBox.Show("Registro Agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manejaReg.agregaRegistroLaboral(claveEmp, diasLab, horasExt, faltas);
                Limpiar();
            }
            else //Si selecciona "No" no se agrega.
            {
                MessageBox.Show("Registro No Agregado", "No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            cmbClaves.SelectedIndex = -1;
            txtDiasLaborados.Clear();
            txtHorasExtras.Clear();
            txtFaltas.Clear();
        }

        //Valida que los dias laborados no esten vacios.
        private void txtDiasLaborados_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            try
            {
                int diasLab = Convert.ToInt32(txtDiasLaborados.Text);
            }
            catch
            {
                errorP.SetError(txtDiasLaborados, "No puedes dejar este espacio vacio");
                txtDiasLaborados.Focus();
            }
        }

        //Valida que los dias laborados solo contenga numeros.
        private void txtDiasLaborados_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if(!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(txtDiasLaborados, "Solo puedes ingresar valores numericos");
                e.Handled = true;
            }
        }

        //Valida que las horas extras no esten vacias.
        private void txtHorasExtras_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            try
            {
                int horasEx = Convert.ToInt32(txtHorasExtras.Text);
            }
            catch
            {
                errorP.SetError(txtHorasExtras, "No puedes dejar este espacio vacio");
                txtHorasExtras.Focus();
            }
        }

        //Valida que las horas extras solo contenga numeros.
        private void txtHorasExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if(!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(txtHorasExtras, "Solo puedes ingresar valores numericos");
                e.Handled = true;
            }
        }

        private void txtHorasExtras_Validating(object sender, CancelEventArgs e)
        {
            if (!validaHorasExtra()) return;
            int horasEx = Convert.ToInt32(txtHorasExtras.Text);
           
        }

        //Valida que las faltas no esten vacias.
        private void txtFaltas_Validated(object sender, EventArgs e)
        {
            errorP.Clear();
            try
            {
                int faltas = Convert.ToInt32(txtFaltas.Text);
            }
            catch
            {
                errorP.SetError(txtFaltas, "No puedes dejar este espacio vacio");
                txtFaltas.Focus();
            }
        }

        //Valida que las faltas solo contengan numeros.
        private void txtFaltas_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(txtFaltas, "Solo puedes ingresar valores numericos");
                e.Handled = true;
            }
        }

        private bool validaDiasLaborados()
        {
            errorP.Clear();
            try
            {
                int diasLab = Int32.Parse(txtDiasLaborados.Text);
                return true;
            }
            catch
            {
                errorP.SetError(txtDiasLaborados, "No puedes dejar este campo vacio");
                return false;
            }
        }

        private bool validaHorasExtra()
        {
            errorP.Clear();
            try
            {
                int horasEx = Int32.Parse(txtHorasExtras.Text);
                return true;
            }
            catch
            {
                errorP.SetError(txtHorasExtras, "No puedes dejar este campo vacio");
                return false;
            }
        }

        private bool validaFaltas()
        {
            errorP.Clear();
            try
            {
                int faltas = Int32.Parse(txtFaltas.Text);
                return true;
            }
            catch
            {
                errorP.SetError(txtFaltas, "No puedes dejar este campo vacio");
                return false;
            }
        }

        private bool validaCMB()
        {
            if (cmbClaves.SelectedItem == null)
            {
                MessageBox.Show("Debes ingresar un empleado primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        
    }
}
