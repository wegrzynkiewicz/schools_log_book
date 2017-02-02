using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SLB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                SLB.Tool.Database.Initialize();
                Application.Run(new SLB.View.LoginForm());
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show(
                    "Połączenie z bazą danych nie zostało zainicjalizowane: " + exception.Message,
                    "Wystąpił problem"
                );
            }
        }
    }
}
