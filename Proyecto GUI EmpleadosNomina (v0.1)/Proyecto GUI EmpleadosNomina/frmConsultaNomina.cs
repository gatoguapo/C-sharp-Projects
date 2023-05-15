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
    public partial class frmConsultaNomina : Form
    {
        ManejaRegistroLaboral maneja;
        public frmConsultaNomina(ManejaRegistroLaboral maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaNomina_Load(object sender, EventArgs e)
        {
            List<Nomina> listNom = maneja.getRegistroDatos();
            listNom.ForEach(nom => drgNomina.Rows.Add(nom.pClave, nom.pTotalBruto, nom.pImpuestos, nom.pTotalNeto, nom.pFechaNomina));
        }
    }
}
