namespace login
{
    partial class pnlCustomer
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

        #region Component Designer generated code

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
            this.btn_customerPayment = new FontAwesome.Sharp.IconButton();
            this.btn_customerDb = new FontAwesome.Sharp.IconButton();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btn_customerProfile = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menubtn = new FontAwesome.Sharp.IconPictureBox();
            this.sidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.bike_timer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.bikeContainer.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.sidebar.Controls.Add(this.bikeContainer);
            this.sidebar.Controls.Add(this.btn_logOut);
            this.sidebar.Controls.Add(this.btn_customerHelp);
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
            this.sidebar.TabIndex = 1;
            // 
            // bikeContainer
            // 
            this.bikeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bikeContainer.Controls.Add(this.btn_customerBikes);
            this.bikeContainer.Controls.Add(this.btn_customerPetrolBike);
            this.bikeContainer.Controls.Add(this.btn_customerElectricBike);
            this.bikeContainer.Location = new System.Drawing.Point(9, 159);
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
            this.btn_customerBikes.Size = new System.Drawing.Size(193, 38);
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
            this.btn_logOut.Location = new System.Drawing.Point(13, 527);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(188, 38);
            this.btn_logOut.TabIndex = 0;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
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
            this.btn_customerHelp.Location = new System.Drawing.Point(10, 258);
            this.btn_customerHelp.Name = "btn_customerHelp";
            this.btn_customerHelp.Size = new System.Drawing.Size(198, 38);
            this.btn_customerHelp.TabIndex = 0;
            this.btn_customerHelp.Text = "Help";
            this.btn_customerHelp.UseVisualStyleBackColor = true;
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
            this.btn_customerPayment.Location = new System.Drawing.Point(10, 214);
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
            this.btn_customerDb.Location = new System.Drawing.Point(10, 115);
            this.btn_customerDb.Name = "btn_customerDb";
            this.btn_customerDb.Size = new System.Drawing.Size(190, 38);
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
            this.btn_customerProfile.Location = new System.Drawing.Point(10, 7);
            this.btn_customerProfile.Name = "btn_customerProfile";
            this.btn_customerProfile.Size = new System.Drawing.Size(191, 38);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::login.Properties.Resources.Logo4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(127)))), ((int)(((byte)(21)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.menubtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 55);
            this.panel3.TabIndex = 2;
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
            // sidebar_timer
            // 
            this.sidebar_timer.Interval = 5;
            this.sidebar_timer.Tick += new System.EventHandler(this.sidebartimer_tick);
            // 
            // bike_timer
            // 
            this.bike_timer.Interval = 5;
            this.bike_timer.Tick += new System.EventHandler(this.biketimer_click);
            // 
            // pnlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebar);
            this.Name = "pnlCustomer";
            this.Size = new System.Drawing.Size(949, 568);
            this.sidebar.ResumeLayout(false);
            this.bikeContainer.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menubtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidebar;
        private FlowLayoutPanel bikeContainer;
        private FontAwesome.Sharp.IconButton btn_customerBikes;
        private FontAwesome.Sharp.IconButton btn_customerPetrolBike;
        private FontAwesome.Sharp.IconButton btn_customerElectricBike;
        private FontAwesome.Sharp.IconButton btn_logOut;
        private FontAwesome.Sharp.IconButton btn_customerHelp;
        private FontAwesome.Sharp.IconButton btn_customerPayment;
        private FontAwesome.Sharp.IconButton btn_customerDb;
        private Panel panelProfile;
        private FontAwesome.Sharp.IconButton btn_customerProfile;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label projectName;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox menubtn;
        private System.Windows.Forms.Timer sidebar_timer;
        private System.Windows.Forms.Timer bike_timer;
    }
}
