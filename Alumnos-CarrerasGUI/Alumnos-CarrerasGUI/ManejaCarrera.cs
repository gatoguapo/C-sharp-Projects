using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos_CarrerasGUI
{
    public class ManejaCarrera
    {
        private List<Carrera> listCarreras = new List<Carrera>();
        public void AgregaCarrera(int id, string nombre, char estatus)
        {
            listCarreras.Add(new Carrera(id, nombre, estatus));
        }

        public string[] getCarreras()
        {
            string[] arregloNomCarreras = new string[listCarreras.Count];
            int i = 0;
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras.pEstatus.Equals('A'))
                {
                    arregloNomCarreras[i] = carreras.pNombre;
                    i++;
                }
            }
            return arregloNomCarreras;
        }

        public bool ValidaIdDuplicado(int id)
        {
            foreach (Carrera carrera in listCarreras)
            {
                if (carrera.pId == id)
                {
                    return false;
                }
            }
            return true;
        }

        public string[] getIDs()
        {
            string[] arrIDs = new string[listCarreras.Count];
            int i = 0;
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras != null)
                {
                    arrIDs[i] = carreras.pId.ToString();
                }
                i++;
            }
            return arrIDs;
        }

        public string[] getNombres()
        {
            string[] arrNombres = new string[listCarreras.Count];
            int i = 0;
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras != null)
                {
                    arrNombres[i] = carreras.pNombre;
                }
                i++;
            }
            return arrNombres;
        }

        public string[] getEstatus()
        {
            string[] arrEstatus = new string[listCarreras.Count];
            int i = 0;
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras != null)
                {
                    arrEstatus[i] = carreras.pEstatus.ToString();
                }
                i++;
            }
            return arrEstatus;
        }

        public string getNombre(int id)
        {
            string nombre = "";
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras.pId.Equals(id))
                {
                    nombre = carreras.pNombre;
                }
            }
            return nombre;
        }

        public int getID(int id)
        {
            int idAux = 0;
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras.pId.Equals(id))
                {
                    idAux = carreras.pId;
                }
            }
            return idAux;
        }

        public char getEstatus(int id)
        {
            char estatus = ' ';
            foreach (Carrera carreras in listCarreras)
            {
                if (carreras.pId.Equals(id))
                {
                    estatus = carreras.pEstatus;
                }
            }
            return estatus;
        }
    }
}

