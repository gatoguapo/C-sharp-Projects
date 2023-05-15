using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Practica
{
    class Administradora
    {
        private Articulo[] arrArt; 



        public Articulo[] pArrArt
        {
            get
            {
                return arrArt;
            }
            set
            {
                arrArt = value;
            }
        }

        public int[] EncuentraDuplicados()
        {
            int[] idDuplicados;
            int longitud = 0;
            int i = 0;
            foreach (Articulo item in arrArt)
            {
                if (arrArt[i] != null)
                {
                    int j = 0;
                    foreach (Articulo item2 in arrArt)
                    {
                        if (arrArt[j] != null && arrArt[i].pID == arrArt[j].pID)
                        {
                            longitud++;
                        }
                        j++;
                    }
                }
                i++;
            }
            idDuplicados = new int[longitud];
            foreach (Articulo item in arrArt)
            {
                if (arrArt[i] != null)
                {
                    int j = 0;
                    foreach (Articulo item2 in arrArt)
                    {
                        if (arrArt[j] != null && arrArt[i].pID == arrArt[j].pID)
                        {
                            idDuplicados[i] = i;
                        }
                        j++;
                    }
                }
                i++;
            }
            return idDuplicados;
        }

        public void modificaMarca(byte ID, string Marca)
        {
            int i = 0;
            foreach (Articulo item in arrArt)
            {
                if (arrArt[i] != null && arrArt[i].pID == ID)
                {
                    arrArt[i].pMarca = Marca;
                }
                i++;
            }
        }
    }
}
