
namespace EMP_system
{
    partial class EmployeeDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Employe = new System.Windows.Forms.GroupBox();
            this.txtOutime = new System.Windows.Forms.DateTimePicker();
            this.txtIn = new System.Windows.Forms.DateTimePicker();
            this.txtDateoj = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDob = new System.Windows.Forms.DateTimePicker();
            this.txtWrk = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoj = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Employe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Details";
            // 
            // Employe
            // 
            this.Employe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Employe.BackColor = System.Drawing.Color.DarkCyan;
            this.Employe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employe.Controls.Add(this.txtOutime);
            this.Employe.Controls.Add(this.txtIn);
            this.Employe.Controls.Add(this.txtDateoj);
            this.Employe.Controls.Add(this.label11);
            this.Employe.Controls.Add(this.label12);
            this.Employe.Controls.Add(this.txtPosition);
            this.Employe.Controls.Add(this.btnClear);
            this.Employe.Controls.Add(this.label9);
            this.Employe.Controls.Add(this.comboBox1);
            this.Employe.Controls.Add(this.btnExit);
            this.Employe.Controls.Add(this.btnEdit);
            this.Employe.Controls.Add(this.btnDelete);
            this.Employe.Controls.Add(this.btnAdd);
            this.Employe.Controls.Add(this.txtDob);
            this.Employe.Controls.Add(this.txtWrk);
            this.Employe.Controls.Add(this.txtGender);
            this.Employe.Controls.Add(this.txtMail);
            this.Employe.Controls.Add(this.txtPhone);
            this.Employe.Controls.Add(this.txtAge);
            this.Employe.Controls.Add(this.txtName);
            this.Employe.Controls.Add(this.label7);
            this.Employe.Controls.Add(this.txtId);
            this.Employe.Controls.Add(this.label10);
            this.Employe.Controls.Add(this.label6);
            this.Employe.Controls.Add(this.txtDoj);
            this.Employe.Controls.Add(this.txtPos);
            this.Employe.Controls.Add(this.label8);
            this.Employe.Controls.Add(this.label5);
            this.Employe.Controls.Add(this.label4);
            this.Employe.Controls.Add(this.label3);
            this.Employe.Controls.Add(this.label2);
            this.Employe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employe.Location = new System.Drawing.Point(4, 53);
            this.Employe.Name = "Employe";
            this.Employe.Size = new System.Drawing.Size(784, 454);
            this.Employe.TabIndex = 1;
            this.Employe.TabStop = false;
            this.Employe.Text = "Employees";
            this.Employe.Enter += new System.EventHandler(this.Employe_Enter);
            // 
            // txtOutime
            // 
            this.txtOutime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutime.Checked = false;
            this.txtOutime.CustomFormat = "hh:mm:ss";
            this.txtOutime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtOutime.Location = new System.Drawing.Point(611, 344);
            this.txtOutime.Name = "txtOutime";
            this.txtOutime.Size = new System.Drawing.Size(147, 26);
            this.txtOutime.TabIndex = 12;
            this.txtOutime.ValueChanged += new System.EventHandler(this.txtOutime_ValueChanged);
            this.txtOutime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // txtIn
            // 
            this.txtIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIn.CustomFormat = "hh:mm:ss";
            this.txtIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtIn.Location = new System.Drawing.Point(611, 291);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(147, 26);
            this.txtIn.TabIndex = 11;
            this.txtIn.Value = new System.DateTime(2024, 7, 17, 11, 12, 0, 0);
            this.txtIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // txtDateoj
            // 
            this.txtDateoj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateoj.Location = new System.Drawing.Point(611, 241);
            this.txtDateoj.Name = "txtDateoj";
            this.txtDateoj.Size = new System.Drawing.Size(147, 26);
            this.txtDateoj.TabIndex = 10;
            this.txtDateoj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(493, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "In Time";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(479, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Out Time";
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPosition.FormattingEnabled = true;
            this.txtPosition.Items.AddRange(new object[] {
            "HR",
            "Manager",
            "Developer",
            "Employer"});
            this.txtPosition.Location = new System.Drawing.Point(611, 196);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(147, 27);
            this.txtPosition.TabIndex = 9;
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.Location = new System.Drawing.Point(522, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 42);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "User Information";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(382, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 27);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnExit.Location = new System.Drawing.Point(668, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "HOME";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.Location = new System.Drawing.Point(382, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 44);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Location = new System.Drawing.Point(233, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 42);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(79, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDob
            // 
            this.txtDob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDob.Location = new System.Drawing.Point(233, 297);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(143, 26);
            this.txtDob.TabIndex = 5;
            this.txtDob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // txtWrk
            // 
            this.txtWrk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWrk.FormattingEnabled = true;
            this.txtWrk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.txtWrk.Location = new System.Drawing.Point(611, 92);
            this.txtWrk.Name = "txtWrk";
            this.txtWrk.Size = new System.Drawing.Size(147, 27);
            this.txtWrk.TabIndex = 7;
            this.txtWrk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // txtGender
            // 
            this.txtGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(233, 347);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(143, 27);
            this.txtGender.TabIndex = 6;
            this.txtGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.Location = new System.Drawing.Point(233, 244);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(143, 26);
            this.txtMail.TabIndex = 4;
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(611, 147);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 26);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAge.Location = new System.Drawing.Point(233, 190);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(143, 26);
            this.txtAge.TabIndex = 3;
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(233, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 26);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "GENDER";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(233, 90);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 26);
            this.txtId.TabIndex = 1;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutime_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "PHONE NUMBER";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "DOB";
            // 
            // txtDoj
            // 
            this.txtDoj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoj.AutoSize = true;
            this.txtDoj.BackColor = System.Drawing.Color.White;
            this.txtDoj.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoj.Location = new System.Drawing.Point(518, 244);
            this.txtDoj.Name = "txtDoj";
            this.txtDoj.Size = new System.Drawing.Size(49, 23);
            this.txtDoj.TabIndex = 0;
            this.txtDoj.Text = "DOJ";
            // 
            // txtPos
            // 
            this.txtPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPos.AutoSize = true;
            this.txtPos.BackColor = System.Drawing.Color.White;
            this.txtPos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(463, 193);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(104, 23);
            this.txtPos.TabIndex = 0;
            this.txtPos.Text = "POSITION";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "WORKING DAYS";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "MAIL ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "AGE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "EMPLOYEE NAME";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(791, 519);
            this.Controls.Add(this.Employe);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Employe.ResumeLayout(false);
            this.Employe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Employe;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker txtDob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label txtDoj;
        private System.Windows.Forms.Label txtPos;
        private System.Windows.Forms.ComboBox txtPosition;
        private System.Windows.Forms.ComboBox txtWrk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtOutime;
        private System.Windows.Forms.DateTimePicker txtDateoj;
        private System.Windows.Forms.DateTimePicker txtIn;
    }
}