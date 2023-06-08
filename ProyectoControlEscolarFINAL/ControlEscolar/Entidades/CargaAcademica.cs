using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConE.Entidades
{
    public class CargaAcademica
    {
        private int ClaveEst;
        private int Cal1;
        private int Cal2;
        private int Cal3;
        private int Cal4;
        private int Cal5;
        public CargaAcademica(int claveEst, int cal1, int cal2, int cal3, int cal4, int cal5)
        {
            ClaveEst = claveEst;
            Cal1 = cal1;
            Cal2 = cal2;
            Cal3 = cal3;
            Cal4 = cal4;
            Cal5 = cal5;
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
        public int pCal1
        {
            set
            {
                Cal1 = value;
            }
            get
            {
                return Cal1;
            }
        }
        public int pCal2
        {
            set
            {
                Cal2 = value;
            }
            get
            {
                return Cal2;
            }
        }
        public int pCal3
        {
            set
            {
                Cal3 = value;
            }
            get
            {
                return Cal3;
            }
        }
        public int pCal4
        {
            set
            {
                Cal4 = value;
            }
            get
            {
                return Cal4;
            }
        }
        public int pCal5
        {
            set
            {
                Cal5 = value;
            }
            get
            {
                return Cal5;
            }
        }
    }
}
