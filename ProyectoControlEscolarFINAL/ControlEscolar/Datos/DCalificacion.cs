using System;
using System.Data;
using System.Data.SqlClient;
using ConE.Entidades;

namespace ConE.Datos
{
    public class DCalificacion
    {
        public static DataTable ObtenCalificaciones()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Calificaciones_Listar", conn);
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
        public static string AgregarCalifcacion(Calificacion calificacion)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Calificacion_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@cveEstudianteCal", calificacion.pClaveEst);
                comando.Parameters.AddWithValue("@cveMateriaCal", calificacion.pClaveMat);
                comando.Parameters.AddWithValue("@calificacionCal", calificacion.pCal);
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
        public static DataTable BuscarEstudianteCal(string buscar)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("NombreEstudianteCal_Buscar", conn);
                comando.Parameters.Add("@Buscar", SqlDbType.VarChar).Value = buscar;
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

        public static string ExisteCalificacion(int cveEst, int cveMat)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Calificacion_Existe", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cveEstudiante", SqlDbType.Int).Value = cveEst;
                comando.Parameters.Add("@cveMateria", SqlDbType.Int).Value = cveMat;
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
