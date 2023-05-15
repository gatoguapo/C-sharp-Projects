using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class UsaAuto
    {
        Auto[] arrAuto = new Auto[5];
        public static void Main(string[] args)
        {
            UsaAuto objUsaAuto = new UsaAuto();
            objUsaAuto.PedirDatos();
            objUsaAuto.MostrarDatos();
            Console.ReadKey();
        }

        public void PedirDatos()
        {
            foreach (Auto a in arrAuto)
            {
                Console.WriteLine("Introduzca el numero de serie:");
                a.pNumSerie = Console.ReadLine();
                Console.WriteLine("Introduzca la descripcion:");
                a.pDescripcion = Console.ReadLine();
                Console.WriteLine("Introduzca el modelo:");
                a.pModelo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca la marca:");
                a.pMarca = Console.ReadLine();
            }
        }

        public void MostrarDatos()
        {
            int i = 1;
            foreach (Auto a in arrAuto)
            {
                Console.WriteLine($"---------- Datos auto {i}----------");
                Console.WriteLine($"Numero de serie:{a.pNumSerie}");
                Console.WriteLine($"Descripcion:{a.pDescripcion}");
                Console.WriteLine($"Modelo:{a.pModelo}");
                Console.WriteLine($"Marca:{a.pMarca}");
                i++;
            }
        }
    }
}
