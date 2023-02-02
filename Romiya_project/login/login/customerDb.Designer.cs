namespace login
{
    partial class customerDb
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
            this.btn_customerBikes = new FontAwesome.Sharp.IconButton();
            this.btn_customerPetrolBike = new FontAwesome.Sharp.IconButton();
            this.btn_customerElectricBike = new FontAwesome.Sharp.IconButton();
            this.btn_logOut = new FontAwesome.Sharp.IconButton();
            this.btn_customerHelp = new FontAwesome.Sharp.IconButton();
            this.btn_customerDb = new FontAwesome.Sharp.IconButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btn_customerProfile = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectName = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.rights = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.btn_offers = new System.Windows.Forms.Button();
            this.btn_activeBikes = new System.Windows.Forms.Button();
            this.feedBack = new System.Windows.Forms.Panel();
            this.pnl_offers = new System.Windows.Forms.Panel();
            this.pnl_activeBikes = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeButton = new FontAwesome.Sharp.IconPictureBox();
            this.bike_timer = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.sidebar.SuspendLayout();
            this.bikeContainer.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.rights.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.bikeContainer);
            this.sidebar.Controls.Add(this.btn_logOut);
            this.sidebar.Controls.Add(this.btn_customerHelp);
            this.sidebar.Controls.Add(this.btn_customerDb);
            this.sidebar.Controls.Add(this.panelProfile);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(217, 568);
            this.sidebar.MinimumSize = new System.Drawing.Size(68, 568);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(217, 568);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // bikeContainer
            // 
            this.bikeContainer.BackColor = System.Drawing.Color.Black;
            this.bikeContainer.Controls.Add(this.btn_customerBikes);
            this.bikeContainer.Controls.Add(this.btn_customerPetrolBike);
            this.bikeContainer.Controls.Add(this.btn_customerElectricBike);
            this.bikeContainer.Location = new System.Drawing.Point(3, 159);
            this.bikeContainer.MaximumSize = new System.Drawing.Size(190, 136);
            this.bikeContainer.MinimumSize = new System.Drawing.Size(190, 38);
            this.bikeContainer.Name = "bikeContainer";
            this.bikeContainer.Size = new System.Drawing.Size(190, 41);
            this.bikeContainer.TabIndex = 3;
            // 
            // btn_customerBikes
            // 
            this.btn_customerBikes.BackColor = System.Drawing.Color.Black;
            this.btn_customerBikes.FlatAppearance.BorderSize = 0;
            this.btn_customerBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerBikes.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerBikes.ForeColor = System.Drawing.Color.White;
            this.btn_customerBikes.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btn_customerBikes.IconColor = System.Drawing.Color.White;
            this.btn_customerBikes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerBikes.IconSize = 25;
            this.btn_customerBikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerBikes.Location = new System.Drawing.Point(3, 3);
            this.btn_customerBikes.Name = "btn_customerBikes";
            this.btn_customerBikes.Size = new System.Drawing.Size(214, 38);
            this.btn_customerBikes.TabIndex = 0;
            this.btn_customerBikes.Text = "Bikes";
            this.btn_customerBikes.UseVisualStyleBackColor = false;
            this.btn_customerBikes.Click += new System.EventHandler(this.btn_customerBikes_Click);
            // 
            // btn_customerPetrolBike
            // 
            this.btn_customerPetrolBike.FlatAppearance.BorderSize = 0;
            this.btn_customerPetrolBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerPetrolBike.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerPetrolBike.ForeColor = System.Drawing.Color.White;
            this.btn_customerPetrolBike.IconChar = FontAwesome.Sharp.IconChar.DiceOne;
            this.btn_customerPetrolBike.IconColor = System.Drawing.Color.White;
            this.btn_customerPetrolBike.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerPetrolBike.IconSize = 25;
            this.btn_customerPetrolBike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerPetrolBike.Location = new System.Drawing.Point(3, 47);
            this.btn_customerPetrolBike.Name = "btn_customerPetrolBike";
            this.btn_customerPetrolBike.Size = new System.Drawing.Size(190, 38);
            this.btn_customerPetrolBike.TabIndex = 0;
            this.btn_customerPetrolBike.Text = "Petrol Bikes";
            this.btn_customerPetrolBike.UseVisualStyleBackColor = true;
            this.btn_customerPetrolBike.Click += new System.EventHandler(this.btn_customerPetrolBike_Click);
            // 
            // btn_customerElectricBike
            // 
            this.btn_customerElectricBike.FlatAppearance.BorderSize = 0;
            this.btn_customerElectricBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerElectricBike.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerElectricBike.ForeColor = System.Drawing.Color.White;
            this.btn_customerElectricBike.IconChar = FontAwesome.Sharp.IconChar.DiceOne;
            this.btn_customerElectricBike.IconColor = System.Drawing.Color.White;
            this.btn_customerElectricBike.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerElectricBike.IconSize = 25;
            this.btn_customerElectricBike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerElectricBike.Location = new System.Drawing.Point(3, 91);
            this.btn_customerElectricBike.Name = "btn_customerElectricBike";
            this.btn_customerElectricBike.Size = new System.Drawing.Size(190, 38);
            this.btn_customerElectricBike.TabIndex = 0;
            this.btn_customerElectricBike.Text = "Electric Bikes";
            this.btn_customerElectricBike.UseVisualStyleBackColor = true;
            this.btn_customerElectricBike.Click += new System.EventHandler(this.btn_customerElectricBike_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logOut.ForeColor = System.Drawing.Color.White;
            this.btn_logOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btn_logOut.IconColor = System.Drawing.Color.White;
            this.btn_logOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logOut.IconSize = 25;
            this.btn_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.Location = new System.Drawing.Point(0, 527);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(217, 38);
            this.btn_logOut.TabIndex = 0;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_customerHelp
            // 
            this.btn_customerHelp.FlatAppearance.BorderSize = 0;
            this.btn_customerHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerHelp.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerHelp.ForeColor = System.Drawing.Color.White;
            this.btn_customerHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btn_customerHelp.IconColor = System.Drawing.Color.White;
            this.btn_customerHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerHelp.IconSize = 25;
            this.btn_customerHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerHelp.Location = new System.Drawing.Point(0, 207);
            this.btn_customerHelp.Name = "btn_customerHelp";
            this.btn_customerHelp.Size = new System.Drawing.Size(217, 38);
            this.btn_customerHelp.TabIndex = 0;
            this.btn_customerHelp.Text = "Help";
            this.btn_customerHelp.UseVisualStyleBackColor = true;
            // 
            // btn_customerDb
            // 
            this.btn_customerDb.FlatAppearance.BorderSize = 0;
            this.btn_customerDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerDb.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerDb.ForeColor = System.Drawing.Color.White;
            this.btn_customerDb.IconChar = FontAwesome.Sharp.IconChar.GaugeHigh;
            this.btn_customerDb.IconColor = System.Drawing.Color.White;
            this.btn_customerDb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerDb.IconSize = 25;
            this.btn_customerDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerDb.Location = new System.Drawing.Point(3, 115);
            this.btn_customerDb.Name = "btn_customerDb";
            this.btn_customerDb.Size = new System.Drawing.Size(214, 38);
            this.btn_customerDb.TabIndex = 0;
            this.btn_customerDb.Text = "    Dash Board";
            this.btn_customerDb.UseVisualStyleBackColor = true;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.btn_customerProfile);
            this.panelProfile.Location = new System.Drawing.Point(1, 58);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(216, 46);
            this.panelProfile.TabIndex = 1;
            // 
            // btn_customerProfile
            // 
            this.btn_customerProfile.FlatAppearance.BorderSize = 0;
            this.btn_customerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerProfile.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerProfile.ForeColor = System.Drawing.Color.White;
            this.btn_customerProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_customerProfile.IconColor = System.Drawing.Color.White;
            this.btn_customerProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerProfile.IconSize = 25;
            this.btn_customerProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerProfile.Location = new System.Drawing.Point(0, 7);
            this.btn_customerProfile.Name = "btn_customerProfile";
            this.btn_customerProfile.Size = new System.Drawing.Size(216, 38);
            this.btn_customerProfile.TabIndex = 0;
            this.btn_customerProfile.Text = "Profile";
            this.btn_customerProfile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.projectName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 57);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::login.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectName.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectName.ForeColor = System.Drawing.Color.White;
            this.projectName.Location = new System.Drawing.Point(62, 20);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(139, 21);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "Bike Rental System";
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.rights);
            this.pnl_main.Controls.Add(this.label2);
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Controls.Add(this.btn_feedback);
            this.pnl_main.Controls.Add(this.lbl_dashboard);
            this.pnl_main.Controls.Add(this.btn_offers);
            this.pnl_main.Controls.Add(this.btn_activeBikes);
            this.pnl_main.Controls.Add(this.feedBack);
            this.pnl_main.Controls.Add(this.pnl_offers);
            this.pnl_main.Controls.Add(this.pnl_activeBikes);
            this.pnl_main.Controls.Add(this.panel3);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_main.Location = new System.Drawing.Point(217, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(847, 568);
            this.pnl_main.TabIndex = 1;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            // 
            // rights
            // 
            this.rights.Controls.Add(this.label4);
            this.rights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rights.Location = new System.Drawing.Point(0, 528);
            this.rights.Name = "rights";
            this.rights.Size = new System.Drawing.Size(847, 40);
            this.rights.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bike Rental System. All rights reserved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(736, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "/ Dash Board";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(688, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_feedback
            // 
            this.btn_feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(173)))), ((int)(((byte)(6)))));
            this.btn_feedback.FlatAppearance.BorderSize = 0;
            this.btn_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_feedback.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_feedback.Location = new System.Drawing.Point(605, 241);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(231, 29);
            this.btn_feedback.TabIndex = 2;
            this.btn_feedback.Text = "Feed Back";
            this.btn_feedback.UseVisualStyleBackColor = false;
            this.btn_feedback.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dashboard.Location = new System.Drawing.Point(20, 78);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(157, 37);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dash Board";
            this.lbl_dashboard.Click += new System.EventHandler(this.lbl_dashboard_Click);
            // 
            // btn_offers
            // 
            this.btn_offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.btn_offers.FlatAppearance.BorderSize = 0;
            this.btn_offers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_offers.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_offers.Location = new System.Drawing.Point(318, 241);
            this.btn_offers.Name = "btn_offers";
            this.btn_offers.Size = new System.Drawing.Size(237, 29);
            this.btn_offers.TabIndex = 2;
            this.btn_offers.Text = "(%) Offers";
            this.btn_offers.UseVisualStyleBackColor = false;
            this.btn_offers.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_activeBikes
            // 
            this.btn_activeBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.btn_activeBikes.FlatAppearance.BorderSize = 0;
            this.btn_activeBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activeBikes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_activeBikes.Location = new System.Drawing.Point(20, 241);
            this.btn_activeBikes.Name = "btn_activeBikes";
            this.btn_activeBikes.Size = new System.Drawing.Size(253, 29);
            this.btn_activeBikes.TabIndex = 2;
            this.btn_activeBikes.Text = "Active Bikes";
            this.btn_activeBikes.UseVisualStyleBackColor = false;
            this.btn_activeBikes.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // feedBack
            // 
            this.feedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(9)))));
            this.feedBack.Location = new System.Drawing.Point(605, 142);
            this.feedBack.Name = "feedBack";
            this.feedBack.Size = new System.Drawing.Size(230, 100);
            this.feedBack.TabIndex = 1;
            this.feedBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pnl_offers
            // 
            this.pnl_offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnl_offers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_offers.Location = new System.Drawing.Point(318, 142);
            this.pnl_offers.Name = "pnl_offers";
            this.pnl_offers.Size = new System.Drawing.Size(237, 100);
            this.pnl_offers.TabIndex = 1;
            this.pnl_offers.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pnl_activeBikes
            // 
            this.pnl_activeBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.pnl_activeBikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_activeBikes.Location = new System.Drawing.Point(20, 142);
            this.pnl_activeBikes.Name = "pnl_activeBikes";
            this.pnl_activeBikes.Size = new System.Drawing.Size(253, 100);
            this.pnl_activeBikes.TabIndex = 1;
            this.pnl_activeBikes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_history_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 55);
            this.panel3.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.closeButton.IconColor = System.Drawing.Color.Red;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.closeButton.IconSize = 27;
            this.closeButton.Location = new System.Drawing.Point(817, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bike_timer
            // 
            this.bike_timer.Interval = 5;
            this.bike_timer.Tick += new System.EventHandler(this.bike_timer_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 36;
            this.guna2Elipse1.TargetControl = this;
            // 
            // customerDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 568);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.customerDb_Load);
            this.sidebar.ResumeLayout(false);
            this.bikeContainer.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.rights.ResumeLayout(false);
            this.rights.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidebar;
        private Panel panelProfile;
        private Panel panel2;
        private Label projectName;
        private Panel pnl_main;
        private Panel panel3;
        private Label label1;
        private Label lbl_dashboard;
        private Panel pnl_offers;
        private Panel pnl_activeBikes;
        private Button btn_feedback;
        private Button btn_offers;
        private Button btn_activeBikes;
        private System.Windows.Forms.Timer bike_timer;
        private FontAwesome.Sharp.IconButton btn_customerDb;
        private FontAwesome.Sharp.IconButton btn_customerProfile;
        private FontAwesome.Sharp.IconButton btn_logOut;
        private FontAwesome.Sharp.IconButton btn_customerHelp;
        private FlowLayoutPanel bikeContainer;
        private FontAwesome.Sharp.IconButton btn_customerBikes;
        private FontAwesome.Sharp.IconButton btn_customerElectricBike;
        private FontAwesome.Sharp.IconButton btn_customerPetrolBike;
        private Panel feedBack;
        private Label label2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel rights;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox closeButton;
    }
}