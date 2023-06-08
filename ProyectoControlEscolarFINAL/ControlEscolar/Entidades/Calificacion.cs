using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConE.Entidades
{
    public class Calificacion
    {
        private int ClaveEst;
        private int ClaveMat;
        private int Cal;

        public Calificacion(int claveEst, int claveMat, int cal)
        {
            ClaveEst = claveEst;
            ClaveMat = claveMat;
            Cal = cal;
        }

        public int pClaveEst
        {
            set
            {
                ClaveEst = value;
            }
            get
            {
                return ClaveEst;
            }
        }
        public int pClaveMat
        {
            set
            {
                ClaveMat = value;
            }
            get
            {
                return ClaveMat;
            }
        }
        public int pCal
        {
            set
            {
                Cal = value;
            }
            get
            {
                return Cal;
            }
        }
    }
}
