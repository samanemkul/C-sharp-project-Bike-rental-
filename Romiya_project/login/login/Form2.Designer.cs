//<<<<<<< HEAD
namespace login
{
    partial class RegisterForm
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
            this.back = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdob = new System.Windows.Forms.Label();
            this.txtxstatus = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.back.Location = new System.Drawing.Point(549, 332);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 17);
            this.back.TabIndex = 19;
            this.back.Text = "Back to LOGIN";
            this.back.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(505, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Already Have an Account";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "REGISTER";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(225, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Register a new membership";
            // 
            // txtfirstname
            // 
            this.txtfirstname.BackColor = System.Drawing.Color.White;
            this.txtfirstname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtfirstname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtfirstname.Location = new System.Drawing.Point(12, 69);
            this.txtfirstname.Multiline = true;
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.PasswordChar = '•';
            this.txtfirstname.Size = new System.Drawing.Size(198, 25);
            this.txtfirstname.TabIndex = 200;
            this.txtfirstname.Text = "first name";
            this.txtfirstname.UseSystemPasswordChar = true;
            this.txtfirstname.Enter += new System.EventHandler(this.txtfirstname_Enter);
            this.txtfirstname.Leave += new System.EventHandler(this.txtfirstname_Leave_1);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtusername.Location = new System.Drawing.Point(225, 210);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '•';
            this.txtusername.Size = new System.Drawing.Size(198, 25);
            this.txtusername.TabIndex = 14;
            this.txtusername.Text = "username";
            this.txtusername.UseSystemPasswordChar = true;
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.BackColor = System.Drawing.Color.White;
            this.txtmiddlename.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmiddlename.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtmiddlename.Location = new System.Drawing.Point(225, 69);
            this.txtmiddlename.Multiline = true;
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.PasswordChar = '•';
            this.txtmiddlename.Size = new System.Drawing.Size(198, 25);
            this.txtmiddlename.TabIndex = 14;
            this.txtmiddlename.Text = "middle name";
            this.txtmiddlename.UseSystemPasswordChar = true;
            this.txtmiddlename.Enter += new System.EventHandler(this.txtmiddlename_Enter);
            this.txtmiddlename.Leave += new System.EventHandler(this.txtmiddlename_Leave);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtaddress.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtaddress.Location = new System.Drawing.Point(12, 116);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '•';
            this.txtaddress.Size = new System.Drawing.Size(298, 25);
            this.txtaddress.TabIndex = 14;
            this.txtaddress.Text = "complete address";
            this.txtaddress.UseSystemPasswordChar = true;
            this.txtaddress.Enter += new System.EventHandler(this.txtaddress_Enter);
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtemail.Location = new System.Drawing.Point(326, 116);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '•';
            this.txtemail.Size = new System.Drawing.Size(310, 25);
            this.txtemail.TabIndex = 14;
            this.txtemail.Text = "email address";
            this.txtemail.UseSystemPasswordChar = true;
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            this.txtnumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnumber.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtnumber.Location = new System.Drawing.Point(12, 163);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.PasswordChar = '•';
            this.txtnumber.Size = new System.Drawing.Size(188, 25);
            this.txtnumber.TabIndex = 14;
            this.txtnumber.Text = "contact number";
            this.txtnumber.UseSystemPasswordChar = true;
            this.txtnumber.Enter += new System.EventHandler(this.txtnumber_Enter);
            this.txtnumber.Leave += new System.EventHandler(this.txtnumber_Leave);
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.White;
            this.txtlastname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtlastname.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtlastname.Location = new System.Drawing.Point(438, 69);
            this.txtlastname.Multiline = true;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.PasswordChar = '•';
            this.txtlastname.Size = new System.Drawing.Size(198, 25);
            this.txtlastname.TabIndex = 14;
            this.txtlastname.Text = "last name";
            this.txtlastname.UseSystemPasswordChar = true;
            this.txtlastname.Enter += new System.EventHandler(this.txtlastname_Enter);
            this.txtlastname.Leave += new System.EventHandler(this.txtlastname_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtpassword.Location = new System.Drawing.Point(438, 210);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(197, 25);
            this.txtpassword.TabIndex = 14;
            this.txtpassword.Text = "password";
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgender.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.txtgender.Location = new System.Drawing.Point(399, 163);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(135, 25);
            this.txtgender.TabIndex = 22;
            this.txtgender.Text = "gender";
            this.txtgender.Enter += new System.EventHandler(this.txtgender_Enter);
            this.txtgender.Leave += new System.EventHandler(this.txtgender_Leave);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.White;
            this.age.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.age.Location = new System.Drawing.Point(549, 163);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.PasswordChar = '•';
            this.age.Size = new System.Drawing.Size(87, 25);
            this.age.TabIndex = 14;
            this.age.Text = "age";
            this.age.UseSystemPasswordChar = true;
            this.age.Enter += new System.EventHandler(this.age_Enter);
            this.age.Leave += new System.EventHandler(this.age_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy / mm / dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 10, 17, 45, 29, 0);
            // 
            // txtdob
            // 
            this.txtdob.AutoSize = true;
            this.txtdob.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdob.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtdob.Location = new System.Drawing.Point(12, 192);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(68, 17);
            this.txtdob.TabIndex = 24;
            this.txtdob.Text = "Birth Date:";
            // 
            // txtxstatus
            // 
            this.txtxstatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtxstatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtxstatus.FormattingEnabled = true;
            this.txtxstatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.txtxstatus.Location = new System.Drawing.Point(215, 163);
            this.txtxstatus.Name = "txtxstatus";
            this.txtxstatus.Size = new System.Drawing.Size(169, 25);
            this.txtxstatus.TabIndex = 22;
            this.txtxstatus.Text = "civil status";
            this.txtxstatus.Enter += new System.EventHandler(this.txtxstatus_Enter);
            this.txtxstatus.Leave += new System.EventHandler(this.txtxstatus_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 201;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 358);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtxstatus);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.age);
            this.Controls.Add(this.txtfirstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label8;
        private Button button1;
        private Label label6;
        private TextBox txtfirstname;
        private Label back;
        private TextBox txtusername;
        private TextBox txtmiddlename;
        private TextBox txtaddress;
        private TextBox txtemail;
        private TextBox txtnumber;
        private TextBox txtlastname;
        private TextBox txtpassword;
        private ComboBox txtgender;
        private TextBox age;
        private DateTimePicker dateTimePicker1;
        private Label txtdob;
        private ComboBox txtxstatus;
        private PictureBox pictureBox2;
    }
//=======
//namespace login
//{
//    partial class Form2
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
//            this.back = new System.Windows.Forms.Label();
//            this.CheckbxShowPas = new System.Windows.Forms.CheckBox();
//            this.label8 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.txtpassword = new System.Windows.Forms.TextBox();
//            this.txtusername = new System.Windows.Forms.TextBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.txtComPassword = new System.Windows.Forms.TextBox();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // back
//            // 
//            this.back.AutoSize = true;
//            this.back.BackColor = System.Drawing.Color.White;
//            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.back.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.back.ForeColor = System.Drawing.Color.DarkSlateBlue;
//            this.back.Location = new System.Drawing.Point(92, 474);
//            this.back.Name = "back";
//            this.back.Size = new System.Drawing.Size(97, 17);
//            this.back.TabIndex = 19;
//            this.back.Text = "Back to LOGIN";
//            this.back.Click += new System.EventHandler(this.label7_Click);
//            // 
//            // CheckbxShowPas
//            // 
//            this.CheckbxShowPas.AutoSize = true;
//            this.CheckbxShowPas.BackColor = System.Drawing.Color.White;
//            this.CheckbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.CheckbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.CheckbxShowPas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.CheckbxShowPas.ForeColor = System.Drawing.Color.DarkGray;
//            this.CheckbxShowPas.Location = new System.Drawing.Point(161, 335);
//            this.CheckbxShowPas.Name = "CheckbxShowPas";
//            this.CheckbxShowPas.Size = new System.Drawing.Size(89, 15);
//            this.CheckbxShowPas.TabIndex = 20;
//            this.CheckbxShowPas.Text = "Show Password";
//            this.CheckbxShowPas.UseVisualStyleBackColor = false;
//            this.CheckbxShowPas.CheckedChanged += new System.EventHandler(this.CheckbxShowPas_CheckedChanged);
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.BackColor = System.Drawing.Color.White;
//            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.label8.ForeColor = System.Drawing.Color.DarkGray;
//            this.label8.Location = new System.Drawing.Point(71, 459);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(141, 15);
//            this.label8.TabIndex = 21;
//            this.label8.Text = "Already Have an Account";
//            // 
//            // button1
//            // 
//            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
//            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
//            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.button1.FlatAppearance.BorderSize = 0;
//            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
//            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
//            this.button1.Location = new System.Drawing.Point(34, 393);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(216, 28);
//            this.button1.TabIndex = 17;
//            this.button1.Text = "REGISTER";
//            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
//            this.button1.UseVisualStyleBackColor = false;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.BackColor = System.Drawing.Color.White;
//            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
//            this.pictureBox1.Location = new System.Drawing.Point(219, 18);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
//            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBox1.TabIndex = 18;
//            this.pictureBox1.TabStop = false;
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.BackColor = System.Drawing.Color.White;
//            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
//            this.label6.Location = new System.Drawing.Point(34, 88);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(155, 27);
//            this.label6.TabIndex = 16;
//            this.label6.Text = "Get Started";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.BackColor = System.Drawing.Color.White;
//            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
//            this.label2.Location = new System.Drawing.Point(34, 213);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(66, 17);
//            this.label2.TabIndex = 12;
//            this.label2.Text = "Password";
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.White;
//            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
//            this.label1.Location = new System.Drawing.Point(34, 152);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(69, 17);
//            this.label1.TabIndex = 13;
//            this.label1.Text = "Username";
//            // 
//            // txtpassword
//            // 
//            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
//            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtpassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.txtpassword.Location = new System.Drawing.Point(34, 233);
//            this.txtpassword.Multiline = true;
//            this.txtpassword.Name = "txtpassword";
//            this.txtpassword.PasswordChar = '•';
//            this.txtpassword.Size = new System.Drawing.Size(216, 28);
//            this.txtpassword.TabIndex = 14;
//            this.txtpassword.UseSystemPasswordChar = true;
//            // 
//            // txtusername
//            // 
//            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
//            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtusername.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.txtusername.Location = new System.Drawing.Point(34, 172);
//            this.txtusername.Multiline = true;
//            this.txtusername.Name = "txtusername";
//            this.txtusername.Size = new System.Drawing.Size(216, 28);
//            this.txtusername.TabIndex = 15;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.BackColor = System.Drawing.Color.White;
//            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
//            this.label3.Location = new System.Drawing.Point(34, 281);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(120, 17);
//            this.label3.TabIndex = 12;
//            this.label3.Text = "Confirm Password";
//            // 
//            // txtComPassword
//            // 
//            this.txtComPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
//            this.txtComPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtComPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            this.txtComPassword.Location = new System.Drawing.Point(34, 301);
//            this.txtComPassword.Multiline = true;
//            this.txtComPassword.Name = "txtComPassword";
//            this.txtComPassword.PasswordChar = '•';
//            this.txtComPassword.Size = new System.Drawing.Size(216, 28);
//            this.txtComPassword.TabIndex = 14;
//            this.txtComPassword.UseSystemPasswordChar = true;
//            // 
//            // Form2
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.White;
//            this.ClientSize = new System.Drawing.Size(285, 544);
//            this.Controls.Add(this.back);
//            this.Controls.Add(this.CheckbxShowPas);
//            this.Controls.Add(this.label8);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.txtComPassword);
//            this.Controls.Add(this.txtpassword);
//            this.Controls.Add(this.txtusername);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Name = "Form2";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Form2";
//            this.Load += new System.EventHandler(this.Form2_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private CheckBox CheckbxShowPas;
//        private Label label8;
//        private Button button1;
//        private PictureBox pictureBox1;
//        private Label label6;
//        private Label label2;
//        private Label label1;
//        private TextBox txtpassword;
//        private TextBox txtusername;
//        private Label label3;
//        private TextBox txtComPassword;
//        private Label back;
//    }
//>>>>>>> 59ac68c15793a70ec9be79f402a5327d6a303b5c
}