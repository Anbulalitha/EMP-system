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
    public partial class Employer : Form
    {
        private string loggedInUsername;


        public Employer(string username)
        {
            InitializeComponent();
            loggedInUsername = username;

        }

        private void Employer_Load(object sender, EventArgs e)
        {
            Change.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT E.id,E.name,E.age,E.mail,E.dob,E.gender,E.wrkdays,E.phone,E.position,E.doj,E.intime,E.Outime,A.status,M.TotalWrkHours,S.TotalSalary FROM Employee as E left join Attendance as A on E.id=A.id left join Salary as S on E.id=S.id left join Monitoring as M on E.id=M.id WHERE E.name = @loggedInUsername", Change.con);
            cmd.Parameters.AddWithValue("@loggedInUsername", loggedInUsername);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtId.Text = dr["ID"].ToString();
                txtName.Text = dr["Name"].ToString();
                txtGender.Text = dr["Gender"].ToString();
                txtMail.Text = dr["Mail"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtDob.Text = dr["Dob"].ToString();
                txtIn.Text = dr["Intime"].ToString();
                txtOut.Text = dr["Outime"].ToString();
                txtPos.Text = dr["Position"].ToString();
                txtTotal.Text=dr["TotalwrkHours"].ToString();
                txtSalary.Text=dr["TotalSalary"].ToString();
                txtDoj.Text = dr["doj"].ToString();
            }
            dr.Close();
            Change.con.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
