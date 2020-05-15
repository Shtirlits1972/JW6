using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JW6.Models
{
    public class UsersCrud
    {
        public static Users Login(string Email, string Pass)
        {
            Users model = null;

            if(Email == "admin@mail.ru" && Pass == "123")
            {
                model = new Users { email = "admin@mail.ru", Id = 1, pass = "123", role = "Админ", userFio = "Петров" };
            }

            return model;
        }
    }
}
