using System;
using System.Data;
using System.Data.SqlClient;
using ConE.Entidades;

namespace ConE.Datos
{
    public class DMateria
    {
        public static string AgregarMateria(Materia materia)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Materia_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombreMat", materia.pNombre);
                comando.Parameters.AddWithValue("@carreraMat", materia.pCveCarrera);
                comando.Parameters.AddWithValue("@creditosMat", materia.pCreditos);
                comando.Parameters.AddWithValue("@nombreMaestroMat", materia.pNomMaestro);
                comando.Parameters.AddWithValue("@horaMat", materia.pHora);
                comando.Parameters.AddWithValue("@alumnosInscritosMat", materia.pAlumnInsc);
                comando.Parameters.AddWithValue("@maxAlumnosMat", materia.pMaxAlumn);
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
        public static DataTable ObtenMaterias()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Materia_Listar", conn);
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
        public static string ExisteMateria(string nombre)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Materia_Existe", conn);
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
        public static DataTable BuscarMaterias(string buscar)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Materia_Buscar", conn);
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
        public static DataTable BuscarMateriasPorCarrera(int clave)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("MateriaCarrera_Buscar", conn);
                comando.Parameters.Add("@Clave", SqlDbType.Int).Value = clave;
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

        public static string ObtenerClaveMateria()
        {
            string clave = "";
            SqlConnection conn = new SqlConnection();

            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Materia_ObtenerIdentity", conn);
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

        public static string ActualizaMateria(int clave, Materia materia)
        {
            SqlConnection conn = null;
            string resp = "";

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("ActualizarMateria", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@claveMat", clave);
                comando.Parameters.AddWithValue("@nombre ", materia.pNombre);
                comando.Parameters.AddWithValue("@claveCarrera", materia.pCveCarrera);
                comando.Parameters.AddWithValue("@creditos", materia.pCreditos);
                comando.Parameters.AddWithValue("@nombreMaestro", materia.pNomMaestro);
                comando.Parameters.Add("@Hora", SqlDbType.Time).Value = materia.pHora;
                comando.Parameters.AddWithValue("@alumnosInsc", materia.pAlumnInsc);
                comando.Parameters.AddWithValue("@maxAlumnos", materia.pMaxAlumn);

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
