using System.Data;
using ClinicaM.Datos;
using ClinicaM.Entidades;

namespace ClinicaM.Negocio
{
    public class NMedico
    {
        public static DataTable ObtenMedicos()
        {
            return DMedico.ObtenMedicos();
        }

        public static string Agregar(Medico medico)
        {
            string existe = DMedico.BuscaClaveMedico(medico.pClave);
            if (existe.Equals("1"))
            {
                return "Ya existe clave";

            }
            existe = DMedico.BuscaNombreMedico(medico.pNombre);
            if (existe.Equals("1"))
            {
                return "Ya existe nombre";
                
            }
            return DMedico.AgregarMedico(medico);
        }
    }
}
