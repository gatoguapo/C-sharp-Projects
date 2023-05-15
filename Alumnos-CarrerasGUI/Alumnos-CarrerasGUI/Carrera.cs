using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos_CarrerasGUI
{
    public class Carrera
    {
        int id;
        string nombre;
        char estatus;

        public Carrera(int id, string nombre, char estatus)
        {
            this.id = id;
            this.nombre = nombre;
            this.estatus = estatus;
        }

        public int pId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string pNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public char pEstatus
        {
            get
            {
                return estatus;
            }
            set
            {
                estatus = value;
            }
        }
    }
}
