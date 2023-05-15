using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaM.Entidades
{
    public class Medico
    {
        private int clave;
        private string nombre;
        private string especialidad;
        private string subespecialidad;
        private string telefono;
        private byte consultorio;

        public Medico(int clave, string nombre, string especialidad, string subespecialidad, string telefono, byte consultorio)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.especialidad = especialidad;
            this.subespecialidad = subespecialidad;
            this.telefono = telefono;
            this.consultorio = consultorio;
        }

        public int pClave
        {
            get => clave;
            set => clave = value;
        }

        public string pNombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string pEspecialidad
        {
            get => especialidad;
            set => especialidad = value;
        }

        public string pSubespecialidad
        {
            get => subespecialidad;
            set => subespecialidad = value;
        }

        public string pTelefono
        {
            get => telefono;
            set => telefono = value;
        }

        public byte pConsultorio
        {
            get => consultorio;
            set => consultorio = value;
        }
    }
}
