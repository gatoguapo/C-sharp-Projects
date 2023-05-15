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
    public partial class frmConsultaEmpDatosPersonales : Form
    {
        ManejaEmpleados maneja;
        public frmConsultaEmpDatosPersonales(ManejaEmpleados maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaEmpDatosPersonales_Load(object sender, EventArgs e)
        {
            List<Empleado> listApellidos = maneja.getListEmpleados();
            listApellidos.ForEach(emp => cmbApellidos.Items.Add(emp.pApellidos));
        }

        private void cmbApellidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellidos = cmbApellidos.SelectedItem.ToString();
            Empleado emp = maneja.RetornaEmpleadoDatosPersonales(apellidos);
            txtNombres.Text = emp.pNombres;
            txtDomicilio.Text = emp.pDomicilio;
            txtEdad.Text = emp.pEdad.ToString();
            txtSexo.Text = emp.pSexo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
