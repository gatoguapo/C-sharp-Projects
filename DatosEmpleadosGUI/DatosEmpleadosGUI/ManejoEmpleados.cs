using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosEmpleadosGUI
{
    public class ManejoEmpleados
    {
        Dictionary<int, Empleado> dicEmpleados = new Dictionary<int, Empleado>();

        public bool agregarEmpleado(int ID, string nom, string apellido, string ciudad)
        {
            // Validar para que el ID no este duplicado
            bool retorno = false;
            bool busca = buscarID(ID);
            if (!busca)
            {
                dicEmpleados.Add(ID, new Empleado(nom, apellido, ciudad));
                retorno = true;
            }
            return retorno;
        }

        public bool buscarID(int id)
        {
            return dicEmpleados.ContainsKey(id);
        }

        public int[] regresaIDEmp()
        {
            int[] arreglo = new int[dicEmpleados.Count];
            int pos = 0;
            foreach (int elemento in dicEmpleados.Keys)
            {
                arreglo[pos] = elemento;
                pos++;
            }

            return arreglo;
        }

        public string getNombre(int i)
        {
            return dicEmpleados[i].pNombre;
        }

        public string getApellido(int i)
        {
            return dicEmpleados[i].pApellido;
        }

        public string getCiudad(int i)
        {
            return dicEmpleados[i].pCiudad;
        }
    }
}
