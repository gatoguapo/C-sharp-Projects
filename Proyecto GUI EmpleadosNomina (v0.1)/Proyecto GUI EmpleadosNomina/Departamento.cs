using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class Departamento
    {
        private int claveDepto;
        private string nombreDepto;
        private string nombreJefeDep;
        private string estatus;
        public Departamento(int claveDepto, string nombreDepto, string nombreJefeDep, string estatus)
        {
            this.claveDepto = claveDepto;
            this.nombreDepto = nombreDepto;
            this.nombreJefeDep = nombreJefeDep;
            this.estatus = estatus;
        }

        public int pClaveDepto
        {
            get => claveDepto;
            set => claveDepto = value;
        }

        public string pNombreDepto
        {
            get => nombreDepto;
            set => nombreDepto = value;
        }

        public string pNombreJefeDep
        {
            get => nombreJefeDep;
            set => nombreJefeDep = value;
        }

        public string pEstatus
        {
            get => estatus;
            set => estatus = value;
        }
    }
}
