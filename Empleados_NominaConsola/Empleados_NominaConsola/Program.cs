using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_NominaConsola
{   
    public class Program
    {
        ManejaEmpleados maneja = new ManejaEmpleados();
        public static void Main()
        { 
            Program obj = new Program();
            PresentaEmpleado presenta = new PresentaEmpleado(obj.maneja);
            presenta.menu();
        }
    }
}
