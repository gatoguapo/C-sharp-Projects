using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos_CarrerasGUI
{
    public class Alumno
    {
        private string nombre;
        private string domicilio;
        private int edad;
        private string carrera;
        private string sexo;

        public Alumno(string nombre, string domicilio, int edad, string carrera, string sexo)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.edad = edad;
            this.carrera = carrera;
            this.sexo = sexo;
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

        public string pDomicilio
        {
            get
            {
                return domicilio;
            }
            set
            {
                domicilio = value;
            }
        }


        public int pEdad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }


        public string pCarrera
        {
            get
            {
                return carrera;
            }
            set
            {
                carrera = value;
            }
        }

        public string pSexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }
    }
}
