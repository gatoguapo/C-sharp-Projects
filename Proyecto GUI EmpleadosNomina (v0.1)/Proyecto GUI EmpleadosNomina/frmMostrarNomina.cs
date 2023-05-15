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
    public partial class frmMostrarNomina : Form
    {
        ManejaRegistroLaboral manejaReg;
        ManejaEmpleados manejaEmp;
        public frmMostrarNomina(ManejaRegistroLaboral manejaReg, ManejaEmpleados manejaEmp)
        {
            InitializeComponent();
            this.manejaReg = manejaReg;
            this.manejaEmp = manejaEmp;
        }

        private void btnCalculaNomina_Click(object sender, EventArgs e)
        {
            List<Nomina> listNom = manejaReg.getRegistroDatos();
            List<Empleado> listEmp = manejaEmp.getListEmpleados();
            if (listNom.Count.Equals(0))
            {
                MessageBox.Show("Debes hacer el registro laboral primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listNom != null)
            {
                foreach (Nomina nom in listNom)
                {
                    foreach (Empleado emp in listEmp)
                    {
                        if (nom.pClave.Equals(emp.pClave))
                        {
                            nom.pTotalBruto = (nom.pDiasLaborados * emp.pSueldoDiario) + (nom.pHorasExtras * 100) - (nom.pFaltas * emp.pSueldoDiario);
                            nom.pImpuestos = nom.pTotalBruto * 0.18;
                            nom.pTotalNeto = nom.pTotalBruto - nom.pImpuestos;
                            nom.pFechaNomina = DateTime.Now;
                            manejaReg.setNomina(emp.pClave, nom.pTotalBruto, nom.pImpuestos, nom.pTotalNeto, nom.pFechaNomina);
                        }
                    }

                }
                MessageBox.Show("Nomina Calculada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La nomina ya fue calculada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarNomina_Click(object sender, EventArgs e)
        {
            frmConsultaNomina consultaNom = new frmConsultaNomina(manejaReg);
            consultaNom.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrarNom_Click(object sender, EventArgs e)
        {
            frmBorrarNomina borrarNominas = new frmBorrarNomina(manejaReg);
            borrarNominas.ShowDialog();
        }
    }
}
