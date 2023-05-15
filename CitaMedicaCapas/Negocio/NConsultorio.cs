using ClinicaM.Datos;
using ClinicaM.Entidades;
using System.Data;

namespace ClinicaM.Negocio
{
    public class NConsultorio
    {
        public static DataTable ObtenConsultorios()
        {
            return DConsultorio.ObtenConsultorios();
        }

        public static string Agregar(Consultorio consultorio)
        {
            string existe = DConsultorio.ExisteConsultorioID(consultorio.pIdConsultorio);
            if (existe.Equals("1"))
            {
                return "Ya existe clave consultorio";

            }
            existe = DConsultorio.ExisteConsultorio(consultorio.pNombreConsultorio);
            if (existe.Equals("1"))
            {
                return "Ya existe nombre consultorio";

            }
            return DConsultorio.AgregarConsultorio(consultorio);
        }
    }
}
