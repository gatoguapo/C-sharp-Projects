using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_NominaConsola
{
    public class ManejaEmpleados
    {
        private Empleado[] arregloEmp = new Empleado[10];
        static int valorSigEmpleado = 1000;
        int pos = 0;
        double sumaNominas;
        public bool agregaEmpleado(string nombre, string domicilio, double sueldo)
        {
            if (pos < arregloEmp.Length)
            {
                valorSigEmpleado += 2;
                Empleado empleado = new Empleado(valorSigEmpleado, nombre, domicilio, sueldo);
                arregloEmp[pos] = empleado;
                pos++;
                return true;
            }
            return false;
        }

        public bool buscaNombreEmp(string nombre)
        {
            bool existe = false;

            for (int i = 0; i < pos; i++)
            {
                if (arregloEmp[i].pNombre.Equals(nombre))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public bool buscaNumEmpleado(int num)
        {
            bool existe = false;

            for (int i = 0; i < pos; i++)
            {
                if (arregloEmp[i].pNumEmpleado.Equals(num))
                {
                    existe = true;
                    break;
                }
            }

            return existe;
        }

        public string[] obtenEmpleados()
        {
            int lugar = 0;
            string[] arregloString = new string[pos];
            foreach (Empleado item in arregloEmp)
            {
                if (item != null)
                {
                    arregloString[lugar] = string.Format($"Numero de empleado: {item.pNumEmpleado}, Nombre: {item.pNombre}, Domicilio: {item.pDomicilio}, Sueldo diario: {item.pSueldoDiario}, " +
                        $"Numero de dias trabajados: {item.pDiasLaborados}");
                }
                lugar++;
            }
            return arregloString;
        }

        public string buscaEmpleado(string nombre)
        {
            int lugar = 0;
            foreach (Empleado item in arregloEmp)
            {
                if (item != null && arregloEmp[lugar].pNombre.Contains(nombre))
                {
                    return string.Format($"Numero de empleado: {item.pNumEmpleado}, Nombre: {item.pNombre}, Domicilio: {item.pDomicilio}, Sueldo diario: {item.pSueldoDiario}, " +
                        $"Numero de dias trabajados: {item.pDiasLaborados}");
                }
                lugar++;
            }
            return string.Format("No se encontro un empleado con ese nombre.");
        }

        public string agregarDias(string dias,int numEmpleado)
        {
            int lugar = 0;
            int diasValidados = 0;
            foreach (Empleado item in arregloEmp)
            {
                if (item != null && item.pNumEmpleado == numEmpleado)
                {
                    diasValidados = UtileriasEmpleados.validaDias(dias);
                    item.pDiasLaborados = diasValidados;
                    sumaNominas += (item.pSueldoDiario * item.pDiasLaborados);
                    return string.Format("Agregado con exito!!");
                }
                lugar++;
            }
            return string.Format("No se encontro el numero de empleado!.");
        }
        public string[] mostrarNomina()
        {
            string[] arregloString = new string[pos];
            int lugar = 0;
            foreach (Empleado item in arregloEmp)
            {
                if (item != null)
                {
                    arregloString[lugar] = string.Format($"Nombre del empleado: {item.pNombre}, Nomina: {item.pSueldoDiario*item.pDiasLaborados}");
                }
                lugar++;
            }
            return arregloString;
        }

        public double calculaNomina()
        {
            return sumaNominas;
        }

        public string agregarSueldo(string sueldo,int numEmpleado)
        {
            int lugar = 0;
            foreach (Empleado item in arregloEmp)
            {
                if (item != null && arregloEmp[lugar].pNumEmpleado == numEmpleado)
                {
                    sueldo = UtileriasEmpleados.sueldoValido(sueldo);

                    double sueldoValidado = Double.Parse(sueldo);
                    sueldoValidado = UtileriasEmpleados.validaSueldo(sueldoValidado);
                    arregloEmp[lugar].pSueldoDiario = sueldoValidado;
                    return string.Format("Agregado con exito!!");
                }
                lugar++;
            }
            return string.Format("No se encontro el numero de empleado!.");

}     }
}
