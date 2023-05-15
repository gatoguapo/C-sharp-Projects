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
    public partial class frmConsultaDeptoTodos : Form
    {
        ManejaDepartamentos depto;

        public frmConsultaDeptoTodos(ManejaDepartamentos d)
        {
            InitializeComponent();
            depto = d;
        }

        private void frmConsultaDeptoTodos_Load(object sender, EventArgs e)
        {
            List<Departamento> ListaDepto = depto.getDepartamentos();
            //Recorremos la listaDepto y agregamos en el Rows.Add los departamentos registrados.
            ListaDepto.ForEach(dep => dgvDepto.Rows.Add(dep.pClaveDepto, dep.pNombreDepto, dep.pNombreJefeDep, dep.pEstatus)); 
        }
    }
}
