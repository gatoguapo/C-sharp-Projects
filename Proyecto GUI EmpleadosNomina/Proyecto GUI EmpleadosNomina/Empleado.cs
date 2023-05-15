using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class Empleado
    {
        private int clave;
        private string nombres;
        private string apellidos;
        private string domicilio;
        private string sexo;
        private int edad;
        private int claveDepto;
        private double sueldoDiario;
        public Empleado(int clave, string nombres, string apellidos, string domicilio, string sexo, int edad, int claveDepto, double sueldoDiario)
        {
            this.clave = clave;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.domicilio = domicilio;
            this.sexo = sexo;
            this.edad = edad;
            this.claveDepto = claveDepto;
            this.sueldoDiario = sueldoDiario;
        }

        public int pClave
        {
            get => clave;
            set => clave = value;
        }

        public string pNombres
        {
            get => nombres;
            set => nombres = value;
        }

        public string pApellidos
        {
            get => apellidos;
            set => apellidos = value;
        }

        public string pDomicilio
        {
            get => domicilio;
            set => domicilio = value;
        }

        public string pSexo
        {
            get => sexo;
            set => sexo = value;
        }

        public int pEdad
        {
            get => edad;
            set => edad = value;
        }

        public int pClaveDepto
        {
            get => claveDepto;
            set => claveDepto = value;
        }

        public double pSueldoDiario
        {
            get => sueldoDiario;
            set => sueldoDiario = value;
        }
    }
}
