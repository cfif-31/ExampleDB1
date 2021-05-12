using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDB.Classes
{
    public class DbParameter{
        public string name;
        public object value;

        public DbParameter(string name, object value) {
            this.name = name;
            this.value = value;
        }
    }

    class DbConnection
    {

        public static DataTable Select(string sql, List<DbParameter> parameters) {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.201.12";
            builder.Port = 3306;
            builder.Database = "testuser_test123";
            builder.UserID = "testuser";
            builder.Password = "test234";
            builder.CharacterSet = "utf8";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);

            foreach (DbParameter dbParameter in parameters) {
                command.Parameters.AddWithValue(dbParameter.name, dbParameter.value);
            }
            
            DataTable table = new DataTable();
            try
            {
                //Попытаемся
                connection.Open();
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex){
                //Если произошла ошибка
                Console.WriteLine("Bd Error! " + ex.Message);                
            }
            return table;
        }

    }
}
