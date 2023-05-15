using ClinicaM.Datos;
using ClinicaM.Entidades;
using System.Data;

namespace ClinicaM.Negocio
{
    public class NCitaMedica
    {
        public static DataTable ObtenCitas()
        {
            return DCitaMedica.ObtenCitas();
        }

        public static string Agregar(CitaMedica cita)
        {
            string existe = DCitaMedica.ExisteHora(cita.pClaveMedico, cita.pFecha, cita.pHora);
            if (existe.Equals("1"))
            {
                return "Ya existe cita";

            }
            return DCitaMedica.AgregarCita(cita);
        }
    }
}
