using System;
using System.Data;
using System.Data.SqlClient;
using ConE.Entidades;

namespace ConE.Datos
{
    public class DCarrera
    {
        public static DataTable ObtenCarreras()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Carrera_Listar", conn);
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

        public static DataTable BuscarCarreras(string buscar)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Carrera_Buscar", conn);
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

        public static string ExisteCarrera(string nombre)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Carrera_Existe", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
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

        public static string AgregarCarrera(Carrera carrera)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Carrera_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombre", carrera.pNombre);
                comando.Parameters.AddWithValue("@fecha", carrera.pFecha);
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

        public static string ObtenerClaveCarrera()
        {
            string clave = "";
            SqlConnection conn = new SqlConnection();

            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Carrera_ObtenerIdentity", conn);
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter clavesql = new SqlParameter();
                clavesql.ParameterName = "@clave";
                clavesql.SqlDbType = SqlDbType.Int;
                clavesql.Direction = ParameterDirection.Output;
                comando.Parameters.Add(clavesql);
                comando.ExecuteNonQuery();
                clave = Convert.ToString(clavesql.Value);

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
            return clave;
        }

        public static string EliminarCarrera(int clave)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Carrera_Eliminada", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@claveCarr", clave);
                
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
    }
}
