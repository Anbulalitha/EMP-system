
namespace EMP_system
{
    partial class EmployeeManagementSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementSystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EmployeeInf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 87);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.EmployeeInf);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Employee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 636);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 77);
            this.button3.TabIndex = 3;
            this.button3.Text = "Employee Monitoring System";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Employee Attendance";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit_KeyDown);
            // 
            // EmployeeInf
            // 
            this.EmployeeInf.AccessibleName = "EmployeeInf";
            this.EmployeeInf.BackColor = System.Drawing.Color.White;
            this.EmployeeInf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EmployeeInf.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInf.Location = new System.Drawing.Point(34, 401);
            this.EmployeeInf.Name = "EmployeeInf";
            this.EmployeeInf.Size = new System.Drawing.Size(128, 68);
            this.EmployeeInf.TabIndex = 5;
            this.EmployeeInf.Text = "Employee Information";
            this.EmployeeInf.UseVisualStyleBackColor = false;
            this.EmployeeInf.Click += new System.EventHandler(this.EmployeeInf_Click);
            this.EmployeeInf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Employee Salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit_KeyDown);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Exit";
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(49, 502);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 40);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit_KeyDown);
            // 
            // Employee
            // 
            this.Employee.AccessibleName = "Employee";
            this.Employee.BackColor = System.Drawing.Color.White;
            this.Employee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Employee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(34, 44);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(128, 64);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee Details";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            this.Employee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit_KeyDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(49, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // EmployeeManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManagementSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button EmployeeInf;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

