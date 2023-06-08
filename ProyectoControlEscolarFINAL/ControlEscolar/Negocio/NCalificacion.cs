using System.Data;
using ConE.Datos;
using ConE.Entidades;

namespace ConE.Negocio
{
    public class NCalificacion
    {
        public static DataTable ObtenCalificaciones()
        {
            return DCalificacion.ObtenCalificaciones();
        }

        public static string Agregar(Calificacion calificacion)
        {
            string existe = DCalificacion.ExisteCalificacion(calificacion.pClaveEst, calificacion.pClaveMat);
            if (existe.Equals("1"))
            {
                return "Ya existe calificacion";

            }
            return DCalificacion.AgregarCalifcacion(calificacion);
        }
        public static DataTable BuscarEstudianteCal(string buscar)
        {
            return DCalificacion.BuscarEstudianteCal(buscar);
        }
    }
}
