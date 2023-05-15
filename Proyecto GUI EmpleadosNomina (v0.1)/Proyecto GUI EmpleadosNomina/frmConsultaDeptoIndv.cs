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
    public partial class frmConsultaDeptoIndv : Form
    {
        ManejaDepartamentos depto;

        public frmConsultaDeptoIndv(ManejaDepartamentos d)
        {
            InitializeComponent();
            depto = d;
        }

        private void frmConsultaDeptoIndv_Load(object sender, EventArgs e)
        {
            List<Departamento> ListaDepto = depto.getDepartamentos();
            ListaDepto.ForEach(dep => cmbClave.Items.Add(dep.pClaveDepto)); //<= Recorremos la listaDepto y agregamos en el cmb las claves de departamento registradas.
        }

        private void txtClaveDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbClave_SelectedIndexChanged(object sender, EventArgs e)
        {
            int claveDepto = int.Parse(cmbClave.SelectedItem.ToString());
            Departamento consulta = depto.RetornaDepto(claveDepto);

            txtNombreDep.Text = consulta.pNombreDepto;
            txtNombreJefe.Text = consulta.pNombreJefeDep;
            txtEstatus.Text = consulta.pEstatus;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
