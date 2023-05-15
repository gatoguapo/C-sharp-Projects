using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_NominaConsola
{
    public class UtileriasEmpleados
    {

        public static string stringVacio(string dato)
        {
            while (dato == null || (dato.Length == 0) || dato.StartsWith(" "))
            {
                    Console.WriteLine("Error, no puedes ingresar un dato vacio");
                    Console.WriteLine("Ingrese de nuevo el dato: ");
                    dato = Console.ReadLine();
            }
            return dato.ToUpper();
        }

        public static string sueldoValido(string numero)
        {
            double valor;
            while (numero == null || (numero.Length == 0) || numero.Contains(" ") || !double.TryParse(numero, out valor))
            {
                Console.WriteLine("Error, el dato debe contener un numero decimal!!");
                Console.WriteLine("Ingrese de nuevo el dato: ");
                numero = Console.ReadLine();
            }
            return numero;
        }

        public static double validaSueldo(double numero)
        {
            while (numero <= 0)
            {
                Console.WriteLine("Error, el dato no puede ser negativo ni cero!");
                Console.WriteLine("Ingrese de nuevo el dato: ");
                numero = Convert.ToDouble(Console.ReadLine());
            } 
            return numero;
        }

        public static string hazMayus(string cadena)
        {
            return cadena.ToUpper();
        }

        public static int validaDias(string dias)
        {
            int diaValido = 0;
            while (dias == null || (dias.Length == 0) || dias.Contains(" ") || !int.TryParse(dias, out diaValido) || (int.Parse(dias) <= 0 || int.Parse(dias) > 15))
            {
                Console.WriteLine("Error, el dato debe contener un numero entre 1 y 15!!");
                Console.WriteLine("Ingrese de nuevo el dato: ");
                dias = Console.ReadLine();
            }
            diaValido = int.Parse(dias);
            return diaValido;
        }

        public static int validaNumero(string numero)
        {
            int numeroValidado = 0;
            while (!int.TryParse(numero, out numeroValidado) || (int.Parse(numero)<=0))
            {
                Console.WriteLine("Error, el dato debe contener un numero mayor a cero!!");
                Console.WriteLine("Ingrese de nuevo el dato: ");
                numero = Console.ReadLine();
            }
            numeroValidado = int.Parse(numero);
            return numeroValidado;
        }

        public static int validaOpcion(string opcion)
        {
            int opcionValida = 0;
            while (opcion == null || (opcion.Length == 0) || opcion.Contains(" ")  || !int.TryParse(opcion, out opcionValida) || (int.Parse(opcion) > 8 || int.Parse(opcion) <= 0))
            {
               Console.WriteLine("ERROR, Ingrese una opcion valida:");
               opcion = Console.ReadLine();
            }
            opcionValida = int.Parse(opcion);
            return opcionValida;
        }
    }
}
