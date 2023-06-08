using System.Data;
using ConE.Datos;
using ConE.Entidades;

namespace ConE.Negocio
{
    public class NEstudiante
    {
        public static DataTable ObtenEstudiante()
        {
            return DEstudiante.ObtenEstudiantes();
        }
        public static DataTable ObtenEstudiantesTotal()
        {
            return DEstudiante.ObtenEstudiantesTotal();
        }
        public static string Agregar(Estudiante estudiante)
        {
            string existe = DEstudiante.ExisteEstudiante(estudiante.pNombre);
            if (existe.Equals("1"))
            {
                return "Ya existe estudiante";

            }
            return DEstudiante.AgregarEstudiante(estudiante);
        }
        public static DataTable BuscarEstudiantes(string buscar)
        {
            return DEstudiante.BuscarEstudiantes(buscar);
        }
        public static string ObtenerClaveEstudiante()
        {
            return DEstudiante.ObtenerClaveEstudiante();
        }

        public static string ActualizaEstudiante(int clave, Estudiante estudiante)
        {
            return DEstudiante.ActualizaEstudiante(clave, estudiante);
        }
    }
}
