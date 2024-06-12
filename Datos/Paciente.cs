using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_SePrice.Datos
{
    internal class Paciente
    {
        public string Nuevo_Paciente(Paciente paciente)
        {
            string? salida;
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoPaciente", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idP", MySqlDbType.VarChar).Value =
                    0;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value =
                    paciente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value =
                    paciente.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value =
                    paciente.Dni;
                comando.Parameters.Add("Fnac", MySqlDbType.Date).Value =
                   paciente.FechaNac;
                //comando.Parameters.Add("Afis", MySqlDbType.Bit).Value = paciente.AptoFisico;

                MySqlParameter ParCodigo = new MySqlParameter();

                ParCodigo.ParameterName = "rta";

                ParCodigo.MySqlDbType = MySqlDbType.Int32;

                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlConn.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                { sqlConn.Close(); };
            }
            return salida;
        }
    }
}
