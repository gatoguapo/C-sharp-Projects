using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEmpleadosGUI
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private string ciudad;

        public Empleado (string nombre, string apellido, string ciudad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
        }

        public string pNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string pApellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string pCiudad
        {
            get
            {
                return ciudad;
            }
            set
            {
                ciudad = value;
            }
        }
    }
}
