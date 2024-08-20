using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EMP_system
{
    public partial class Report_Final : Form
    {
        public Report_Final()
        {
            InitializeComponent();
        }
    
        public static DataTable dtw = new DataTable();

        private void Report_Final_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rpt = new ReportDataSource("Employee", dtw);
            reportViewer1.LocalReport.DataSources.Add(rpt);
            reportViewer1.LocalReport.ReportPath = @"D:\Anbulalitha\EMPLOYEE MANAGEMENT SYSTEM\EMP system\EMP system\Report1.rdlc";
            reportViewer1.RefreshReport();

           this.WindowState = FormWindowState.Maximized;
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
