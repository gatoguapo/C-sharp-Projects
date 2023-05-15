using ClinicaM.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaM.Datos
{
    public class DCitaMedica
    {
        public static DataTable ObtenCitas()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {

                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("CitaMedica_Listar", conn);
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

        public static string AgregarCita(CitaMedica cita)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("CitaMedica_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@claveMedico", cita.pClaveMedico);
                comando.Parameters.AddWithValue("@fecha", cita.pFecha);
                comando.Parameters.AddWithValue("@hora", cita.pHora);
                comando.Parameters.AddWithValue("@pacienteNombre", cita.pNombre);
                comando.Parameters.AddWithValue("@telefono", cita.pTelefono);
                comando.Parameters.AddWithValue("@observaciones", cita.pObservaciones);
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

        public static string ExisteHora(int clave, string fecha, string hora)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            { 
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("CitaMedica_ExisteHora", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@claveMedico", SqlDbType.VarChar).Value = clave;
                comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                comando.Parameters.Add("@hora", SqlDbType.Time).Value = hora;
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
