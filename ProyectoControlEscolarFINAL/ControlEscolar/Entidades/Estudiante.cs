using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConE.Entidades
{
    public class Estudiante
    {
        private string Nombre;
        private decimal Semestre;
        private int Carrera;
        private string Domicilio;
        private string Correo;
        private string Telefono;

        public Estudiante(string nombre, decimal semestre, int carrera, string domicilio, string correo, string telefono)
        {
            Nombre = nombre;
            Semestre = semestre;
            Carrera = carrera;
            Domicilio = domicilio;
            Correo = correo;
            Telefono = telefono;
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
        public decimal pSemestre
        {
            set
            {
                Semestre = value;
            }
            get
            {
                return Semestre;
            }
        }
        public int pCarrera
        {
            set
            {
                Carrera = value;
            }
            get
            {
                return Carrera;
            }
        }
        public string pDomicilio
        {
            set
            {
                Domicilio = value;
            }
            get
            {
                return Domicilio;
            }
        }
        public string pCorreo
        {
            set
            {
                Correo = value;
            }
            get
            {
                return Correo;
            }
        }
        public string pTelefono
        {
            set
            {
                Telefono = value;
            }
            get
            {
                return Telefono;
            }
        }
    }
}
