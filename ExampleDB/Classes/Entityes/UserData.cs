using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDB.Classes.Entityes
{
    public class UserData
    {
        public int user_id;
        public string user_name;
        public string user_pass;
        public DateTime dateofbird;

        public UserData(DataRow row) {
            user_id = Convert.ToInt32(row["user_id"]);
            user_name = Convert.ToString(row["user_name"]);
            user_pass = Convert.ToString(row["user_pass"]);
            dateofbird = Convert.ToDateTime(row["dateofbird"]);
        }

        //UserData.Select();
        public static List<UserData> Select(string search)  {
            List<UserData> users = new List<UserData>();
            DataTable table = DbConnection.Select("SELECT * FROM users where `user_name` like @search;", 
                new List<DbParameter> {
                    new DbParameter("@search", "%"+search+"%") 
                });
            foreach (DataRow row in table.Rows) {
                users.Add(new UserData(row));
            }
            return users;
        }

      /*  public static UserData Select(int UserId) {
            if (table.Rows.Count > 0)
            {
                return new UserData(table.Rows[0]);
            }
            return null;
        }*/

        public static UserData Select(string user_name, string user_pass) {
            DataTable table = DbConnection.Select("Select * from `users` where `user_name` = @user_name and `user_pass` = @user_pass;", 
                new List<DbParameter> { 
                    new DbParameter("@user_name", user_name),
                    new DbParameter("@user_pass", user_pass)
                });
            if (table.Rows.Count > 0)
            {
                return new UserData(table.Rows[0]);
            }
            return null;
        }

        public static void Add(string user_name, string user_pass, DateTime dateofbird) {
            DbConnection.Select("INSERT INTO `users` (`user_name`, `user_pass`, `dateofbird`) VALUES (@user_name, @user_pass, @dateofbird);", 
                new List<DbParameter> { 
                    new DbParameter("@user_name", user_name),
                    new DbParameter("@user_pass", user_pass),
                    new DbParameter("@dateofbird", dateofbird)
                });
        }

        public void Delete() {
            DbConnection.Select("DELETE FROM `users` WHERE `user_id` = @user_id;",
                new List<DbParameter> { 
                    new DbParameter("@user_id", user_id)
                });
        }

        public void Edit(string user_name, string user_pass, DateTime dateofbird) {
            DbConnection.Select("UPDATE `users` SET `user_name` = @user_name, `user_pass` = @user_pass, `dateofbird` = @dateofbird WHERE (`user_id` = @user_id);",
                new List<DbParameter> {
                    new DbParameter("@user_name", user_name),
                    new DbParameter("@user_pass", user_pass),
                    new DbParameter("@dateofbird", dateofbird)
                });
            this.user_name = user_name;
            this.user_pass = user_pass;
            this.dateofbird = dateofbird;
        }
    }
}
