using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLB.Tool
{
    class Database
    {
        public static MySqlConnection Connection;

        public static void Initialize()
        {
            Connection = new MySqlConnection(File.ReadAllText("./database.cfg"));
            Connection.Open();
        }

        public static List<string> fetch(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            var list = new List<string>();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetString(i));
                }
            }

            reader.Close();

            return list;
        }
    }
}
