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
    public partial class frmTitulo : Form
    {
        ManejoEmpleados maneja;
        public frmTitulo(ManejoEmpleados m)
        {
            InitializeComponent();
            cmbCiudad.SelectedIndex = 0;
            maneja = m;
        }

        public bool validaId()
        {
            try
            {
                int idEmpleado = Convert.ToInt32(txtId.Text);
            } catch
            {
                return false;
            }
            return true;
        }

        public bool validaNombre(string nombre) 
        {
            if (nombre == null || nombre.Length == 0 || nombre.StartsWith(" ")) 
            {
                return false;
            }
            return true;
        }

        public bool validaApellido(string apellido)
        {
            if (apellido == null || apellido.Length == 0 || apellido.StartsWith(" "))
            {
                return false;
            }
            return true;
        }

        public bool validaCiudad(string ciudad)
        {
            ciudad = cmbCiudad.SelectedItem.ToString();
            if (cmbCiudad.SelectedIndex == 0)
            {
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idString = txtId.Text;
            if (!validaId())
            {
                MessageBox.Show("ERROR EN ID", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(idString);
            string nombre = txtNombre.Text;
            if (!validaNombre(nombre))
            {
                MessageBox.Show("ERROR EN NOMBRE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string apellido = txtApellido.Text;
            if (!validaApellido(apellido))
            {
                MessageBox.Show("ERROR EN APELLIDO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ciudad = cmbCiudad.SelectedItem.ToString();
            if (!validaCiudad(ciudad))
            {
                MessageBox.Show("ERROR EN CIUDAD", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!maneja.agregarEmpleado(id, nombre, apellido, ciudad))
            {
                MessageBox.Show("ERROR ID DUPLICADO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Agregado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbCiudad.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta(maneja);
            consulta.ShowDialog();
        }
    }
}
