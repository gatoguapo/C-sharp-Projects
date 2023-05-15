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
    public partial class frmBorrarNomina : Form
    {
        ManejaRegistroLaboral maneja;
        public frmBorrarNomina(ManejaRegistroLaboral maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmBorrarNomina_Load(object sender, EventArgs e)
        {
            List<Nomina> listNom = maneja.getRegistroDatos();
            listNom.ForEach(nom => cmbClaveEmp.Items.Add(nom.pClave));
        }

        private void btnBorrarIndv_Click(object sender, EventArgs e)
        {
            if (cmbClaveEmp.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int clave = Convert.ToInt32(cmbClaveEmp.SelectedItem);
            MessageBox.Show("Nomina Borrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            maneja.borrarNomina(clave);
        }

        private void btnBorrarNominaTotal_Click(object sender, EventArgs e)
        {
            DialogResult agregaDup = MessageBox.Show("¿Seguro que deseas borrar todas las nominas?", "Borrar Nomina",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (agregaDup == DialogResult.Yes)
            {
                MessageBox.Show("Nominas Borradas", "Borradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maneja.borrarNominas();
            }
            else
            {
                MessageBox.Show("Nominas no Borradas", "No Borradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
