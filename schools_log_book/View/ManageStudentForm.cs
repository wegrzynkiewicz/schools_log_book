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
    public partial class ManageStudentForm : Form
    {
        public string user_id;
        public string user_name;

        public ManageStudentForm(string user_id, string user_name)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.user_name = user_name;

            this.studentLabel.Text = user_name;
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            string sql = "SELECT przedmiot, temat, wartosc, data_wystawienia FROM oceny WHERE user_id='" + user_id + "' ORDER BY data_wystawienia ASC;";
            bindingSource.DataSource = SLB.Tool.Database.fetchData(sql);

            grid.DataSource = bindingSource;
            grid.Columns[0].HeaderText = "Przedmiot";
            grid.Columns[0].Width = 200;
            grid.Columns[1].HeaderText = "Temat";
            grid.Columns[1].Width = 300;
            grid.Columns[2].HeaderText = "Ocena";
            grid.Columns[3].HeaderText = "Data wystawienia";
            grid.Columns[3].Width = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new InsertDegree(this.user_id, this.user_name);
            form.Show();
            form.FormClosed += ManageStudentForm_Load;
        }
    }
}
