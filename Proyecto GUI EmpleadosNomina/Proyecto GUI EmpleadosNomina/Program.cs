using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_GUI_EmpleadosNomina
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ManejaEmpleados manejaEmp = new ManejaEmpleados();
            ManejaDepartamentos manejaDep = new ManejaDepartamentos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuEmpleadosNomina(manejaEmp, manejaDep));
        }
    }
}
