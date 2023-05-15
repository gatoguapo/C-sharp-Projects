using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_NominaConsola
{
    public class PresentaEmpleado
    {
        ManejaEmpleados maneja;

        public PresentaEmpleado(ManejaEmpleados maneja)
        {
            this.maneja = maneja;
        }

        public void menu()
        {
            Console.WriteLine("********* MENU DE NOMINA EMPLEADOS ***************");
            string opcion = "";
            int opcionValida = 0;
            while (opcionValida != 8)
            {
                Console.WriteLine("Seleccione la opcion que desea" +
                    "\n1.- Agregar empleado" +
                    "\n2.- Consultar empleados" +
                    "\n3.- Buscar empleado" +
                    "\n4.- Agregar dias laborados" +
                    "\n5.- Calcular Nomina" +
                    "\n6.- Imprimir Nomina" +
                    "\n7.- Modificar Sueldo" +
                    "\n8.- Salir:");
                opcion = Console.ReadLine();
                opcionValida = UtileriasEmpleados.validaOpcion(opcion);
                switch(opcionValida)
                {
                    case 1:
                        altaEmpleado();
                        break;
                    case 2:
                        mostrarEmpleados();
                        break;
                    case 3:
                        buscarEmpleado();
                        break;
                    case 4:
                        agregarDias();
                        break;
                    case 5:
                        calcularNomina();
                        break;
                    case 6:
                        mostrarNomina();
                        break;
                    case 7:
                        agregarSueldo();
                        break;
                    case 8:
                        break;
                }
            }
        }
        public void altaEmpleado()
        {
            Console.WriteLine("*************** ALTA DE EMPLEADO ***************");
            double sueldoValidado = 0;
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            nombre = UtileriasEmpleados.stringVacio(nombre);
            if (!maneja.buscaNombreEmp(nombre))
            {
                Console.WriteLine("Domicilio: ");
                string domicilio = Console.ReadLine();
                domicilio = UtileriasEmpleados.stringVacio(domicilio);

                Console.WriteLine("Sueldo:");
                string sueldo = Console.ReadLine();
                sueldo = UtileriasEmpleados.sueldoValido(sueldo);

                sueldoValidado = Double.Parse(sueldo);
                sueldoValidado = UtileriasEmpleados.validaSueldo(sueldoValidado);
                if (!maneja.agregaEmpleado(nombre, domicilio, sueldoValidado))
                {
                    System.Console.WriteLine("Error, no puedes ingresar mas de 10 empleados!!");
                    Console.ReadKey();
                } 
                else
                {
                    System.Console.WriteLine("Empleado agregado con exito.");
                }
            }
            else
            {
                Console.WriteLine($"Error el empleado {nombre} ya existe.");
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        public void mostrarEmpleados()
        {
            Console.WriteLine("************************** EMPLEADOS **************************");
            Console.WriteLine("------------------------------------------------------------");
            string[] arreglo = maneja.obtenEmpleados();
            int lugar = 0;
            foreach (string item in arreglo)
            {
                Console.WriteLine($"{arreglo[lugar]}");
                lugar++;
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        public void buscarEmpleado()
        {
            Console.WriteLine("************************** BUSCA EMPLEADO **************************");
            Console.WriteLine("Ingrese el nombre del empleado que busca: ");
            string nombre = Console.ReadLine();
            Console.WriteLine(maneja.buscaEmpleado(UtileriasEmpleados.hazMayus(nombre)));
            Console.WriteLine("------------------------------------------------------------");
        }

        public void agregarDias()
        {
            Console.WriteLine("************************** AGREGA DIAS LABORADOS **************************");
            Console.WriteLine("Ingrese el numero del empleado que desea agregar los dias laborados: ");
            string numEmpleado = Console.ReadLine();
            int numEmpleadoValidado = UtileriasEmpleados.validaNumero(numEmpleado);
            if (maneja.buscaNumEmpleado(numEmpleadoValidado))
            {
                Console.WriteLine("Ingrese el numero de dias laborados: ");
                string dias = Console.ReadLine();
                Console.WriteLine(maneja.agregarDias(dias, numEmpleadoValidado));
            } else
            {
                Console.WriteLine("Error, no existe ese numero de empleado!!");
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        public void calcularNomina()
        {
            Console.WriteLine("******** NOMINA TOTAL **********");
            Console.WriteLine($"El total de la nomina es de {maneja.calculaNomina()}");
            Console.WriteLine("************************");
        }

        public void mostrarNomina()
        {   
            Console.WriteLine("******** NOMINA **********");
            string[] arreglo = maneja.mostrarNomina();
            int lugar = 0;
            foreach (string item in arreglo)
            {
                Console.WriteLine($"{arreglo[lugar]}");
                lugar++;
            }
            Console.WriteLine("************************");
        }

        public void agregarSueldo()
        {
            Console.WriteLine("************************** AGREGAR SUELDO DEL EMPLEADO **************************");
            Console.WriteLine("Ingrese el numero del empleado que desea agregar sueldo: ");
            string numEmpleado = Console.ReadLine();
            int numEmpleadoValidado = UtileriasEmpleados.validaNumero(numEmpleado);
            if (maneja.buscaNumEmpleado(numEmpleadoValidado))
            {
                Console.WriteLine("Ingrese el sueldo del empleado: ");
                string sueldo = Console.ReadLine();
                Console.WriteLine(maneja.agregarSueldo(sueldo, numEmpleadoValidado));
            }
            else
            {
                Console.WriteLine("Error, no existe ese numero de empleado!!");
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
