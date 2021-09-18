using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxherRestauranti.DAL
{
    public class mydatabase
    {
        //Data source
        private static string _connectionString = ConfigurationManager.ConnectionStrings["MenaxherRestauranti"].ConnectionString;
        //SQL connection object
        public static SqlConnection Sqlconn()
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                return connection;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static SqlCommand Command(SqlConnection connection, string cmdText,CommandType commandType= CommandType.StoredProcedure)
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = CommandType.StoredProcedure;
            return command;

        }

        public static void AddParameter(SqlCommand command, string parameterName, object value)
        {
            SqlParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }
    }
}