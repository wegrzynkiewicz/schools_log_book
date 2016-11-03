using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SLB.Persistence
{
    public class Database
    {
        public static MySqlConnection Connection { get; private set; }

        public static void Initialize()
        {
            Connection = new MySqlConnection(
                "Server=localhost; database=_SLB; UID=root; password="
            );
        }
    }
}
