namespace Inventory.App.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panelSidebar.Controls.Add(this.btnSignOut);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnStockIn);
            this.panelSidebar.Controls.Add(this.btnStockOut);
            this.panelSidebar.Controls.Add(this.btnCustomers);
            this.panelSidebar.Controls.Add(this.btnPurchases);
            this.panelSidebar.Controls.Add(this.btnProducts);
            this.panelSidebar.Controls.Add(this.btnCategory);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.lblWelcome);
            this.panelSidebar.Controls.Add(this.picUser);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 650);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(0, 580);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(180, 40);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 420);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Location = new System.Drawing.Point(0, 380);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(180, 40);
            this.btnStockIn.TabIndex = 8;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnStockOut.FlatAppearance.BorderSize = 0;
            this.btnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStockOut.ForeColor = System.Drawing.Color.White;
            this.btnStockOut.Location = new System.Drawing.Point(0, 340);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(180, 40);
            this.btnStockOut.TabIndex = 7;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = false;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 300);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(180, 40);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnPurchases
            // 
            this.btnPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnPurchases.FlatAppearance.BorderSize = 0;
            this.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchases.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPurchases.ForeColor = System.Drawing.Color.White;
            this.btnPurchases.Location = new System.Drawing.Point(0, 260);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(180, 40);
            this.btnPurchases.TabIndex = 5;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = false;
            this.btnPurchases.Click += new System.EventHandler(this.btnPurchases_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(0, 220);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(180, 40);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(0, 180);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(180, 40);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(10, 100);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(160, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome SA";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(55, 30);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(70, 60);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(180, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 40);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Mangement System";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(950, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(180, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1000, 610);
            this.panelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelContent;
    }
}
