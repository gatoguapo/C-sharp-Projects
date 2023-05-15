using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Auto
    {
        private string numSerie;
        private string descripcion;
        private int modelo;
        private string marca;
        Auto(string numSerie, string descripcion, int modelo, string marca)
        {
            this.numSerie = numSerie;
            this.descripcion = descripcion;
            this.modelo = modelo;
            this.marca = marca;
        }

        public string pDescripcion
        {
            set
            {
                descripcion = value;
            }
            get
            {
                return descripcion;
            }
        }

        public string pNumSerie
        {
            set
            {
                numSerie = value;
            }
            get
            {
                return numSerie;
            }
        }

        public int pModelo
        {
            set
            {
                modelo = value;
            }
            get
            {
                return modelo;
            }
        }

        public string pMarca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
    }
}
