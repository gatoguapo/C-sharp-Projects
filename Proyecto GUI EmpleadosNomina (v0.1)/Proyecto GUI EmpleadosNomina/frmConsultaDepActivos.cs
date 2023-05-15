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
    public partial class frmConsultaDepActivos : Form
    {
        ManejaDepartamentos maneja;
        public frmConsultaDepActivos(ManejaDepartamentos maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaDepActivos_Load(object sender, EventArgs e)
        {
            List<Departamento> listDep = maneja.getDepartamentosActivos();
            listDep.ForEach(activo => drgDepartamentos.Rows.Add(activo.pClaveDepto, activo.pNombreJefeDep, activo.pNombreDepto));
        }
    }
}
