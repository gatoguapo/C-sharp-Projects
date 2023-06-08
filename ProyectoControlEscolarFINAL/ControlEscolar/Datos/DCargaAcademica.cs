using System;
using System.Data;
using System.Data.SqlClient;
using ConE.Entidades;

namespace ConE.Datos
{
    public class DCargaAcademica
    {
        public static DataTable ObtenCargaAcademica()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("CargaAcademica_Listar", conn);
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
        public static DataTable BuscarEstudianteCarga(string buscar)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("NombreEstudianteCarga_Buscar", conn);
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

        public static string AgregaCargaAcademica(CargaAcademica cargaAcademica)
        {
            string Rpta = "";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("CargaAcademica_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //INSERCION
                comando.Parameters.AddWithValue("@claveEstudianteCA", cargaAcademica.pClaveEst);
                comando.Parameters.AddWithValue("@claveMateria1Ca", cargaAcademica.pCal1);
                if (cargaAcademica.pCal2.Equals(0))
                {
                    comando.Parameters.AddWithValue("@claveMateria2Ca", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@claveMateria2Ca", cargaAcademica.pCal2);
                }

                if (cargaAcademica.pCal3.Equals(0))
                {
                    comando.Parameters.AddWithValue("@claveMateria3Ca", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@claveMateria3Ca", cargaAcademica.pCal3);
                }

                if (cargaAcademica.pCal4.Equals(0))
                {
                    comando.Parameters.AddWithValue("@claveMateria4Ca", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@claveMateria4Ca", cargaAcademica.pCal4);
                }

                if (cargaAcademica.pCal5.Equals(0))
                {
                    comando.Parameters.AddWithValue("@claveMateria5Ca", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@claveMateria5Ca", cargaAcademica.pCal5);
                }
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            return Rpta;
        }

        public static string ExisteCarga(int clave)
        {
            SqlConnection conn = null;
            string Rpta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("CargaAcademica_Existe", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@clave", SqlDbType.Int).Value = clave;
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
