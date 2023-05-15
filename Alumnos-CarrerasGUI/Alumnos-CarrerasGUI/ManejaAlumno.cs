using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos_CarrerasGUI
{
    public class ManejaAlumno
    {
        private static long NCConsecutivo = 1000;
        private Dictionary<long, Alumno> dicAlumnos = new Dictionary<long, Alumno>();

        public long CalculaNumero ()
        {
            string dato = Convert.ToString(DateTime.Now.Year).Substring(2, 2) + "17" + NCConsecutivo.ToString();
            long numCon = long.Parse(dato);

            NCConsecutivo += 2;
            return numCon;
        }

        public void AgregaAlumno(long nCon,string nombre, string domicilio, int edad, string carrera, string sexo)
        {
            dicAlumnos.Add(nCon, new Alumno(nombre, domicilio, edad, carrera, sexo));
        }

        public bool BuscarNombreAlum(string nombre)
        {
            foreach (Alumno alumno in dicAlumnos.Values)
            {
                if (alumno.pNombre.Equals(nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Alumno> ListaAlumnos()
        {
            List<Alumno> listaAlumno = new List<Alumno>();

            foreach (Alumno alumno in dicAlumnos.Values)
            {
                listaAlumno.Add(alumno);
            }

            return listaAlumno;
        }

        public string getNombre(int nControl)
        {
            string nombre = "";

            foreach (Alumno alumno in dicAlumnos.Values)
            {
                nombre = dicAlumnos[nControl].pNombre;
            }

            return nombre;
        }

        public string getCarrera(int nControl)
        {
            string carrera = "";

            foreach (Alumno alumno in dicAlumnos.Values)
            {
                carrera = dicAlumnos[nControl].pCarrera;
            }

            return carrera;
        }

        public string getDomicilio(int nControl)
        {
            string domicilio = "";

            foreach (Alumno alumno in dicAlumnos.Values)
            {
                domicilio = dicAlumnos[nControl].pDomicilio;
            }

            return domicilio;
        }

        public string getEdad(int nControl)
        {
            string edad = "";

            foreach (Alumno alumno in dicAlumnos.Values)
            {
                edad = dicAlumnos[nControl].pEdad.ToString();
            }

            return edad;
        }

        public string getSexo(int nControl)
        {
            string sexo = "";

            foreach (Alumno alumno in dicAlumnos.Values)
            {
                sexo = dicAlumnos[nControl].pSexo;
            }

            return sexo;
        }

        public List<long> ListaIds()
        {
            List<long> listaIds = new List<long>();

            foreach (long ids in dicAlumnos.Keys)
            {
                listaIds.Add(ids);
            }

            return listaIds;
        }
    }
}
