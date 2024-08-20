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
namespace EMP_system
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPsd.Text == "1234")
            {
                MessageBox.Show("Login successful as Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                EmployeeManagementSystem f = new EmployeeManagementSystem();
                f.FormClosed += (s, args) => this.Close();
                f.Show();
            }

            else if (txtUsername.Text != "" && txtPsd.Text != "")
            {
                string username = txtUsername.Text;
                Change.con.Open();
                SqlCommand cmd = new SqlCommand("select * from UserDetails where Name='" + txtUsername.Text + "' and Pass = '" + txtPsd.Text + "'", Change.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtUsername.Text = dr["Name"].ToString();
                    txtPsd.Text = dr["Pass"].ToString();
                    MessageBox.Show("Login successful as User", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dr.Close();
                    Change.con.Close();
                    this.Hide();
                    Employer f = new Employer(username);
                    f.FormClosed += (s, args) => this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Enter a valid username and password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPsd.Text = "";
                    return;
                }
            }
            
        }
            

        


            private void txtPsd_KeyDown_1(object sender, KeyEventArgs e)
              {
            if (e.KeyCode == Keys.Enter)
            {
                  SendKeys.Send("{Tab}");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPsd.UseSystemPasswordChar = true;
            }
            else
            {
                txtPsd.UseSystemPasswordChar = false;
            }
        }
    }
}
