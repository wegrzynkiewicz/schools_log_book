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
    public partial class InsertDegree : Form
    {
        public string user_id;

        public InsertDegree(string user_id, string user_name)
        {
            InitializeComponent();
            this.studentNameLabel.Text = user_name;
            this.user_id = user_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p = this.przedmiotTextBox.Text;
            string t = this.tematTextBox.Text;
            string s = this.stopienComboBox.Text;
            string d = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = "INSERT INTO oceny (user_id, przedmiot, temat, wartosc, data_wystawienia) VALUES (" + user_id + ",'" + p + "','" + t + "','" + s + "', '"+d+"')";
            SLB.Tool.Database.execute(sql);

            this.Close();
        }
    }
}
