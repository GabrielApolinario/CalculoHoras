using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CalculadoraHora.Data
{
    public class Data : IDisposable
    {
        private readonly MySqlConnection connStr;
        
        public Data()
        {
         connStr = new MySqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
         
        }

        public void ExecuteCommand(string StrQuery)
        {
            Data data = new Data();
            connStr.Open();
            var command = new MySqlCommand
            {
                CommandText = StrQuery,
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = connStr
            };

            command.ExecuteNonQuery();
        }

        public MySqlDataReader ReturnQuery(string StrQuery)
        {
            Data data = new Data();
            connStr.Open();

            var command = new MySqlCommand
            {
                CommandText = StrQuery,
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = connStr
            };

            return command.ExecuteReader();
            
        }

        public void Dispose()
        {
            connStr.Close();
        }

    }
}