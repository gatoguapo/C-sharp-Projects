using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaM.Entidades
{
    public class Consultorio
    {
        private int idConsultorio;
        private string nombreConsultorio;
        private string domicilio;

        public Consultorio(int idConsultorio, string nombreConsultorio, string domicilio)
        {
            this.idConsultorio = idConsultorio;
            this.nombreConsultorio = nombreConsultorio;
            this.domicilio = domicilio;
        }

        public int pIdConsultorio
        {
            get => idConsultorio;
            set => idConsultorio = value;
        }

        public string pNombreConsultorio
        {
            get => nombreConsultorio;
            set => nombreConsultorio = value;
        }

        public string pDomicilio
        {
            get => domicilio;
            set => domicilio = value;
        }
    }
}
