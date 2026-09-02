namespace Inventory.App.UserControls
{
    partial class uscProduct
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.cboCategoryID = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblQtyInStock = new System.Windows.Forms.Label();
            this.txtQtyInStock = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.txtLastUpdated = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 50);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(900, 250);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.AutoSize = true;
            this.lblAllProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAllProducts.Location = new System.Drawing.Point(20, 15);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(110, 21);
            this.lblAllProducts.TabIndex = 1;
            this.lblAllProducts.Text = "All Products";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(650, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 23);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(840, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(20, 320);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(64, 15);
            this.lblProductID.TabIndex = 4;
            this.lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(140, 317);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 23);
            this.txtProductID.TabIndex = 5;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 355);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 15);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(140, 352);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 23);
            this.txtProductName.TabIndex = 7;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(20, 390);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(71, 15);
            this.lblCategoryID.TabIndex = 8;
            this.lblCategoryID.Text = "Category ID";
            // 
            // cboCategoryID
            // 
            this.cboCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoryID.FormattingEnabled = true;
            this.cboCategoryID.Location = new System.Drawing.Point(140, 387);
            this.cboCategoryID.Name = "cboCategoryID";
            this.cboCategoryID.Size = new System.Drawing.Size(200, 23);
            this.cboCategoryID.TabIndex = 9;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 425);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(60, 15);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(140, 422);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(200, 23);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // lblQtyInStock
            // 
            this.lblQtyInStock.AutoSize = true;
            this.lblQtyInStock.Location = new System.Drawing.Point(20, 460);
            this.lblQtyInStock.Name = "lblQtyInStock";
            this.lblQtyInStock.Size = new System.Drawing.Size(95, 15);
            this.lblQtyInStock.TabIndex = 12;
            this.lblQtyInStock.Text = "Quantity in Stock";
            // 
            // txtQtyInStock
            // 
            this.txtQtyInStock.Location = new System.Drawing.Point(140, 457);
            this.txtQtyInStock.Name = "txtQtyInStock";
            this.txtQtyInStock.Size = new System.Drawing.Size(200, 23);
            this.txtQtyInStock.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(400, 320);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 15);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(520, 317);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 15;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(400, 355);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 15);
            this.lblBarcode.TabIndex = 16;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(520, 352);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(200, 23);
            this.txtBarcode.TabIndex = 17;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Location = new System.Drawing.Point(400, 390);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(90, 15);
            this.lblReorderLevel.TabIndex = 18;
            this.lblReorderLevel.Text = "Re-Order Level";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(520, 387);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(200, 23);
            this.txtReorderLevel.TabIndex = 19;
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(400, 425);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(110, 15);
            this.lblLastUpdated.TabIndex = 20;
            this.lblLastUpdated.Text = "Last Updated (Date)";
            // 
            // txtLastUpdated
            // 
            this.txtLastUpdated.Location = new System.Drawing.Point(520, 422);
            this.txtLastUpdated.Name = "txtLastUpdated";
            this.txtLastUpdated.ReadOnly = true;
            this.txtLastUpdated.Size = new System.Drawing.Size(200, 23);
            this.txtLastUpdated.TabIndex = 21;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(140, 510);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 35);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(260, 510);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(380, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(500, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Location = new System.Drawing.Point(620, 510);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(100, 35);
            this.btnReporting.TabIndex = 26;
            this.btnReporting.Text = "Reporting ...";
            this.btnReporting.UseVisualStyleBackColor = true;
            // 
            // uscProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtLastUpdated);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtQtyInStock);
            this.Controls.Add(this.lblQtyInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.cboCategoryID);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblAllProducts);
            this.Controls.Add(this.dgvProducts);
            this.Name = "uscProduct";
            this.Size = new System.Drawing.Size(950, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblAllProducts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.ComboBox cboCategoryID;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblQtyInStock;
        private System.Windows.Forms.TextBox txtQtyInStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.TextBox txtLastUpdated;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReporting;
    }
}
