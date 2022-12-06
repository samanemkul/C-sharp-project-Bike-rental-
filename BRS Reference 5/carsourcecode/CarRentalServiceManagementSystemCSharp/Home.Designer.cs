namespace CarRentalServiceManagementSystemCSharp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RentalCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RentalCarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RentalCarToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.NewCarToolStripMenuItem,
            this.CategoryManagementToolStripMenuItem,
            this.SearchToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(638, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // RentalCarToolStripMenuItem
            // 
            this.RentalCarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RentalCarToolStripMenuItem.Name = "RentalCarToolStripMenuItem";
            this.RentalCarToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.RentalCarToolStripMenuItem.Text = "Rental Car";
            this.RentalCarToolStripMenuItem.Click += new System.EventHandler(this.RentalCarToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.CustomerToolStripMenuItem.Text = "New Customer";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // NewCarToolStripMenuItem
            // 
            this.NewCarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.NewCarToolStripMenuItem.Name = "NewCarToolStripMenuItem";
            this.NewCarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.NewCarToolStripMenuItem.Text = "New Car";
            this.NewCarToolStripMenuItem.Click += new System.EventHandler(this.NewCarToolStripMenuItem_Click);
            // 
            // CategoryManagementToolStripMenuItem
            // 
            this.CategoryManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CategoryManagementToolStripMenuItem.Name = "CategoryManagementToolStripMenuItem";
            this.CategoryManagementToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.CategoryManagementToolStripMenuItem.Text = "Category Management";
            this.CategoryManagementToolStripMenuItem.Click += new System.EventHandler(this.CategoryManagementToolStripMenuItem_Click);
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarToolStripMenuItem,
            this.CustomerToolStripMenuItem1,
            this.RentalCarToolStripMenuItem1});
            this.SearchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.SearchToolStripMenuItem.Text = "Search";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // CarToolStripMenuItem
            // 
            this.CarToolStripMenuItem.Name = "CarToolStripMenuItem";
            this.CarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.CarToolStripMenuItem.Text = "car";
            this.CarToolStripMenuItem.Click += new System.EventHandler(this.CarToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem1
            // 
            this.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1";
            this.CustomerToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.CustomerToolStripMenuItem1.Text = "Customer";
            this.CustomerToolStripMenuItem1.Click += new System.EventHandler(this.CustomerToolStripMenuItem1_Click);
            // 
            // RentalCarToolStripMenuItem1
            // 
            this.RentalCarToolStripMenuItem1.Name = "RentalCarToolStripMenuItem1";
            this.RentalCarToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.RentalCarToolStripMenuItem1.Text = "Rental Car";
            this.RentalCarToolStripMenuItem1.Click += new System.EventHandler(this.RentalCarToolStripMenuItem1_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 425);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem RentalCarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewCarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CategoryManagementToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem RentalCarToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}