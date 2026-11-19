using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace module2._2
{

   
    public class DB
    {
        private string conn = "Host=localhost;Database=New_Demo_ex;username=postgres; password = wert";

        public NpgsqlDataReader ExecuteReader(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection(conn);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
           return  cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
