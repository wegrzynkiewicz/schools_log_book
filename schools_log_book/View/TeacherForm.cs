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
    public partial class TeacherForm : Form
    {
        public TeacherForm(string userName)
        {
            InitializeComponent();
            this.userNameLabel.Text = userName;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            string sql = "SELECT user_id, name, ROUND(AVG(oceny.wartosc), 2) FROM users LEFT JOIN oceny USING(user_id) WHERE type='student' GROUP BY user_id;";
            bindingSource.DataSource = SLB.Tool.Database.fetchData(sql);

            grid.DataSource = bindingSource;
            grid.Columns[0].HeaderText = "Numer";
            grid.Columns[1].HeaderText = "Imię i nazwisko";
            grid.Columns[1].Width = 300;
            grid.Columns[2].HeaderText = "Średnia ocen";
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string user_id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            string user_name = grid.Rows[e.RowIndex].Cells[1].Value.ToString();

            var form = new ManageStudentForm(user_id, user_name);
            form.Show();
        }
    }
}
