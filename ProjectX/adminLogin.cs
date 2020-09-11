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

namespace ProjectX
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHS\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from admin where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'  ", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (txtuser.Text != "" && txtpass.Text != "")
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successfull", "Done");
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Wrong");
                }

            }
            else
            {
                MessageBox.Show("Please fill both the fields", "??");
            }

            conn.Close();
        }
    }
}
