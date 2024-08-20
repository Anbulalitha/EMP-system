using System;
using System.Data;
using System.Windows.Forms;

namespace EMP_system
{
    internal class ReportView
    {
        public string ReportName { get; internal set; }
        public DataTable ReportData { get; internal set; }
        internal void ShowDialog()
        {
            using (var reportViewerForm = new Form())
            {
                var reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
                reportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer.LocalReport.ReportPath = this.ReportName;

                var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("Employee", this.ReportData);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);

               
                reportViewer.Dock = DockStyle.Fill;
                reportViewerForm.Tag = reportViewer;
                reportViewer.BringToFront();
                reportViewerForm.Controls.Add(reportViewer);
                reportViewer.RefreshReport();
              

                reportViewerForm.ShowDialog();
            }
        }

    }
}