using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace farihaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-EMJFMIA\\MSSQLSERVER01;Initial Catalog=MyProject;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string FirstName = tbFirstName.Text;
            string SecondName = tbSecondName.Text;

            string Query = "INSERT INTO Info (FirstName, SecondName) VALUES ('"+FirstName+"', '"+SecondName+ "')";

            SqlCommand cmd = new SqlCommand(Query, con);

            cmd.ExecuteNonQuery();

            con.Close();
             
            MessageBox.Show("Data has been Saved");

        }
    }
}
