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
    public partial class Employee_Attenance : Form
    {
        public Employee_Attenance()
        {
            InitializeComponent();
        }
        public void FillCombo()
        {
            Change.con.Open();
            string sql = "SELECT  id from [Employee]";
            SqlCommand cmd = new SqlCommand(sql, Change.con);

            try
            {
                if (Change.con.State != ConnectionState.Open)
                    Change.con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(DR);

                txtId.DisplayMember = "id";
                txtId.ValueMember = "id";
                txtId.DataSource = dt;

                txtId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
          
                Change.con.Close();
        }

        
        public void Clear()
        {
            txtId.Text = "";
            txtStatus.Text = "";
           
        }

        private void Employee_Attenance_Load(object sender, EventArgs e)
        {
            FillCombo();
            datagridview();
            Clear();
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("insert into Attendance (id,status,date) values (@id,@status,@date)", Change.con);
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(txtDate.Text));
            cmd.ExecuteNonQuery();
            Change.con.Close();
            MessageBox.Show("Values Added SucessFully", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Change.con.Open();
            datagridview();
            Clear();
        }

        private void txtUpdate_Click_1(object sender, EventArgs e)
        {
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("update Attendance set status=@status,date=@date where id=@id", Change.con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(txtDate.Text));
            cmd.ExecuteNonQuery();
            Change.con.Close();
            MessageBox.Show("Values Edited SucessFully", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            datagridview();
            Clear();
        }

        public void datagridview()
        {
            SqlCommand cmd = new SqlCommand("Select E.id,E.name,E.position,E.intime,E.Outime,E.wrkdays,A.date,A.status from Employee as E left join Attendance as A on E.id=A.id", Change.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeManagementSystem f = new EmployeeManagementSystem();
            f.FormClosed += (s, args) => this.Show();
            this.Close();

        }

        
        }
    }

