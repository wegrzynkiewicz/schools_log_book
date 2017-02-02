using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.Domain
{
    class User
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        public static User selectFromDatabaseByLogin(string login, string password)
        {
            var sql = "SELECT name, type FROM users WHERE login = '" + login + "' and password = '" + password + "'";
            var list = SLB.Tool.Database.fetch(sql);

            if (list.Count == 0)
            {
                throw new UserNotFoundException();
            }

            return new User()
            {
                Name = list[0],
                Type = list[1]
            };
        }
    }
}
