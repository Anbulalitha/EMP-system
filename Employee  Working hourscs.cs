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
    public partial class Employee__Working_hourscs : Form
    {
        public Employee__Working_hourscs()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anbulalitha\EMPLOYEE MANAGEMENT SYSTEM\EMP system\EMP system\Db.mdf;Integrated Security=True");

        public void FillCombo()
        {
            string sql = "SELECT  id from [Employee]";
            SqlCommand cmd = new SqlCommand(sql, con);

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlDataReader DR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(DR);

                txtEId.DisplayMember = "id";
                txtEId.ValueMember = "id";
                txtEId.DataSource = dt;
                txtEId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public void DisplayComboData()
        {

            SqlCommand cmd = new SqlCommand("SELECT id,intime,Outime FROM Employee WHERE id=@id", con);

            cmd.Parameters.AddWithValue("@id", txtEId.Text);

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    txtEId.Text = DR["id"].ToString();
                    txtIn.Text = DR["intime"].ToString();
                    txtOut.Text = DR["Outime"].ToString();
                }
                DR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (con.State == ConnectionState.Open)
                con.Close();

        }

        private void Employee__Working_hourscs_Load(object sender, EventArgs e)
        {
            FillCombo();
            datagridview();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void datagridview()
        {

            SqlCommand cmd = new SqlCommand("Select E.id,E.name,E.intime,E.Outime,E.position,M.WrkHours,M.Permission,M.Overtime,M.TotalWrkHours from Employee as E left join Attendance as A on E.id=A.id left join Monitoring as M on E.id=M.id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime intime = Convert.ToDateTime(txtIn.Text);
            DateTime outime = Convert.ToDateTime(txtOut.Text);
            DateTime intime12 = intime.AddHours(-12);
            TimeSpan work = outime - intime12;
            txtWrkHrs.Text = work.ToString();

            TimeSpan wrk = TimeSpan.Parse(txtWrkHrs.Text);
            TimeSpan over = TimeSpan.Parse(txtOver.Text);
            TimeSpan perm = TimeSpan.Parse(txtPermision.Text);
            TimeSpan total;

            if (perm > TimeSpan.FromHours(4))
            {
                total = wrk + over - perm;
            }
            else
            {
                total = wrk + over;
            }
            txtTotal.Text = total.ToString((@"hh\:mm\:ss"));

        }



        private void txtEId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayComboData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Monitoring (id,Permission,Overtime,WrkHours,TotalwrkHours) values (@id,@Permission, @Overtime,@WrkHours,@TotalwrkHours) ", con);
            cmd.Parameters.AddWithValue("@id", txtEId.Text);
            cmd.Parameters.AddWithValue("@Permission", txtPermision.Text);
            cmd.Parameters.AddWithValue("@Overtime", txtOver.Text);
            cmd.Parameters.AddWithValue("@WrkHours", TimeSpan.Parse(txtWrkHrs.Text));
            cmd.Parameters.AddWithValue("@TotalwrkHours", txtTotal.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Values Added SucessFully", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            datagridview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Monitoring set  Permission=@Permission,Overtime=@Overtime,WrkHours=@WrkHours,TotalwrkHours=@TotalwrkHours where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", txtEId.Text);
            cmd.Parameters.AddWithValue("@Permission", txtPermision.Text);
            cmd.Parameters.AddWithValue("@Overtime", txtOver.Text);
            cmd.Parameters.AddWithValue("@WrkHours", TimeSpan.Parse(txtWrkHrs.Text));
            cmd.Parameters.AddWithValue("@TotalwrkHours", txtTotal.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Values Updated SucessFully", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            datagridview();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeManagementSystem f = new EmployeeManagementSystem();
            f.FormClosed += (s, args) => this.Show();
            this.Close();
        }

        private void txtOut_KeyDown(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Enter)
                {
                    SendKeys.Send("{Tab}");
                }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtEId.Text = row.Cells["Id"].Value.ToString();
                txtIn.Text = row.Cells["intime"].Value.ToString();
                txtOut.Text = row.Cells["Outime"].Value.ToString();
                txtOver.Text = row.Cells["Overtime"].Value.ToString();
                txtPermision.Text = row.Cells["Permission"].Value.ToString();
                txtTotal.Text=row.Cells["TotalWrkHours"].Value.ToString();
            }

        }
    }
}
