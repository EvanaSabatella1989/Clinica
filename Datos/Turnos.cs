using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_SePrice.Datos
{
    internal class Turnos
    {
        public static DataTable ConsultaTurnos(DateTime fechaTurno, int idMedico)
        {
            string? salida;
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {

                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ConsultaTurnos", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("fTurno", MySqlDbType.VarChar).Value = fechaTurno;
                comando.Parameters.Add("idmed", MySqlDbType.VarChar).Value = idMedico;

                sqlConn.Open();
                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                salida = ex.Message;
                throw;
            }

            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

        }
        public static bool CrearTurno(int idMedico, int idPaciente, DateTime fechaTurno, string lugar, string estudio)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {

                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("CrearTurno", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idmedico", MySqlDbType.Int64).Value = idMedico;
                comando.Parameters.Add("idPaciente", MySqlDbType.Float).Value = idPaciente;
                comando.Parameters.Add("fturno", MySqlDbType.Date).Value = fechaTurno;
                comando.Parameters.Add("lugar", MySqlDbType.VarChar).Value = lugar;
                comando.Parameters.Add("estudio", MySqlDbType.VarChar).Value = estudio;
                sqlConn.Open();
                int cantModificaciones = comando.ExecuteNonQuery();

                return cantModificaciones > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }
    }

}

