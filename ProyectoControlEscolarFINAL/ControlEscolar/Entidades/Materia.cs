using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConE.Entidades
{
    public class Materia
    {
        private string Nombre;
        private int cveCarrera;
        private int Creditos;
        private string NomMaestro;
        private string Hora;
        private int AlumnosInsc;
        private int MaxAlumn;

        public Materia(string nombre, int cveCarrera, int creditos, string nommaestros, string hora, int aluminsc, int maxalumn)
        {
            Nombre = nombre;
            this.cveCarrera = cveCarrera;
            Creditos = creditos;
            NomMaestro = nommaestros;
            Hora = hora;
            AlumnosInsc = aluminsc;
            MaxAlumn = maxalumn;
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
        public int pCveCarrera
        {
            set
            {
                cveCarrera = value;
            }
            get
            {
                return cveCarrera;
            }
        }
        public int pCreditos
        {
            set
            {
                Creditos = value;
            }
            get
            {
                return Creditos;
            }
        }
        public string pNomMaestro
        {
            set
            {
                NomMaestro = value;
            }
            get
            {
                return NomMaestro;
            }
        }
        public string pHora
        {
            set
            {
                Hora = value;
            }
            get
            {
                return Hora;
            }
        }
        public int pAlumnInsc
        {
            set
            {
                AlumnosInsc = value;
            }
            get
            {
                return AlumnosInsc;
            }
        }
        public int pMaxAlumn
        {
            set
            {
                MaxAlumn = value;
            }
            get
            {
                return MaxAlumn;
            }
        }
    }
}
