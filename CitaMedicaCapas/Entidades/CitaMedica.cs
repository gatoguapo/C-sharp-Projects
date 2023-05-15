using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaM.Entidades
{
    public class CitaMedica
    {
        private int claveMedico;
        private string fecha;
        private string hora;
        private string nombre;
        private string telefono;
        private string observaciones;

        public CitaMedica (int claveMedico, string fecha, string hora, string nombre, string telefono, string observaciones)
        {
            this.claveMedico = claveMedico;
            this.fecha = fecha;
            this.hora = hora;
            this.nombre = nombre;
            this.telefono = telefono;
            this.observaciones = observaciones;
        }

        public int pClaveMedico
        {
            get => claveMedico;
            set => claveMedico = value;
        }

        public string pFecha
        {
            get => fecha;
            set => fecha = value;
        }

        public string pHora
        {
            get => hora;
            set => hora = value;
        }

        public string pNombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string pTelefono
        {
            get => telefono;
            set => telefono = value;
        }

        public string pObservaciones
        {
            get => observaciones;
            set => observaciones = value;
        }
    }
}
