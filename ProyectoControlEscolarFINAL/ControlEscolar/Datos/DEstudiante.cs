using System;
using System.Data;
using System.Data.SqlClient;
using ConE.Entidades;

namespace ConE.Datos
{
    public class DEstudiante
    {
        public static DataTable ObtenEstudiantes()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Estudiante_Listar", conn);
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
        public static DataTable ObtenEstudiantesTotal()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("EstudiantesTotal_Listar", conn);
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
        public static string AgregarEstudiante(Estudiante estudiante)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Estudiante_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombreEstudiante", estudiante.pNombre);
                comando.Parameters.AddWithValue("@semestre", estudiante.pSemestre);
                comando.Parameters.AddWithValue("@carreraClave", estudiante.pCarrera);
                comando.Parameters.AddWithValue("@domicilioEstudiante", estudiante.pDomicilio);
                comando.Parameters.AddWithValue("@correoEstudiante", estudiante.pCorreo);
                comando.Parameters.AddWithValue("@telefonoEstudiante", estudiante.pTelefono);
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
        public static DataTable BuscarEstudiantes(string buscar)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Estudiante_Buscar", conn);
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
        public static string ExisteEstudiante(string nombre)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Estudiante_Existe", conn);
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

        public static string ObtenerClaveEstudiante()
        {
            string clave = "";
            SqlConnection conn = new SqlConnection();

            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Estudiante_ObtenerIdentity", conn);
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

        public static string ActualizaEstudiante(int clave, Estudiante estudiante)
        {
            SqlConnection conn = null;
            string resp = "";

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("ModificarEstudiante", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ClaveEstudiante", clave);
                comando.Parameters.AddWithValue("@NombreEst ", estudiante.pNombre);
                comando.Parameters.AddWithValue("@CarreraEst", estudiante.pCarrera);
                comando.Parameters.AddWithValue("@DomicilioEst", estudiante.pDomicilio);
                comando.Parameters.AddWithValue("@CorreoEst", estudiante.pCorreo);
                comando.Parameters.AddWithValue("@TelefonoEst", estudiante.pTelefono);

                resp = comando.ExecuteNonQuery() == 1 ? "OK" :
                    "No se pudo actualizar el registro";
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
            return resp;
        }
    }
}
