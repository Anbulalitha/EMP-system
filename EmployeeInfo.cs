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
using Microsoft.Reporting.WinForms;
using System.IO;
namespace EMP_system
{
    public partial class EmployeeInfo : Form
    {

        public EmployeeInfo()
        {
            Change.con.Open();
            InitializeComponent();
        }

        private void showEmployes_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT E.id,E.name,E.age,E.mail,E.dob,E.gender,E.wrkdays,E.phone,E.position,E.doj,E.intime,E.Outime,A.status,M.TotalWrkHours,S.TotalSalary,E.IsDeleted FROM Employee as E left join Attendance as A on E.id=A.id left join Salary as S on E.id=S.id left join Monitoring as M on E.id=M.id", Change.con);
            
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



      

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee", Change.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Report_Final rpf = new Report_Final();
            Report_Final.dtw = dt;
            rpf.Show();
        }
        private void button7_Click(object sender, EventArgs e)
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

