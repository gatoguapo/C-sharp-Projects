using ClinicaM.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaM.Datos
{
    public class DConsultorio
    {
        public static string AgregarConsultorio(Consultorio consultorio)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Consultorio_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@consultorio", consultorio.pIdConsultorio);
                comando.Parameters.AddWithValue("@nombreConsultorio", consultorio.pNombreConsultorio);
                comando.Parameters.AddWithValue("@domicilio", consultorio.pDomicilio);
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" :
                    "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
            }
            return Rpta;
        }

        public static DataTable ObtenConsultorios()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Consultorio_Listar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
            }
        }

        public static string ExisteConsultorioID(int consultorio)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Consultorio_ExisteClave", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@consultorio", SqlDbType.VarChar).Value = consultorio;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    if (conn.State == ConnectionState.Open) conn.Close();
            }
            return Rpta;
        }

        public static string ExisteConsultorio(string consultorio)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Consultorio_ExisteNombre", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreConsultorio", SqlDbType.VarChar).Value = consultorio;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(parExiste.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                    if (conn.State == ConnectionState.Open) conn.Close();
            }
            return Rpta;
        }
    }
}
