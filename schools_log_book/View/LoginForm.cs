using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLB.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void ContentFormClosed(Object sender, FormClosedEventArgs e)
        {
            this.loginTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.Show();
        }

        private void singInButton_Click(object sender, EventArgs e)
        {
            string login = this.loginTextBox.Text;
            string password = this.passwordTextBox.Text;

            try
            {
                var user = SLB.Domain.User.selectFromDatabaseByLogin(login, password);

                Form form = null;

                if (user.Type == "teacher")
                {
                    form = new SLB.View.TeacherForm(user.Name);
                }
                else if (user.Type == "student")
                {
                }
                else if (user.Type == "parent")
                {

                }

                form.Show();
                form.FormClosed += ContentFormClosed;
                this.Hide();
            }
            catch (UserNotFoundException exception)
            {
                var badlogin = new SLB.View.BadLoginForm();
                badlogin.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.singInButton.Focus();
        }
    }
}
