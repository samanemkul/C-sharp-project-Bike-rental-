namespace login
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.Panel();
            this.bikeContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_bikes = new System.Windows.Forms.Button();
            this.btn_petrol = new System.Windows.Forms.Button();
            this.btn_electric = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectName = new System.Windows.Forms.Label();
            this.menubtn = new FontAwesome.Sharp.IconPictureBox();
            this.btn_payment = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_history = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.bike_timer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.bikeContainer.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sidebar.Controls.Add(this.bikeContainer);
            this.sidebar.Controls.Add(this.btn_about);
            this.sidebar.Controls.Add(this.btn_logout);
            this.sidebar.Controls.Add(this.btn_dashboard);
            this.sidebar.Controls.Add(this.panelProfile);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btn_payment);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(217, 568);
            this.sidebar.MinimumSize = new System.Drawing.Size(68, 568);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(217, 568);
            this.sidebar.TabIndex = 0;
            // 
            // bikeContainer
            // 
            this.bikeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bikeContainer.Controls.Add(this.btn_bikes);
            this.bikeContainer.Controls.Add(this.btn_petrol);
            this.bikeContainer.Controls.Add(this.btn_electric);
            this.bikeContainer.Location = new System.Drawing.Point(0, 176);
            this.bikeContainer.MaximumSize = new System.Drawing.Size(211, 149);
            this.bikeContainer.MinimumSize = new System.Drawing.Size(217, 49);
            this.bikeContainer.Name = "bikeContainer";
            this.bikeContainer.Size = new System.Drawing.Size(217, 49);
            this.bikeContainer.TabIndex = 3;
            // 
            // btn_bikes
            // 
            this.btn_bikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_bikes.FlatAppearance.BorderSize = 0;
            this.btn_bikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bikeContainer.SetFlowBreak(this.btn_bikes, true);
            this.btn_bikes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_bikes.ForeColor = System.Drawing.Color.White;
            this.btn_bikes.Image = global::login.Properties.Resources._7;
            this.btn_bikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bikes.Location = new System.Drawing.Point(3, 3);
            this.btn_bikes.MaximumSize = new System.Drawing.Size(221, 149);
            this.btn_bikes.MinimumSize = new System.Drawing.Size(216, 49);
            this.btn_bikes.Name = "btn_bikes";
            this.btn_bikes.Size = new System.Drawing.Size(216, 49);
            this.btn_bikes.TabIndex = 0;
            this.btn_bikes.Text = "Bikes";
            this.btn_bikes.UseVisualStyleBackColor = false;
            this.btn_bikes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_petrol
            // 
            this.btn_petrol.BackColor = System.Drawing.Color.Transparent;
            this.btn_petrol.FlatAppearance.BorderSize = 0;
            this.btn_petrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petrol.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_petrol.ForeColor = System.Drawing.Color.White;
            this.btn_petrol.Image = global::login.Properties.Resources.dot2;
            this.btn_petrol.Location = new System.Drawing.Point(3, 58);
            this.btn_petrol.Name = "btn_petrol";
            this.btn_petrol.Size = new System.Drawing.Size(216, 40);
            this.btn_petrol.TabIndex = 0;
            this.btn_petrol.Text = "Petrol Bike";
            this.btn_petrol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_petrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_petrol.UseVisualStyleBackColor = false;
            // 
            // btn_electric
            // 
            this.btn_electric.BackColor = System.Drawing.Color.Transparent;
            this.btn_electric.FlatAppearance.BorderSize = 0;
            this.btn_electric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_electric.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_electric.ForeColor = System.Drawing.Color.White;
            this.btn_electric.Image = global::login.Properties.Resources.dot2;
            this.btn_electric.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_electric.Location = new System.Drawing.Point(3, 104);
            this.btn_electric.Name = "btn_electric";
            this.btn_electric.Size = new System.Drawing.Size(216, 40);
            this.btn_electric.TabIndex = 0;
            this.btn_electric.Text = "Electric Bike";
            this.btn_electric.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_electric.UseVisualStyleBackColor = false;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = global::login.Properties.Resources.about;
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(4, 289);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(213, 49);
            this.btn_about.TabIndex = 0;
            this.btn_about.Text = "About";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click_1);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::login.Properties.Resources.logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(8, 514);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(209, 49);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::login.Properties.Resources.dashboard21;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(8, 121);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(209, 49);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "  Dash Board";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            // 
            // panelProfile
            // 
            this.panelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfile.Controls.Add(this.btn_profile);
            this.panelProfile.Location = new System.Drawing.Point(1, 58);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(216, 57);
            this.panelProfile.TabIndex = 1;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = global::login.Properties.Resources.profile;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(3, 4);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(206, 49);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.projectName);
            this.panel2.Controls.Add(this.menubtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 57);
            this.panel2.TabIndex = 0;
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectName.ForeColor = System.Drawing.Color.White;
            this.projectName.Location = new System.Drawing.Point(80, 11);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(68, 27);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "Menu";
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menubtn.BackgroundImage = global::login.Properties.Resources.bars1;
            this.menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menubtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menubtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menubtn.IconColor = System.Drawing.SystemColors.ControlText;
            this.menubtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menubtn.Location = new System.Drawing.Point(11, 11);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(32, 32);
            this.menubtn.TabIndex = 1;
            this.menubtn.TabStop = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.Transparent;
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Image = global::login.Properties.Resources.payment;
            this.btn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payment.Location = new System.Drawing.Point(0, 234);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(219, 49);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Text = "Payment";
            this.btn_payment.UseVisualStyleBackColor = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Controls.Add(this.button3);
            this.pnl_main.Controls.Add(this.lbl_dashboard);
            this.pnl_main.Controls.Add(this.button2);
            this.pnl_main.Controls.Add(this.btn_history);
            this.pnl_main.Controls.Add(this.panel6);
            this.pnl_main.Controls.Add(this.panel5);
            this.pnl_main.Controls.Add(this.pnl_history);
            this.pnl_main.Controls.Add(this.panel3);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_main.Location = new System.Drawing.Point(217, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(716, 568);
            this.pnl_main.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(572, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home/Dash Board";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(494, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "(%)Offers";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dashboard.Location = new System.Drawing.Point(4, 64);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(154, 31);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dash Board";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(246, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Active Bikes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.Cyan;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_history.Location = new System.Drawing.Point(4, 212);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(200, 29);
            this.btn_history.TabIndex = 2;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.Location = new System.Drawing.Point(494, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(246, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 1;
            // 
            // pnl_history
            // 
            this.pnl_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_history.Location = new System.Drawing.Point(4, 113);
            this.pnl_history.Name = "pnl_history";
            this.pnl_history.Size = new System.Drawing.Size(200, 100);
            this.pnl_history.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 55);
            this.panel3.TabIndex = 0;
            // 
            // sidebar_timer
            // 
            this.sidebar_timer.Interval = 10;
            this.sidebar_timer.Tick += new System.EventHandler(this.sidebar_click);
            // 
            // bike_timer
            // 
            this.bike_timer.Interval = 10;
            this.bike_timer.Tick += new System.EventHandler(this.bike_timer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 568);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.sidebar);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.sidebar.ResumeLayout(false);
            this.bikeContainer.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidebar;
        private Panel panelProfile;
        private Button btn_profile;
        private Panel panel2;
        private Label projectName;
        private Panel pnl_main;
        private Button btn_dashboard;
        private Button btn_logout;
        private Panel panel3;
        private Label label1;
        private Label lbl_dashboard;
        private Panel panel6;
        private Panel panel5;
        private Panel pnl_history;
        private Button btn_payment;
        private Button button3;
        private Button button2;
        private Button btn_history;
        private Button btn_about;
        private FontAwesome.Sharp.IconPictureBox menubtn;
        private System.Windows.Forms.Timer sidebar_timer;
        private Button btn_bikes;
        private System.Windows.Forms.Timer bike_timer;
        private FlowLayoutPanel bikeContainer;
        private Button btn_petrol;
        private Button btn_electric;
    }
}