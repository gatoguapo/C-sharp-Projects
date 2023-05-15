using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_NominaConsola
{
    public class Empleado
    {
        private int numEmpleado;
        private string nombre;
        private string domicilio;
        private int diasLaborados;
        private double sueldoDiario;

        public Empleado(int numEmpleado, string nombre, string domicilio, double sueldoDiario)
        {
            this.numEmpleado = numEmpleado;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.sueldoDiario = sueldoDiario;
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

        public int pNumEmpleado
        {
            get
            {
                return numEmpleado;
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

        public double pSueldoDiario
        {
            set
            {
                sueldoDiario = value;
            }
            get
            {
                return sueldoDiario;
            }
        }

        public int pDiasLaborados
        {
            set
            {
                diasLaborados = value;
            }
            get
            {
                return diasLaborados;
            }
        }
        public override string ToString()
        {
            return string.Format($"Numero de empleado: {numEmpleado}, Nombre de empleado: {nombre}, Domicilio: {domicilio}, Dias laborados: {diasLaborados}, Sueldo diario: {sueldoDiario}");
        }
    }
}
