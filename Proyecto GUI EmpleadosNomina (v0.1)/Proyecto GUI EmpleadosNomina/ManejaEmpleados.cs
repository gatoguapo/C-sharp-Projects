﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class ManejaEmpleados
    {
        private List<Empleado> listEmpleados = new List<Empleado>();

        public void agregaEmpleado(int clave, string nombres, string apellidos, string domicilio, string sexo, int edad, int claveDepto, double saldoDiario)
        {
            listEmpleados.Add(new Empleado(clave, nombres, apellidos, domicilio, sexo, edad, claveDepto, saldoDiario));
        }

        //Metodo para generar la clave del empleado
        public int generaClave()
        {
            if (listEmpleados.Count.Equals(0)) 
            {
                return 20230000; //<= Clave generada por defecto.
            }
            return listEmpleados.Last().pClave + 2; //En caso de que ya exista una, regresa el valor de la ultima clave registrada +2.
        }

        //Metodo para retornar el contenido de listEmpleados
        public List<Empleado> getListEmpleados()
        {
            List<Empleado> listaAux = listEmpleados;
            return listaAux; 
        }

        public Empleado RetornaEmpleado(int clave)
        {
            return listEmpleados.Find(emp => emp.pClave.Equals(clave)); //Find busca el elemento que cumpla la condicion emp.pClave.Equals(clave) y devuelve el valor si lo encuentra.
        }

        public Empleado RetornaEmpleadoDatosPersonales(string apellidos)
        {
            return listEmpleados.Find(emp => emp.pApellidos.Equals(apellidos)); //Find busca el elemento que cumpla la condicion emp.pApellidos.Equals(apellidos) y devuelve el objeto si lo encuentra.
        }
    }
}
