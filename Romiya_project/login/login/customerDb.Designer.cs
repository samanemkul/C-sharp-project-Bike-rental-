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
            this.btn_customerAbout = new FontAwesome.Sharp.IconButton();
            this.btn_customerPayment = new FontAwesome.Sharp.IconButton();
            this.btn_customerDb = new FontAwesome.Sharp.IconButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btn_customerProfile = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectName = new System.Windows.Forms.Label();
            this.menubtn = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_FeedBack = new System.Windows.Forms.Button();
            this.pnl_offers = new System.Windows.Forms.Panel();
            this.pnl_activeBikes = new System.Windows.Forms.Panel();
            this.pnl_history = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.bike_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_cuHelp = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.bikeContainer.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.pnl_main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sidebar.Controls.Add(this.bikeContainer);
            this.sidebar.Controls.Add(this.btn_logOut);
            this.sidebar.Controls.Add(this.btn_customerAbout);
            this.sidebar.Controls.Add(this.btn_customerPayment);
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
            // 
            // bikeContainer
            // 
            this.bikeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bikeContainer.Controls.Add(this.btn_customerBikes);
            this.bikeContainer.Controls.Add(this.btn_customerPetrolBike);
            this.bikeContainer.Controls.Add(this.btn_customerElectricBike);
            this.bikeContainer.Location = new System.Drawing.Point(12, 159);
            this.bikeContainer.MaximumSize = new System.Drawing.Size(190, 136);
            this.bikeContainer.MinimumSize = new System.Drawing.Size(190, 38);
            this.bikeContainer.Name = "bikeContainer";
            this.bikeContainer.Size = new System.Drawing.Size(190, 44);
            this.bikeContainer.TabIndex = 3;
            // 
            // btn_customerBikes
            // 
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
            this.btn_customerBikes.Size = new System.Drawing.Size(190, 38);
            this.btn_customerBikes.TabIndex = 0;
            this.btn_customerBikes.Text = "Bikes";
            this.btn_customerBikes.UseVisualStyleBackColor = true;
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
            // 
            // btn_logOut
            // 
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logOut.ForeColor = System.Drawing.Color.White;
            this.btn_logOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btn_logOut.IconColor = System.Drawing.Color.White;
            this.btn_logOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logOut.IconSize = 25;
            this.btn_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logOut.Location = new System.Drawing.Point(15, 294);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(188, 38);
            this.btn_logOut.TabIndex = 0;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            // 
            // btn_customerAbout
            // 
            this.btn_customerAbout.FlatAppearance.BorderSize = 0;
            this.btn_customerAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerAbout.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerAbout.ForeColor = System.Drawing.Color.White;
            this.btn_customerAbout.IconChar = FontAwesome.Sharp.IconChar.TachographDigital;
            this.btn_customerAbout.IconColor = System.Drawing.Color.White;
            this.btn_customerAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerAbout.IconSize = 25;
            this.btn_customerAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerAbout.Location = new System.Drawing.Point(13, 258);
            this.btn_customerAbout.Name = "btn_customerAbout";
            this.btn_customerAbout.Size = new System.Drawing.Size(197, 38);
            this.btn_customerAbout.TabIndex = 0;
            this.btn_customerAbout.Text = "About";
            this.btn_customerAbout.UseVisualStyleBackColor = true;
            // 
            // btn_customerPayment
            // 
            this.btn_customerPayment.FlatAppearance.BorderSize = 0;
            this.btn_customerPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerPayment.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerPayment.ForeColor = System.Drawing.Color.White;
            this.btn_customerPayment.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btn_customerPayment.IconColor = System.Drawing.Color.White;
            this.btn_customerPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerPayment.IconSize = 25;
            this.btn_customerPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerPayment.Location = new System.Drawing.Point(12, 214);
            this.btn_customerPayment.Name = "btn_customerPayment";
            this.btn_customerPayment.Size = new System.Drawing.Size(198, 38);
            this.btn_customerPayment.TabIndex = 0;
            this.btn_customerPayment.Text = "Payment";
            this.btn_customerPayment.UseVisualStyleBackColor = true;
            // 
            // btn_customerDb
            // 
            this.btn_customerDb.FlatAppearance.BorderSize = 0;
            this.btn_customerDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customerDb.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_customerDb.ForeColor = System.Drawing.Color.White;
            this.btn_customerDb.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btn_customerDb.IconColor = System.Drawing.Color.White;
            this.btn_customerDb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_customerDb.IconSize = 25;
            this.btn_customerDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerDb.Location = new System.Drawing.Point(12, 115);
            this.btn_customerDb.Name = "btn_customerDb";
            this.btn_customerDb.Size = new System.Drawing.Size(190, 38);
            this.btn_customerDb.TabIndex = 0;
            this.btn_customerDb.Text = "    Dash Board";
            this.btn_customerDb.UseVisualStyleBackColor = true;
            // 
            // panelProfile
            // 
            this.panelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btn_customerProfile.Location = new System.Drawing.Point(10, 7);
            this.btn_customerProfile.Name = "btn_customerProfile";
            this.btn_customerProfile.Size = new System.Drawing.Size(191, 38);
            this.btn_customerProfile.TabIndex = 0;
            this.btn_customerProfile.Text = "Profile";
            this.btn_customerProfile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::login.Properties.Resources.Logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::login.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
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
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.Transparent;
            this.menubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menubtn.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.menubtn.IconColor = System.Drawing.Color.White;
            this.menubtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menubtn.IconSize = 27;
            this.menubtn.Location = new System.Drawing.Point(3, 12);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(29, 27);
            this.menubtn.TabIndex = 1;
            this.menubtn.TabStop = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_main.Controls.Add(this.label2);
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Controls.Add(this.button3);
            this.pnl_main.Controls.Add(this.lbl_dashboard);
            this.pnl_main.Controls.Add(this.button2);
            this.pnl_main.Controls.Add(this.btn_FeedBack);
            this.pnl_main.Controls.Add(this.pnl_offers);
            this.pnl_main.Controls.Add(this.pnl_activeBikes);
            this.pnl_main.Controls.Add(this.pnl_history);
            this.pnl_main.Controls.Add(this.panel3);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_main.Location = new System.Drawing.Point(217, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(716, 568);
            this.pnl_main.TabIndex = 1;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(554, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(173)))), ((int)(((byte)(6)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(494, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "(%)Offers";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dashboard.Location = new System.Drawing.Point(4, 64);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(157, 37);
            this.lbl_dashboard.TabIndex = 0;
            this.lbl_dashboard.Text = "Dash Board";
            this.lbl_dashboard.Click += new System.EventHandler(this.lbl_dashboard_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(246, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Active Bikes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_FeedBack
            // 
            this.btn_FeedBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.btn_FeedBack.FlatAppearance.BorderSize = 0;
            this.btn_FeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FeedBack.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FeedBack.Location = new System.Drawing.Point(4, 212);
            this.btn_FeedBack.Name = "btn_FeedBack";
            this.btn_FeedBack.Size = new System.Drawing.Size(200, 29);
            this.btn_FeedBack.TabIndex = 2;
            this.btn_FeedBack.Text = "FeedBack";
            this.btn_FeedBack.UseVisualStyleBackColor = false;
            this.btn_FeedBack.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // pnl_offers
            // 
            this.pnl_offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(9)))));
            this.pnl_offers.Location = new System.Drawing.Point(494, 113);
            this.pnl_offers.Name = "pnl_offers";
            this.pnl_offers.Size = new System.Drawing.Size(200, 100);
            this.pnl_offers.TabIndex = 1;
            this.pnl_offers.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pnl_activeBikes
            // 
            this.pnl_activeBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnl_activeBikes.Location = new System.Drawing.Point(246, 113);
            this.pnl_activeBikes.Name = "pnl_activeBikes";
            this.pnl_activeBikes.Size = new System.Drawing.Size(200, 100);
            this.pnl_activeBikes.TabIndex = 1;
            this.pnl_activeBikes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pnl_history
            // 
            this.pnl_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.pnl_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_history.Location = new System.Drawing.Point(4, 113);
            this.pnl_history.Name = "pnl_history";
            this.pnl_history.Size = new System.Drawing.Size(200, 100);
            this.pnl_history.TabIndex = 1;
            this.pnl_history.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_history_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(127)))), ((int)(((byte)(21)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_cuHelp);
            this.panel3.Controls.Add(this.menubtn);
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
            // btn_cuHelp
            // 
            this.btn_cuHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_cuHelp.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuHelp.FlatAppearance.BorderSize = 0;
            this.btn_cuHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuHelp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cuHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btn_cuHelp.IconColor = System.Drawing.Color.White;
            this.btn_cuHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cuHelp.IconSize = 20;
            this.btn_cuHelp.Location = new System.Drawing.Point(664, 12);
            this.btn_cuHelp.Name = "btn_cuHelp";
            this.btn_cuHelp.Size = new System.Drawing.Size(29, 34);
            this.btn_cuHelp.TabIndex = 2;
            this.btn_cuHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cuHelp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(602, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "/ Dash Board";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 568);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.sidebar);
            this.Name = "customerDb";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.customerDb_Load);
            this.sidebar.ResumeLayout(false);
            this.bikeContainer.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private Panel pnl_activeBikes;
        private Panel pnl_history;
        private Button button3;
        private Button button2;
        private Button btn_FeedBack;
        private FontAwesome.Sharp.IconPictureBox menubtn;
        private System.Windows.Forms.Timer sidebar_timer;
        private System.Windows.Forms.Timer bike_timer;
        private FontAwesome.Sharp.IconButton btn_customerDb;
        private FontAwesome.Sharp.IconButton btn_customerProfile;
        private FontAwesome.Sharp.IconButton btn_logOut;
        private FontAwesome.Sharp.IconButton btn_customerAbout;
        private FontAwesome.Sharp.IconButton btn_customerPayment;
        private FlowLayoutPanel bikeContainer;
        private FontAwesome.Sharp.IconButton btn_customerBikes;
        private FontAwesome.Sharp.IconButton btn_customerElectricBike;
        private FontAwesome.Sharp.IconButton btn_customerPetrolBike;
        private Panel pnl_offers;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_cuHelp;
        private Label label2;
    }
}