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
    public partial class frmMenuEmpleadosNomina : Form
    {
        ManejaEmpleados manejaEmp;
        ManejaDepartamentos manejaDep;
        public frmMenuEmpleadosNomina(ManejaEmpleados manejaEmp, ManejaDepartamentos manejaDep)
        {
            InitializeComponent();
            this.manejaEmp = manejaEmp;
            this.manejaDep = manejaDep;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaEmpleados agregaEmpleados = new frmAgregaEmpleados(manejaEmp, manejaDep);
            agregaEmpleados.ShowDialog();
        }

        private void agregaDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregaDepartamentos agregaDepartamentos = new AgregaDepartamentos(manejaDep);
            agregaDepartamentos.ShowDialog();
        }
    }
}
