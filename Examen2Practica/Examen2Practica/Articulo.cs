using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Practica
{
    class Articulo
    {
        private byte ID;
        private string Descripcion;
        private string Marca;

        public Articulo(byte ID, string Descripcion, string Marca)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
        }

        public byte pID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public string pDescripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }

        public string pMarca
        {
            get
            {
                return Marca;
            }
            set
            {
                Descripcion = Marca;
            }
        }
    }
}
