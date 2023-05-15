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
    public partial class frmConsultaRegLab : Form
    {
        ManejaRegistroLaboral manejaReg;
        public frmConsultaRegLab(ManejaRegistroLaboral manejaReg)
        {
            InitializeComponent();
            this.manejaReg = manejaReg;
        }

        private void frmConsultaRegLab_Load(object sender, EventArgs e)
        {
            List<Nomina> listNom = manejaReg.getRegistroDatos();
            listNom.ForEach(nom => dgvRegistroLaboral.Rows.Add(nom.pClave, nom.pDiasLaborados, nom.pHorasExtras, nom.pFaltas));
        }
    }
}
