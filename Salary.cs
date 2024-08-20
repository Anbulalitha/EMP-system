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
    public partial class Salary : Form
    {
        public Salary()
        {
           
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillCombo();
            FillCombobox();
            Clear();
            btnCalculate.Enabled = false;
        }


        public void FillCombo()
        {
            string sql = "SELECT id,name,wrkdays,position FROM [Employee]";
            SqlCommand cmd = new SqlCommand(sql, Change.con);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(DR);

                comboBox.DisplayMember = "id";
                comboBox.ValueMember = "id";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (Change.con.State == ConnectionState.Open)
                Change.con.Close();
            
        }

        public void DisplayComboData()
        {

            SqlCommand cmd = new SqlCommand("SELECT id,name,wrkdays,position FROM [Employee] WHERE id=@id", Change.con);

            cmd.Parameters.AddWithValue("@id", comboBox.Text);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    comboBox.Text = DR["id"].ToString();
                    txtName.Text = DR["name"].ToString();
                    txtWrkDays.Text = DR["wrkdays"].ToString();
                    txtPosition.Text = DR["position"].ToString();
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
        public void FillCombobox()
        {
            string sql = "SELECT id,TotalWrkHours FROM Monitoring";
            SqlCommand cmd = new SqlCommand(sql, Change.con);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(DR);

                comboBox.DisplayMember = "id";
                comboBox.ValueMember = "id";
                comboBox.DataSource = dt;

                comboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (Change.con.State == ConnectionState.Open)
                Change.con.Close();
        }
        public void DisplayComboDatabox()
        {

            SqlCommand cmd = new SqlCommand("SELECT id,TotalWrkHours FROM Monitoring WHERE id=@id", Change.con);

            cmd.Parameters.AddWithValue("@id", comboBox.Text);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    comboBox.Text = DR["id"].ToString();
                    txtWrkTotal.Text = DR["TotalWrkHours"].ToString();
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DisplayComboData();
                DisplayComboDatabox();

            btnCalculate.Enabled = true;

        }

        public void Clear() {
            comboBox.Text = "";
            txtName.Text = "";
            txtWrkDays.Text = "";
            txtPosition.Text = "";
            txtTotalSalary.Text = "";
            txtWrkTotal.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

       

       
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

            //HR-1500-(30)-45000
            //Dev-1000-30000
            //Manager-2000-60000
            //Emp-700-21000

            
            TimeSpan wrkTotal = TimeSpan.Parse(txtWrkTotal.Text);
            TimeSpan wrkDays = TimeSpan.Parse(txtWrkDays.Text);

            int totalHours = (int)wrkTotal.TotalHours;  
            int totalDays = (int)wrkDays.TotalDays;     

            int hr = 150 * totalHours * totalDays;
            int employee = 70 * totalHours * totalDays;
            int developer = 100 * totalHours * totalDays;
            int manager = 200 * totalHours * totalDays;

            if (txtPosition.Text == "HR")
            {
                txtTotalSalary.Text = Convert.ToString(hr);
            }
            else if (txtPosition.Text == "Manager")
            {
                txtTotalSalary.Text = Convert.ToString(manager);
            }
            else if (txtPosition.Text == "Employer")
            {
                txtTotalSalary.Text = Convert.ToString(employee);
            }
            else 
            {
                txtTotalSalary.Text = Convert.ToString(developer);
            }
        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("insert into Salary (id,totalsalary) values (@id,@TotalSalary)", Change.con);
            cmd.Parameters.AddWithValue("@id", comboBox.Text);
            cmd.Parameters.AddWithValue("@TotalSalary", txtTotalSalary.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Values Added SucessFully", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Change.con.Close();
            Clear();
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("update Salary set id=@id ,TotalSalary=@TotalSalary where id=@id", Change.con);
            cmd.Parameters.AddWithValue("@id", comboBox.Text);
            cmd.Parameters.AddWithValue("@TotalSalary", txtTotalSalary.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Values Update SucessFully", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Change.con.Close();
            Clear();
        }

        

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeManagementSystem f = new EmployeeManagementSystem();
            f.FormClosed += (s, args) => this.Show();
            this.Close();
        }
    }

   
}
