using System;
using System.Configuration;
using System.Data.SqlClient;
using LibreriaBD;

namespace ConE.Datos
{
    public class Conexion
    {
        public static SqlConnection CrearConexion()
        {
            string strConn = GetConnectionString();
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

        public static string GetConnectionString()
        {
            string strConn = "";
            try
            {
                strConn = ConfigurationManager.ConnectionStrings["ControlEscolar"].ConnectionString;
            }
            catch (Exception)
            {

                throw;
            }
            return strConn;
        }
    }
}