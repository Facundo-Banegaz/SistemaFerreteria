using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Ferreteria.CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        private SqlTransaction transaccion;

        public SqlDataReader Lector => lector;

        public CD_Conexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conexion_DB"].ConnectionString;
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
        }

        public void SetConsulta(string consulta)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
        }

        public void SetConsultaProcedure(string procedimiento)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = procedimiento;
        }

        public void IniciarTransaccion()
        {
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
        }

        public void ConfirmarTransaccion()
        {
            transaccion?.Commit();
            CerrarConexion();
        }

        public void AnularTransaccion()
        {
            transaccion?.Rollback();
            CerrarConexion();
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch
            {
                throw; 
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                CerrarConexion();
                comando.Parameters.Clear(); // Limpia después de cada uso
            }
        }

        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor ?? DBNull.Value);
        }

        public void SetearParametroSalida(string nombre, SqlDbType tipoDato)
        {
            SqlParameter parametro = new SqlParameter(nombre, tipoDato)
            {
                Direction = ParameterDirection.Output
            };
            comando.Parameters.Add(parametro);
        }

        public int ObtenerValorParametroSalida(string nombre)
        {
            if (comando.Parameters.Contains(nombre))
            {
                return Convert.ToInt32(comando.Parameters[nombre].Value);
            }
            throw new ArgumentException($"El parámetro de salida '{nombre}' no existe.");
        }
        public object EjecutarEscalar()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                return comando.ExecuteScalar();
            }
            catch
            {
                throw;
            }
            finally
            {
                CerrarConexion();
                comando.Parameters.Clear(); // Limpia los parámetros luego de ejecutar
            }
        }

        public void CerrarConexion()
        {
            lector?.Close();
            lector?.Dispose();
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }

}
