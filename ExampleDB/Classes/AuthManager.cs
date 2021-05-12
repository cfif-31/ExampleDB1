using ExampleDB.Classes.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDB.Classes
{
    class AuthManager
    {
        public static UserData login_user;//Переменная для хранения авторизованного пользователя
        public static bool Autorizate(string user_login, string user_pass) {//Метод авторизации (логин, пароль)
            login_user = UserData.Select(user_login, user_pass);//Выбираем пользователя из базы по логину и паролю
            return login_user != null;//Возвращаем true, если пользователь авторизован
        }
    }
}
