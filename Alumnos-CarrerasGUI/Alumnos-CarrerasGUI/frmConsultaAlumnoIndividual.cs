using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos_CarrerasGUI
{
    public partial class frmConsultaAlumnoIndividual : Form
    {
        ManejaAlumno maneja;
        public frmConsultaAlumnoIndividual(ManejaAlumno maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaAlumnoIndividual_Load(object sender, EventArgs e)
        {
            List<long> listaIDs = maneja.ListaIds();
            foreach (long item in listaIDs)
            {
                cmbNumControl.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nControl = Convert.ToInt32(cmbNumControl.SelectedItem);
            txtNombre.Text = maneja.getNombre(nControl);
            txtDomicilio.Text = maneja.getDomicilio(nControl);
            txtEdad.Text = maneja.getEdad(nControl);
            txtSexo.Text = maneja.getSexo(nControl);
            txtCarrera.Text = maneja.getCarrera(nControl);
        }

        
    }
}
