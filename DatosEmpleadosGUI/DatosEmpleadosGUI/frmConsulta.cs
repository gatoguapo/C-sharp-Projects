using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosEmpleadosGUI
{
    public partial class frmConsulta : Form
    {
        ManejoEmpleados maneja;
        public frmConsulta(ManejoEmpleados maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            int[] arrId = maneja.regresaIDEmp();
            foreach (int item in arrId)
            {
                cmbId.Items.Add(item);
            }
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSel = Convert.ToInt32(cmbId.SelectedItem);
            string nombre = maneja.getNombre(idSel);
            txtNombre.Text = nombre;
            string apellido = maneja.getApellido(idSel);
            txtApellido.Text = apellido;
            string ciudad = maneja.getCiudad(idSel);
            txtCiudad.Text = ciudad;
        }
    }
}
