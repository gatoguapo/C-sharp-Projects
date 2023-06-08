using System.Data;
using ConE.Datos;
using ConE.Entidades;

namespace ConE.Negocio
{
    public class NCargaAcademica
    {
        public static DataTable ObtenCargaAcademica()
        {
            return DCargaAcademica.ObtenCargaAcademica();
        }

        public static DataTable BuscarEstudianteCarga(string buscar)
        {
            return DCargaAcademica.BuscarEstudianteCarga(buscar);
        }

        public static string AgregaCargaAcademica(CargaAcademica cargaAcademica)
        {
            string existe = DCargaAcademica.ExisteCarga(cargaAcademica.pClaveEst);
            if (existe.Equals("1"))
            {
                return "Ya existe carga";

            }
            return DCargaAcademica.AgregaCargaAcademica(cargaAcademica);
        }
    }
}
