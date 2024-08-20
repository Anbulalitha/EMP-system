using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMP_system
{
    public partial class EmployeeManagementSystem : Form
    {
      
        public EmployeeManagementSystem()
        {
            InitializeComponent();
           
        }
       
   

        private void Employee_Click(object sender, EventArgs e)
        {
           // this.Hide();
            EmployeeDetails EmployeeInfo = new EmployeeDetails();
            EmployeeInfo.FormClosed += (s, args) => this.Show();
            EmployeeInfo.Show();

        }

        private void EmployeeInf_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeInfo EmployeeInfo = new EmployeeInfo();
            EmployeeInfo.FormClosed += (s, args) => this.Show();
            EmployeeInfo.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary EmployeeInfo = new Salary();
            EmployeeInfo.FormClosed += (s, args) => this.Show();
            EmployeeInfo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Attenance EmployeeInfo = new Employee_Attenance();
            EmployeeInfo.FormClosed += (s, args) => this.Show();
            EmployeeInfo.Show();
        }

        private void Exit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, false, false, false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee__Working_hourscs EmployeeInfo = new Employee__Working_hourscs();
            EmployeeInfo.FormClosed += (s, args) => this.Show();
            EmployeeInfo.Show();
        }
    }
}
