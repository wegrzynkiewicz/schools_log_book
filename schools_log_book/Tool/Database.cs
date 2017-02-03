using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var cmd = new MySqlCommand(sql, Connection);
            var reader = cmd.ExecuteReader();

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

        public static DataTable fetchData(string sql)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            MyDA.SelectCommand = new MySqlCommand(sql, Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            return table;
        }

        public static void execute(string sql)
        {
            var cmd = new MySqlCommand(sql, Connection);
            cmd.ExecuteNonQuery();
        }
    }
}
