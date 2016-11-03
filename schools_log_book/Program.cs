using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLB.Domain.Student;
using SLB.View.Login;
using SLB.Persistence;

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
                Database.Initialize();
                Database.Connection.Open();
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                MessageBox.Show(
                    "Przepraszamy, połączenie z bazą danych nie zostało zainicjalizowane, proszę spróbować później",
                    "Wystąpił problem"
                );

                throw exception;
            }

            Application.Run(new LoginForm());
        }
    }
}
