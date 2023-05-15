using System;
using System.Data;
using System.Data.SqlClient;
using ClinicaM.Entidades;

namespace ClinicaM.Datos
{
    public class DMedico
    {
        public static DataTable ObtenMedicos()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Medico_Listar", conn);
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

        public static string BuscaNombreMedico(string nombre)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Medico_ExisteNombre", conn);
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

        public static string BuscaClaveMedico(int clave)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Medico_ExisteClave", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
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

        public static string AgregarMedico(Medico medico)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Medico_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@clave", medico.pClave);
                comando.Parameters.AddWithValue("@nombre", medico.pNombre);
                comando.Parameters.AddWithValue("@especialidad", medico.pEspecialidad);
                comando.Parameters.AddWithValue("@subespecialidad", medico.pSubespecialidad);
                comando.Parameters.AddWithValue("@telefono", medico.pTelefono);
                comando.Parameters.AddWithValue("@consultorio", medico.pConsultorio);
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
