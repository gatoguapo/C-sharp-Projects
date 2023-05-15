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
    public partial class frmConsultaEmpTodos : Form
    {
        ManejaEmpleados maneja;
        public frmConsultaEmpTodos(ManejaEmpleados maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaEmpTodos_Load(object sender, EventArgs e)
        {
            List<Empleado> listEmp = maneja.getListEmpleados();
            listEmp.ForEach(emp => dgvEmpleados.Rows.Add(emp.pClave, emp.pNombres, emp.pApellidos, emp.pDomicilio, emp.pSexo, emp.pEdad, emp.pClaveDepto, emp.pSueldoDiario));
        }
    }
}
