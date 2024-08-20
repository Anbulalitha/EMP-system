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
    public partial class EmployeeDetails : Form
    {
      
        public EmployeeDetails()
        {
            InitializeComponent();
            
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            FillCombo();
        }
        private void Employe_Enter(object sender, EventArgs e)
        {
            //FillCombo();
            Clear();
            btnAdd.Enabled = true;

        }
        public  void BindData()
        {
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Employee]", Change.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
         
        }
        public void FillCombo()
        {
            string sql = "SELECT name FROM Employee WHERE not IsDeleted<>1 or isDeleted is null";
            SqlCommand cmd = new SqlCommand(sql, Change.con);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(DR);

                comboBox1.DisplayMember = "";
                comboBox1.ValueMember = "name";
                comboBox1.DataSource = dt;

                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (Change.con.State == ConnectionState.Open)
                Change.con.Close();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
           
        }

        public void DisplayComboData()
        {

            SqlCommand cmd = new SqlCommand ("SELECT * FROM Employee WHERE name=@name", Change.con);

            cmd.Parameters.AddWithValue("@name", comboBox1.Text);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    txtId.Text = DR["id"].ToString();
                    txtName.Text = DR["name"].ToString();
                    txtAge.Text = DR["age"].ToString();
                    txtMail.Text = DR["mail"].ToString();
                    txtDob.Text = DR["dob"].ToString();
                    txtGender.Text = DR["gender"].ToString();
                    txtWrk.Text = DR["wrkdays"].ToString();
                    txtPhone.Text = DR["phone"].ToString();
                    txtPosition.Text = DR["position"].ToString();
                    txtDateoj.Text = DR["doj"].ToString();
                    txtIn.Text = DR["intime"].ToString();
                    txtOutime.Text = DR["Outime"].ToString();
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (Change.con.State == ConnectionState.Open)
                Change.con.Close();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(txtAge.Text) ||
               string.IsNullOrWhiteSpace(txtMail.Text) ||
               string.IsNullOrWhiteSpace(txtDob.Text) ||
               string.IsNullOrWhiteSpace(txtGender.Text)||
               string.IsNullOrWhiteSpace(txtWrk.Text)||
                string.IsNullOrWhiteSpace(txtPhone.Text)||
                string.IsNullOrWhiteSpace(txtDateoj.Text)||
                string.IsNullOrWhiteSpace(txtIn.Text)||
                    string.IsNullOrWhiteSpace(txtOutime.Text))
            {
                MessageBox.Show("Fill All Fields.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee (name,age,mail,dob,gender,wrkdays,phone,position,doj,intime,Outime) values(@name,@age,@mail,@dob,@gender,@wrkdays,@phone,@position,@doj,@intime,@Outime)", Change.con);
                cmd.Parameters.AddWithValue("@name",txtName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txtDob.Text));
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@wrkdays", txtWrk.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@doj", DateTime.Parse(txtDateoj.Text));
                cmd.Parameters.AddWithValue("@intime", txtIn.Text);
                cmd.Parameters.AddWithValue("@Outime", txtOutime.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Values Added Suceesfully.", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
            finally{
                if (Change.con.State == ConnectionState.Open)
                    Change.con.Close(); }
            BindData();
            Clear();
          
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee set IsDeleted=1 where id=@id ", Change.con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(txtId.Text));

            cmd.ExecuteNonQuery();
            Change.con.Close();
            Clear();
            MessageBox.Show("Data Deleted.", "Deleted!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FillCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                DisplayComboData();
            }
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                 string.IsNullOrWhiteSpace(txtAge.Text) ||
                 string.IsNullOrWhiteSpace(txtMail.Text) ||
                 string.IsNullOrWhiteSpace(txtDob.Text) ||
                 string.IsNullOrWhiteSpace(txtGender.Text) ||
                 string.IsNullOrWhiteSpace(txtWrk.Text) ||
                  string.IsNullOrWhiteSpace(txtPhone.Text) ||
                  string.IsNullOrWhiteSpace(txtDateoj.Text) ||
                  string.IsNullOrWhiteSpace(txtIn.Text) ||
                   string.IsNullOrWhiteSpace(txtOutime.Text))
            {
                MessageBox.Show("Fill All Fields.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Change.con.Open();
            SqlCommand cmd = new SqlCommand("Update Employee set name=@name,age=@age,mail=@mail,dob=@dob,gender=@gender,wrkdays=@wrkdays,phone=@phone,position=@position,doj=@doj,intime=@intime,Outime=@Outime where id=@id", Change.con);
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txtDob.Text));
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@wrkdays", txtWrk.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@position", txtPosition.Text);
            cmd.Parameters.AddWithValue("@doj", DateTime.Parse(txtDateoj.Text));
            cmd.Parameters.AddWithValue("@intime", txtIn.Text);
            cmd.Parameters.AddWithValue("@Outime", txtOutime.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Edited.", "Edited!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Clear();
            Change.con.Close();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
          
        }

       

        private void txtOutime_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtMail.Text = "";
            txtDob.Text = "";
            txtGender.Text = "";
            txtWrk.Text = "";
            txtPhone.Text = "";
            txtPosition.Text = "";
            txtDateoj.Text = "";
            txtIn.Text = "";
            txtOutime.Text = "";
            btnAdd.Enabled = true;
        }

  

        private void txtOutime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        private bool IsSpecialCharacter(char c)
        {
            string specialCharacters = "!@#$%^&*()-_=+[]{};:'\"\\|<>,./?";
            return specialCharacters.Contains(c);
        }
        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLower(e.KeyChar) || char.IsDigit(e.KeyChar) || IsSpecialCharacter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length == 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

            private void btnExit_Click_1(object sender, EventArgs e)
            {
                this.Hide();
                EmployeeManagementSystem f = new EmployeeManagementSystem();
                f.FormClosed += (s, args) => this.Show();
                this.Close();
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
