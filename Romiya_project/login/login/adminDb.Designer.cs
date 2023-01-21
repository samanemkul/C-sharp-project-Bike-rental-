namespace login
{
    partial class adminDb
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
            this.btn_adminBikes = new FontAwesome.Sharp.IconButton();
            this.btn_customerPetrolBike = new FontAwesome.Sharp.IconButton();
            this.btn_customerElectricBike = new FontAwesome.Sharp.IconButton();
            this.btn_logOut = new FontAwesome.Sharp.IconButton();
            this.btn_adminHelp = new FontAwesome.Sharp.IconButton();
            this.btn_rental = new FontAwesome.Sharp.IconButton();
            this.btn_clientManagement = new FontAwesome.Sharp.IconButton();
            this.btn_admin = new FontAwesome.Sharp.IconButton();
            this.btn_adminPayment = new FontAwesome.Sharp.IconButton();
            this.btn_adminDb = new FontAwesome.Sharp.IconButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btn_adminProfile = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectName = new System.Windows.Forms.Label();
            this.menubtn = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.btn_offers = new System.Windows.Forms.Button();
            this.btn_activeBikes = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Panel();
            this.pnl_offers = new System.Windows.Forms.Panel();
            this.pnl_activeBikes = new System.Windows.Forms.Panel();
            this.adminSidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.adminBike_timer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.bikeContainer.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sidebar.Controls.Add(this.bikeContainer);
            this.sidebar.Controls.Add(this.btn_logOut);
            this.sidebar.Controls.Add(this.btn_adminHelp);
            this.sidebar.Controls.Add(this.btn_rental);
            this.sidebar.Controls.Add(this.btn_clientManagement);
            this.sidebar.Controls.Add(this.btn_admin);
            this.sidebar.Controls.Add(this.btn_adminPayment);
            this.sidebar.Controls.Add(this.btn_adminDb);
            this.sidebar.Controls.Add(this.panelProfile);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(217, 568);
            this.sidebar.MinimumSize = new System.Drawing.Size(68, 568);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(217, 568);
            this.sidebar.TabIndex = 1;
            // 
            // bikeContainer
            // 
            this.bikeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bikeContainer.Controls.Add(this.btn_adminBikes);
            this.bikeContainer.Controls.Add(this.btn_customerPetrolBike);
            this.bikeContainer.Controls.Add(this.btn_customerElectricBike);
            this.bikeContainer.Location = new System.Drawing.Point(0, 159);
            this.bikeContainer.MaximumSize = new System.Drawing.Size(190, 136);
            this.bikeContainer.MinimumSize = new System.Drawing.Size(190, 38);
            this.bikeContainer.Name = "bikeContainer";
            this.bikeContainer.Size = new System.Drawing.Size(190, 38);
            this.bikeContainer.TabIndex = 3;
            // 
            // btn_adminBikes
            // 
            this.btn_adminBikes.FlatAppearance.BorderSize = 0;
            this.btn_adminBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminBikes.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminBikes.ForeColor = System.Drawing.Color.White;
            this.btn_adminBikes.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btn_adminBikes.IconColor = System.Drawing.Color.White;
            this.btn_adminBikes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_adminBikes.IconSize = 25;
            this.btn_adminBikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminBikes.Location = new System.Drawing.Point(3, 3);
            this.btn_adminBikes.Name = "btn_adminBikes";
            this.btn_adminBikes.Size = new System.Drawing.Size(221, 38);
            this.btn_adminBikes.TabIndex = 0;
            this.btn_adminBikes.Text = "Bikes";
            this.btn_adminBikes.UseVisualStyleBackColor = true;
            this.btn_adminBikes.Click += new System.EventHandler(this.btn_adminBikes_Click);
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
            // 
            // btn_adminHelp
            // 
            this.btn_adminHelp.FlatAppearance.BorderSize = 0;
            this.btn_adminHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminHelp.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminHelp.ForeColor = System.Drawing.Color.White;
            this.btn_adminHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btn_adminHelp.IconColor = System.Drawing.Color.White;
            this.btn_adminHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_adminHelp.IconSize = 25;
            this.btn_adminHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminHelp.Location = new System.Drawing.Point(-2, 379);
            this.btn_adminHelp.Name = "btn_adminHelp";
            this.btn_adminHelp.Size = new System.Drawing.Size(216, 38);
            this.btn_adminHelp.TabIndex = 0;
            this.btn_adminHelp.Text = "Help";
            this.btn_adminHelp.UseVisualStyleBackColor = true;
            // 
            // btn_rental
            // 
            this.btn_rental.FlatAppearance.BorderSize = 0;
            this.btn_rental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rental.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rental.ForeColor = System.Drawing.Color.White;
            this.btn_rental.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btn_rental.IconColor = System.Drawing.Color.White;
            this.btn_rental.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_rental.IconSize = 25;
            this.btn_rental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rental.Location = new System.Drawing.Point(-2, 203);
            this.btn_rental.Name = "btn_rental";
            this.btn_rental.Size = new System.Drawing.Size(213, 38);
            this.btn_rental.TabIndex = 0;
            this.btn_rental.Text = "Rental";
            this.btn_rental.UseVisualStyleBackColor = true;
            this.btn_rental.Click += new System.EventHandler(this.btn_rental_Click);
            // 
            // btn_clientManagement
            // 
            this.btn_clientManagement.FlatAppearance.BorderSize = 0;
            this.btn_clientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientManagement.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clientManagement.ForeColor = System.Drawing.Color.White;
            this.btn_clientManagement.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btn_clientManagement.IconColor = System.Drawing.Color.White;
            this.btn_clientManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_clientManagement.IconSize = 25;
            this.btn_clientManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientManagement.Location = new System.Drawing.Point(-2, 247);
            this.btn_clientManagement.Name = "btn_clientManagement";
            this.btn_clientManagement.Size = new System.Drawing.Size(219, 38);
            this.btn_clientManagement.TabIndex = 0;
            this.btn_clientManagement.Text = "   Client Management";
            this.btn_clientManagement.UseVisualStyleBackColor = true;
            this.btn_clientManagement.Click += new System.EventHandler(this.btn_clientManagement_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btn_admin.IconColor = System.Drawing.Color.White;
            this.btn_admin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_admin.IconSize = 25;
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin.Location = new System.Drawing.Point(1, 291);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(216, 38);
            this.btn_admin.TabIndex = 0;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_adminPayment
            // 
            this.btn_adminPayment.FlatAppearance.BorderSize = 0;
            this.btn_adminPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminPayment.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminPayment.ForeColor = System.Drawing.Color.White;
            this.btn_adminPayment.IconChar = FontAwesome.Sharp.IconChar.Dollar;
            this.btn_adminPayment.IconColor = System.Drawing.Color.White;
            this.btn_adminPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_adminPayment.IconSize = 25;
            this.btn_adminPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminPayment.Location = new System.Drawing.Point(0, 335);
            this.btn_adminPayment.Name = "btn_adminPayment";
            this.btn_adminPayment.Size = new System.Drawing.Size(217, 38);
            this.btn_adminPayment.TabIndex = 0;
            this.btn_adminPayment.Text = "Payment";
            this.btn_adminPayment.UseVisualStyleBackColor = true;
            this.btn_adminPayment.Click += new System.EventHandler(this.btn_adminPayment_Click);
            // 
            // btn_adminDb
            // 
            this.btn_adminDb.FlatAppearance.BorderSize = 0;
            this.btn_adminDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminDb.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminDb.ForeColor = System.Drawing.Color.White;
            this.btn_adminDb.IconChar = FontAwesome.Sharp.IconChar.GaugeHigh;
            this.btn_adminDb.IconColor = System.Drawing.Color.White;
            this.btn_adminDb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_adminDb.IconSize = 25;
            this.btn_adminDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminDb.Location = new System.Drawing.Point(0, 115);
            this.btn_adminDb.Name = "btn_adminDb";
            this.btn_adminDb.Size = new System.Drawing.Size(217, 38);
            this.btn_adminDb.TabIndex = 0;
            this.btn_adminDb.Text = "    Dash Board";
            this.btn_adminDb.UseVisualStyleBackColor = true;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.btn_adminProfile);
            this.panelProfile.Location = new System.Drawing.Point(1, 58);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(216, 46);
            this.panelProfile.TabIndex = 1;
            // 
            // btn_adminProfile
            // 
            this.btn_adminProfile.FlatAppearance.BorderSize = 0;
            this.btn_adminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminProfile.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adminProfile.ForeColor = System.Drawing.Color.White;
            this.btn_adminProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_adminProfile.IconColor = System.Drawing.Color.White;
            this.btn_adminProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_adminProfile.IconSize = 25;
            this.btn_adminProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adminProfile.Location = new System.Drawing.Point(0, 7);
            this.btn_adminProfile.Name = "btn_adminProfile";
            this.btn_adminProfile.Size = new System.Drawing.Size(216, 38);
            this.btn_adminProfile.TabIndex = 0;
            this.btn_adminProfile.Text = "Profile";
            this.btn_adminProfile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.projectName);
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
            this.projectName.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectName.ForeColor = System.Drawing.Color.White;
            this.projectName.Location = new System.Drawing.Point(34, 19);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(127)))), ((int)(((byte)(21)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.menubtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 55);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(821, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "/ Dash Board";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(773, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home";
            // 
            // btn_feedback
            // 
            this.btn_feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(173)))), ((int)(((byte)(6)))));
            this.btn_feedback.FlatAppearance.BorderSize = 0;
            this.btn_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_feedback.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_feedback.Location = new System.Drawing.Point(713, 214);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(201, 29);
            this.btn_feedback.TabIndex = 9;
            this.btn_feedback.Text = "Feed Back";
            this.btn_feedback.UseVisualStyleBackColor = false;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dashboard.Location = new System.Drawing.Point(223, 66);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(157, 37);
            this.lbl_dashboard.TabIndex = 3;
            this.lbl_dashboard.Text = "Dash Board";
            // 
            // btn_offers
            // 
            this.btn_offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.btn_offers.FlatAppearance.BorderSize = 0;
            this.btn_offers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_offers.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_offers.Location = new System.Drawing.Point(465, 214);
            this.btn_offers.Name = "btn_offers";
            this.btn_offers.Size = new System.Drawing.Size(200, 29);
            this.btn_offers.TabIndex = 10;
            this.btn_offers.Text = "(%) Offers";
            this.btn_offers.UseVisualStyleBackColor = false;
            // 
            // btn_activeBikes
            // 
            this.btn_activeBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.btn_activeBikes.FlatAppearance.BorderSize = 0;
            this.btn_activeBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activeBikes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_activeBikes.Location = new System.Drawing.Point(223, 214);
            this.btn_activeBikes.Name = "btn_activeBikes";
            this.btn_activeBikes.Size = new System.Drawing.Size(200, 29);
            this.btn_activeBikes.TabIndex = 11;
            this.btn_activeBikes.Text = "Active Bikes";
            this.btn_activeBikes.UseVisualStyleBackColor = false;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(9)))));
            this.f.Location = new System.Drawing.Point(713, 115);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(200, 100);
            this.f.TabIndex = 6;
            // 
            // pnl_offers
            // 
            this.pnl_offers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnl_offers.Location = new System.Drawing.Point(465, 115);
            this.pnl_offers.Name = "pnl_offers";
            this.pnl_offers.Size = new System.Drawing.Size(200, 100);
            this.pnl_offers.TabIndex = 7;
            // 
            // pnl_activeBikes
            // 
            this.pnl_activeBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.pnl_activeBikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_activeBikes.Location = new System.Drawing.Point(223, 115);
            this.pnl_activeBikes.Name = "pnl_activeBikes";
            this.pnl_activeBikes.Size = new System.Drawing.Size(200, 100);
            this.pnl_activeBikes.TabIndex = 8;
            // 
            // adminSidebar_timer
            // 
            this.adminSidebar_timer.Interval = 5;
            this.adminSidebar_timer.Tick += new System.EventHandler(this.sidebar_click);
            // 
            // adminBike_timer
            // 
            this.adminBike_timer.Interval = 5;
            this.adminBike_timer.Tick += new System.EventHandler(this.adminBike_Click);
            // 
            // adminDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.lbl_dashboard);
            this.Controls.Add(this.btn_offers);
            this.Controls.Add(this.btn_activeBikes);
            this.Controls.Add(this.f);
            this.Controls.Add(this.pnl_offers);
            this.Controls.Add(this.pnl_activeBikes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.Name = "adminDb";
            this.Text = "adminDb";
            this.sidebar.ResumeLayout(false);
            this.bikeContainer.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sidebar;
        private FlowLayoutPanel bikeContainer;
        private FontAwesome.Sharp.IconButton btn_adminBikes;
        private FontAwesome.Sharp.IconButton btn_customerPetrolBike;
        private FontAwesome.Sharp.IconButton btn_customerElectricBike;
        private FontAwesome.Sharp.IconButton btn_logOut;
        private FontAwesome.Sharp.IconButton btn_adminHelp;
        private FontAwesome.Sharp.IconButton btn_adminPayment;
        private FontAwesome.Sharp.IconButton btn_adminDb;
        private Panel panelProfile;
        private FontAwesome.Sharp.IconButton btn_adminProfile;
        private Panel panel2;
        private Label projectName;
        private FontAwesome.Sharp.IconPictureBox menubtn;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button btn_feedback;
        private Label lbl_dashboard;
        private Button btn_offers;
        private Button btn_activeBikes;
        private Panel f;
        private Panel pnl_offers;
        private Panel pnl_activeBikes;
        private FontAwesome.Sharp.IconButton btn_rental;
        private FontAwesome.Sharp.IconButton btn_clientManagement;
        private FontAwesome.Sharp.IconButton btn_admin;
        private System.Windows.Forms.Timer adminSidebar_timer;
        private System.Windows.Forms.Timer adminBike_timer;
    }
}