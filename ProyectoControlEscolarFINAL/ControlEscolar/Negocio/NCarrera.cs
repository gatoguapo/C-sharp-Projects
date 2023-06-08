using System.Data;
using ConE.Datos;
using ConE.Entidades;

namespace ConE.Negocio
{
    public class NCarrera
    {
        public static DataTable ObtenCarreras()
        {
            return DCarrera.ObtenCarreras();
        }

        public static DataTable BuscarCarreras(string buscar)
        {
            return DCarrera.BuscarCarreras(buscar);
        }

        public static string Agregar(Carrera carrera)
        {
            string existe = DCarrera.ExisteCarrera(carrera.pNombre);
            if (existe.Equals("1"))
            {
                return "Ya existe carrera";

            }
            return DCarrera.AgregarCarrera(carrera);
        }

        public static string ObtenerClaveCarrera()
        {
            return DCarrera.ObtenerClaveCarrera();
        }

        public static string EliminarCarrera(int clave)
        {
            return DCarrera.EliminarCarrera(clave);
        }
    }
}
