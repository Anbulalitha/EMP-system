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
    public partial class Settings : Form
    {
        public bool CheckVal;
        public bool AddDt;
        public bool EditDt;
        public bool DelDt;
        public bool AddMS;
        public bool EditMS;
        public bool AddAt;
        public bool EditAt;
        public bool AddSal;
        public bool EditSal;
        public bool AddIn;
        public bool EditIn;
        public Panel Actpan;
        public Label btntemp;

        public Settings()
        {
            InitializeComponent();
            LoadPanel();
        }
       

        public void LoadPanel()
        {
            panelDetails.Visible = false;
            panelAtt.Visible = false;
            panelSalary.Visible = false;
            panelMs.Visible = false;
            panelInf.Visible = false;
        }
        public void RELoad()
        {
            btnDetails.Enabled = true;
            btnAttenance.Enabled = true;
            btnMs.Enabled = true;
            btnInformation.Enabled = true;
            btnSalary.Enabled = true;
        }
        public void LoadBtns()
        {
            btnDetails.Enabled = false;
            btnMs.Enabled = false;
            btnInformation.Enabled = false;
            btnSalary.Enabled = false;
            btnAttenance.Enabled = false;

        }
        public void ActPanel(Object btnact)
        {
            try
            {
                btntemp = (Label)btnact;
                if (Actpan.Visible == false)
                {
                    Actpan.Visible = true;
                    Actpan.BringToFront();
                    LoadBtns();
                    btntemp.Enabled = true;

                }
                else
                {
                    Actpan.Visible = false;
                    RELoad();
                }
            }
            catch { }
            finally
            {
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            try
            {
                Change.con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Permission values('" + txtRoll.Text.ToUpper() + "','" + AddDetails + "','" + EditDetails + "','" + DeleteDetails + "','" + AddAtten + "','" + EditAtten + "','" + AddMs + "','" + EditMs + "','" + AddInf + "','" + EditInf + "','" + AddSalary + "','" + EditSalary + "')", Change.con);

                cmd.ExecuteNonQuery();
                Change.con.Close();
                MessageBox.Show(txtRoll.Text + "Values Added Suceesfully.", "Added!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Change.con.Close();
            }
        }
      
        public Button Actbtn;
        public CheckBox cb;
        public bool ActCheckbox(Object ChckkAct)
        {
            cb = (CheckBox)ChckkAct;
            if (cb.Checked)
            {
                CheckVal = true;
            }
            else { CheckVal = false; }

            return CheckVal;
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            Actpan = panelDetails;
            ActPanel(sender);
        }

        private void btnAttenance_Click(object sender, EventArgs e)
        {
            Actpan = panelAtt;
            ActPanel(sender);
        }

        private void btnMs_Click(object sender, EventArgs e)
        {
            Actpan = panelMs;
            ActPanel(sender);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Actpan = panelSalary;
            ActPanel(sender);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Actpan = panelInf;
            ActPanel(sender);
        }

        private void AddDetails_CheckedChanged(object sender, EventArgs e)
        {
            AddDt = ActCheckbox(sender);
        }

        private void EditDetails_CheckedChanged(object sender, EventArgs e)
        {
            EditDt= ActCheckbox(sender);
        }

        private void DeleteDetails_CheckedChanged(object sender, EventArgs e)
        {
            DelDt= ActCheckbox(sender);
        }

        private void AddAtten_CheckedChanged(object sender, EventArgs e)
        {
            AddAt= ActCheckbox(sender);
        }

        private void EditAtten_CheckedChanged(object sender, EventArgs e)
        {
            EditAt= ActCheckbox(sender);
        }

        private void AddMs_CheckedChanged(object sender, EventArgs e)
        {
            AddMS= ActCheckbox(sender);
        }

        private void EditMs_CheckedChanged(object sender, EventArgs e)
        {
            EditMS= ActCheckbox(sender);
        }

        private void AddSalary_CheckedChanged(object sender, EventArgs e)
        {
            AddSal= ActCheckbox(sender);
        }

        private void EditSalary_CheckedChanged(object sender, EventArgs e)
        {
            EditSal= ActCheckbox(sender);
        }

        private void AddInf_CheckedChanged(object sender, EventArgs e)
        {
            AddIn= ActCheckbox(sender);
        }

        private void EditInf_CheckedChanged(object sender, EventArgs e)
        {
            EditIn= ActCheckbox(sender);
        }

       
    }
}
