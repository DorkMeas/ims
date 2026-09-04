namespace Inventory.App.UserControls
{
    partial class uscStockIn
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.dgvStockIn = new System.Windows.Forms.DataGridView();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblStockInID = new System.Windows.Forms.Label();
            this.txtStockInID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQtyInToStock = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.dtpLastUpdated = new System.Windows.Forms.DateTimePicker();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.cboSupplierID = new System.Windows.Forms.ComboBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblFrom);
            this.panelTop.Controls.Add(this.dtpFrom);
            this.panelTop.Controls.Add(this.lblTo);
            this.panelTop.Controls.Add(this.dtpTo);
            this.panelTop.Controls.Add(this.btnSearchByDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 42);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stock-IN";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(430, 13);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(66, 15);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From Date:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(500, 9);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(155, 23);
            this.dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(665, 13);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(52, 15);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To Date:";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(722, 9);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(155, 23);
            this.dtpTo.TabIndex = 4;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchByDate.BackColor = System.Drawing.Color.White;
            this.btnSearchByDate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSearchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByDate.Location = new System.Drawing.Point(888, 8);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(90, 26);
            this.btnSearchByDate.TabIndex = 5;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // dgvStockIn
            // 
            this.dgvStockIn.AllowUserToAddRows = false;
            this.dgvStockIn.AllowUserToDeleteRows = false;
            this.dgvStockIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockIn.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStockIn.Location = new System.Drawing.Point(0, 42);
            this.dgvStockIn.MultiSelect = false;
            this.dgvStockIn.Name = "dgvStockIn";
            this.dgvStockIn.ReadOnly = true;
            this.dgvStockIn.RowHeadersVisible = true;
            this.dgvStockIn.RowTemplate.Height = 25;
            this.dgvStockIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockIn.Size = new System.Drawing.Size(1000, 250);
            this.dgvStockIn.TabIndex = 1;
            this.dgvStockIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockIn_CellClick);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panelForm.Controls.Add(this.lblStockInID);
            this.panelForm.Controls.Add(this.txtStockInID);
            this.panelForm.Controls.Add(this.lblProductID);
            this.panelForm.Controls.Add(this.cboProductID);
            this.panelForm.Controls.Add(this.lblQty);
            this.panelForm.Controls.Add(this.txtQtyInToStock);
            this.panelForm.Controls.Add(this.lblUnitCost);
            this.panelForm.Controls.Add(this.txtUnitCost);
            this.panelForm.Controls.Add(this.lblLastUpdated);
            this.panelForm.Controls.Add(this.dtpLastUpdated);
            this.panelForm.Controls.Add(this.lblSupplierID);
            this.panelForm.Controls.Add(this.cboSupplierID);
            this.panelForm.Controls.Add(this.lblTotalCost);
            this.panelForm.Controls.Add(this.txtTotalCost);
            this.panelForm.Controls.Add(this.lblNotes);
            this.panelForm.Controls.Add(this.txtNotes);
            this.panelForm.Controls.Add(this.btnInsert);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Controls.Add(this.btnReport);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 292);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1000, 308);
            this.panelForm.TabIndex = 2;
            // 
            // lblStockInID
            // 
            this.lblStockInID.AutoSize = true;
            this.lblStockInID.Location = new System.Drawing.Point(100, 25);
            this.lblStockInID.Name = "lblStockInID";
            this.lblStockInID.Size = new System.Drawing.Size(70, 15);
            this.lblStockInID.TabIndex = 0;
            this.lblStockInID.Text = "Stock-In ID";
            // 
            // txtStockInID
            // 
            this.txtStockInID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStockInID.Location = new System.Drawing.Point(230, 22);
            this.txtStockInID.Name = "txtStockInID";
            this.txtStockInID.ReadOnly = true;
            this.txtStockInID.Size = new System.Drawing.Size(180, 23);
            this.txtStockInID.TabIndex = 1;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(100, 60);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(63, 15);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID";
            // 
            // cboProductID
            // 
            this.cboProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductID.FormattingEnabled = true;
            this.cboProductID.Location = new System.Drawing.Point(230, 57);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(180, 23);
            this.cboProductID.TabIndex = 3;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(100, 95);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(105, 15);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Quantity into Stock";
            // 
            // txtQtyInToStock
            // 
            this.txtQtyInToStock.Location = new System.Drawing.Point(230, 92);
            this.txtQtyInToStock.Name = "txtQtyInToStock";
            this.txtQtyInToStock.Size = new System.Drawing.Size(180, 23);
            this.txtQtyInToStock.TabIndex = 5;
            this.txtQtyInToStock.TextChanged += new System.EventHandler(this.txtQtyInToStock_TextChanged);
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(100, 130);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(58, 15);
            this.lblUnitCost.TabIndex = 6;
            this.lblUnitCost.Text = "Unit Price";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(230, 127);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(180, 23);
            this.txtUnitCost.TabIndex = 7;
            this.txtUnitCost.TextChanged += new System.EventHandler(this.txtUnitCost_TextChanged);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(500, 25);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(110, 15);
            this.lblLastUpdated.TabIndex = 8;
            this.lblLastUpdated.Text = "Last Updated (Date)";
            // 
            // dtpLastUpdated
            // 
            this.dtpLastUpdated.CustomFormat = "dddd ,  MMMM  dd, yyyy";
            this.dtpLastUpdated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastUpdated.Location = new System.Drawing.Point(630, 22);
            this.dtpLastUpdated.Name = "dtpLastUpdated";
            this.dtpLastUpdated.Size = new System.Drawing.Size(220, 23);
            this.dtpLastUpdated.TabIndex = 9;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(500, 60);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(64, 15);
            this.lblSupplierID.TabIndex = 10;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // cboSupplierID
            // 
            this.cboSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierID.FormattingEnabled = true;
            this.cboSupplierID.Location = new System.Drawing.Point(630, 57);
            this.cboSupplierID.Name = "cboSupplierID";
            this.cboSupplierID.Size = new System.Drawing.Size(220, 23);
            this.cboSupplierID.TabIndex = 11;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(500, 95);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(59, 15);
            this.lblTotalCost.TabIndex = 12;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalCost.Location = new System.Drawing.Point(630, 92);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(220, 23);
            this.txtTotalCost.TabIndex = 13;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(500, 130);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 15);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(630, 127);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(220, 23);
            this.txtNotes.TabIndex = 15;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(150, 190);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 36);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(290, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(430, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 36);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(570, 190);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 36);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "Report ...";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // uscStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.dgvStockIn);
            this.Controls.Add(this.panelTop);
            this.Name = "uscStockIn";
            this.Size = new System.Drawing.Size(1000, 600);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIn)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.DataGridView dgvStockIn;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblStockInID;
        private System.Windows.Forms.TextBox txtStockInID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cboProductID;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQtyInToStock;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.DateTimePicker dtpLastUpdated;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.ComboBox cboSupplierID;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReport;
    }
}
