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
    public partial class frmConsultaEmpIndv : Form
    {
        ManejaEmpleados maneja;
        public frmConsultaEmpIndv(ManejaEmpleados maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaEmpIndv_Load(object sender, EventArgs e)
        {
            List<Empleado> listaEmp = maneja.getListEmpleados();
            listaEmp.ForEach(emp => cmbClaveEmp.Items.Add(emp.pClave)); //<= Recorremos la listaEmp y agregamos en el cmb las claves de los empleados registrados.
        }

        private void cmbClaveEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clave = int.Parse(cmbClaveEmp.SelectedItem.ToString());
            Empleado consulta = maneja.RetornaEmpleado(clave);

            txtNombres.Text = consulta.pNombres;
            txtApellidos.Text = consulta.pApellidos;
            txtDomicilio.Text = consulta.pDomicilio;
            txtSexo.Text = consulta.pSexo;
            txtEdad.Text = consulta.pEdad.ToString();
            txtClaveDep.Text = consulta.pClaveDepto.ToString();
            txtSueldo.Text = consulta.pSueldoDiario.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblClave_Click(object sender, EventArgs e)
        {

        }

        private void lblClaveDep_Click(object sender, EventArgs e)
        {

        }

        private void lblNombres_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void lblDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblSueldo_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }
    }
}
