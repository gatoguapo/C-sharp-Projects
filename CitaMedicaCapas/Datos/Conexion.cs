using System;
using System.Data.SqlClient;
using LibreriaBD;

namespace ClinicaM.Datos
{
    public class Conexion
    {
        public static SqlConnection CrearConexion()
        {
            string strConn = "Data Source=DESKTOP-2U8N1I5;Initial Catalog=ClinicaMedica;Integrated Security=True";
            SqlConnection conn;
            try
            {
                conn = UsoBD.ConectaBD(strConn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }
    }
}
