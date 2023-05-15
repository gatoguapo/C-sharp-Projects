using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Administradora ad = new Administradora();
            ad.pArrArt = new Articulo[6];
            ad.pArrArt[0].pID = 2;
            ad.pArrArt[1].pID = 3;
            ad.pArrArt[2].pID = 4;
            ad.pArrArt[3].pID = 2;
            ad.pArrArt[4].pID = 5;
            ad.pArrArt[5].pID = 4;

            int[] dup = ad.EncuentraDuplicados();
            int i = 0;
            foreach (int item in dup)
            {
                Console.WriteLine($"Se encontro un id duplicado en la posicion: {dup[i]}");
                i++;
            }

            ad.pArrArt[0].pID = 1;
            ad.pArrArt[1].pID = 2;
            ad.pArrArt[2].pID = 3;
            ad.pArrArt[3].pID = 4;
            ad.pArrArt[4].pID = 5;
            ad.pArrArt[4].pID = 6;

            ad.pArrArt[0].pMarca = "Esparza";
            string marcaNueva = "ClementeGOD";
            ad.modificaMarca(ad.pArrArt[0].pID, marcaNueva);
            Console.WriteLine($"La marca nueva es: {ad.pArrArt[0].pMarca}");
            Console.ReadKey();
        }
    }
}
