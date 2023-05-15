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
    public partial class frmConsultaCarreraTotal : Form
    {
        ManejaCarrera maneja;
        public frmConsultaCarreraTotal(ManejaCarrera maneja)
        {
            InitializeComponent();
            this.maneja = maneja;
        }

        private void frmConsultaCarreraTotal_Load(object sender, EventArgs e)
        {
            string[] ArrIDs = maneja.getIDs();
            string[] ArrNombres = maneja.getNombres();
            string[] ArrEstatus = maneja.getEstatus();
            int i = 0;
            foreach (string carrera in ArrIDs)
            {
                dgvCarreras.Rows.Add(ArrIDs[i], ArrNombres[i], ArrEstatus[i]);
                i++;
            }
        }
    }
}
