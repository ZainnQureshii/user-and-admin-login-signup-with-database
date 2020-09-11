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
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
        }
        SignUp su = new SignUp();

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHS\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");
            
        private void button1_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from users where username = '" + txtuser.Text + "' and password = '" + txtpass.Text + "'  ", conn);

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
            else {
                MessageBox.Show("Please fill both the fields","??");
            }

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            su.Show();
        }
    }
}
