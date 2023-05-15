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
        ManejaRegistroLaboral manejaReg;
        public frmMenuEmpleadosNomina(ManejaEmpleados manejaEmp, ManejaDepartamentos manejaDep, ManejaRegistroLaboral manejaReg)
        {
            InitializeComponent();
            this.manejaEmp = manejaEmp;
            this.manejaDep = manejaDep;
            this.manejaReg = manejaReg;
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
            frmAgregaDepartamentos agregaDepartamentos = new frmAgregaDepartamentos(manejaDep);
            agregaDepartamentos.ShowDialog();
        }

        private void totalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeptoTodos consultaDeptoTodos = new frmConsultaDeptoTodos(manejaDep);
            consultaDeptoTodos.ShowDialog();
        }

        private void individualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeptoIndv consultaDeptoIndv = new frmConsultaDeptoIndv(manejaDep);
            consultaDeptoIndv.ShowDialog();
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpTodos consultaEmpTodos = new frmConsultaEmpTodos(manejaEmp);
            consultaEmpTodos.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpIndv consultaEmpIndv = new frmConsultaEmpIndv(manejaEmp);
            consultaEmpIndv.ShowDialog();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpDatosPersonales consultaEmpDatosPer = new frmConsultaEmpDatosPersonales(manejaEmp);
            consultaEmpDatosPer.ShowDialog();
        }

        private void depActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDepActivos consultaDepActivos = new frmConsultaDepActivos(manejaDep);
            consultaDepActivos.ShowDialog();
        }

        private void agregaRegistroLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroLaboral agregaRegistroLaboral = new frmRegistroLaboral(manejaReg, manejaEmp);
            agregaRegistroLaboral.ShowDialog();
        }

        private void mostrarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarNomina mostrarNomina = new frmMostrarNomina(manejaReg, manejaEmp);
            mostrarNomina.ShowDialog();
        }

        private void consultaRegistroLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRegLab consultaRegistro = new frmConsultaRegLab(manejaReg);
            consultaRegistro.ShowDialog();
        }

        private void frmMenuEmpleadosNomina_Load(object sender, EventArgs e)
        {

        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nominaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
        }

        private void nominaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe AcercaDe = new frmAcercaDe();
            AcercaDe.ShowDialog();
        }
    }
}
