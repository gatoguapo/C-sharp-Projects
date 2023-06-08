using System.Data;
using ConE.Datos;
using ConE.Entidades;

namespace ConE.Negocio
{
    public class NMateria
    {
        public static string Agregar(Materia materia)
        {
            string existe = DMateria.ExisteMateria(materia.pNombre);
            if (existe.Equals("1"))
            {
                return "Ya existe materia";

            }
            return DMateria.AgregarMateria(materia);
        }
        public static DataTable ObtenMaterias()
        {
            return DMateria.ObtenMaterias();
        }

        public static DataTable BuscarMaterias(string buscar)
        {
            return DMateria.BuscarMaterias(buscar);
        }
        public static DataTable BuscarMateriasPorCarrera(int clave)
        {
            return DMateria.BuscarMateriasPorCarrera(clave);
        }
        public static string ObtenerClaveMateria()
        {
            return DMateria.ObtenerClaveMateria();
        }

        public static string ActualizarMateria(int clave, Materia materia)
        {
            return DMateria.ActualizaMateria(clave, materia);
        }
    }
}
