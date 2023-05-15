using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibreriaBD
{
    public class UsoBD
    {
        public static SqlException ESalida;
        public static SqlConnection ConectaBD(String strConec)
        {

            SqlConnection conn = new SqlConnection(strConec);
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {

                ESalida = ex;
                return null;
            }

            return conn;
        }

        static public SqlDataReader Consulta(String instrSelect, SqlConnection conn)
        {
            SqlDataReader lector = null;

            SqlCommand cmd = new SqlCommand(instrSelect, conn);
            try
            {
                lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                ESalida = ex;
                conn.Close();
                return null;
            }
            return lector;
        }
    }

}