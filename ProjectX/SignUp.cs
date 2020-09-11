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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHS\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtuser.Text != "" && txtpass.Text != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT into users values('" + txtuser.Text + "','" + txtpass.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull", "Done");
            }
            else
            {
                MessageBox.Show("Please fill both the fields", "??");
            }
            conn.Close();
        }

    }
}
