using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConE.Entidades
{
    public class Carrera
    {
        private string Nombre;
        private string Fecha;
        public Carrera(string nombre, string fecha)
        {
            Nombre = nombre;
            Fecha = fecha;
        }

        public string pNombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }
        public string pFecha
        {
            set
            {
                Fecha = value;
            }
            get
            {
                return Fecha;
            }
        }
    }
}
