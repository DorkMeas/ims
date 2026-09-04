using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory.App.BLL;
using Inventory.App.Entities;

namespace Inventory.App.UserControls
{
    public partial class uscStockIn : UserControl
    {
        private StockInBLL stockBLL;
        private ProductBLL proBLL;
        private SupplierBLL supBLL;

        public uscStockIn()
        {
            InitializeComponent();
            this.txtTotalCost.Enabled = false;
            this.txtStockInID.ReadOnly = true;
            this.dtpFrom.Value = DateTime.Now.AddMonths(-3);
            this.dtpTo.Value = DateTime.Now.AddDays(1);
        }

        public void InitializeControl(DatabaseUser user)
        {
            try
            {
                this.stockBLL = new StockInBLL(user);
                this.proBLL = new ProductBLL(user);
                this.supBLL = new SupplierBLL(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize BLL: " + ex.Message);
                return;
            }

            try { this.LoadDataIntoComboProducts(); }
            catch (Exception ex) { MessageBox.Show("Failed to load Products: " + ex.Message); }

            try { this.LoadDataIntoComboSupplier(); }
            catch (Exception ex) { MessageBox.Show("Failed to load Suppliers: " + ex.Message + "\n\nPlease run Database/Add_Suppliers_StockIn.sql in SSMS."); }

            try { this.LoadStockIn(); }
            catch (Exception ex) { MessageBox.Show("Failed to load Stock-In: " + ex.Message + "\n\nPlease run Database/Add_Suppliers_StockIn.sql in SSMS."); }
        }

        private void LoadDataIntoComboProducts()
        {
            if (proBLL == null) return;
            var products = proBLL.GetProductsData_with_ProId_N_ProName();
            this.cboProductID.DataSource = products;
            this.cboProductID.DisplayMember = "ProductName";
            this.cboProductID.ValueMember = "ProductID";
            this.cboProductID.SelectedIndex = -1;
        }

        private void LoadDataIntoComboSupplier()
        {
            if (supBLL == null) return;
            var suppliers = supBLL.GetSuppliersDataWith_SupId_N_SupName();
            this.cboSupplierID.DataSource = suppliers;
            this.cboSupplierID.DisplayMember = "SupplierName";
            this.cboSupplierID.ValueMember = "SupplierID";
            this.cboSupplierID.SelectedIndex = -1;
        }

        public void LoadStockIn()
        {
            if (this.stockBLL == null) return;
            List<StockIn> stockInList = stockBLL.GetStockInData(this.dtpFrom.Value, this.dtpTo.Value);
            this.dgvStockIn.DataSource = stockInList;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProductID.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Product!");
                    return;
                }
                if (cboSupplierID.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Supplier!");
                    return;
                }
                if (!int.TryParse(txtQtyInToStock.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("Please enter a valid Quantity greater than zero!");
                    return;
                }
                if (!decimal.TryParse(txtUnitCost.Text, out decimal unitCost) || unitCost < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Price!");
                    return;
                }

                StockIn stock = new StockIn
                {
                    ProductID = cboProductID.SelectedValue.ToString(),
                    Quantity = qty,
                    DateIn = dtpLastUpdated.Value,
                    SupplierID = cboSupplierID.SelectedValue.ToString(),
                    UnitCost = unitCost,
                    TotalCost = qty * unitCost,
                    Notes = txtNotes.Text.Trim()
                };
                stockBLL.AddStockIn(stock);
                MessageBox.Show("Stock-In inserted successfully!");
                this.LoadStockIn();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStockInID.Text))
                {
                    MessageBox.Show("Please select a Stock-In record to update!");
                    return;
                }
                if (cboProductID.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Product!");
                    return;
                }
                if (cboSupplierID.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Supplier!");
                    return;
                }
                if (!int.TryParse(txtQtyInToStock.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("Please enter a valid Quantity greater than zero!");
                    return;
                }
                if (!decimal.TryParse(txtUnitCost.Text, out decimal unitCost) || unitCost < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Price!");
                    return;
                }

                StockIn stock = new StockIn
                {
                    StockInID = Convert.ToInt32(txtStockInID.Text),
                    ProductID = cboProductID.SelectedValue.ToString(),
                    Quantity = qty,
                    DateIn = dtpLastUpdated.Value,
                    SupplierID = cboSupplierID.SelectedValue.ToString(),
                    UnitCost = unitCost,
                    TotalCost = qty * unitCost,
                    Notes = txtNotes.Text.Trim()
                };
                stockBLL.UpdateStockIn(stock);
                MessageBox.Show("Stock-In updated successfully!");
                this.LoadStockIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (stockBLL == null) return;
                var data = stockBLL.GetStockInData(dtpFrom.Value, dtpTo.Value);
                dgvStockIn.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (stockBLL == null) return;
            try
            {
                List<StockIn> list = stockBLL.GetStockInData(dtpFrom.Value, dtpTo.Value);
                int totalRecords = list.Count;
                int totalQty = 0;
                decimal totalValue = 0;
                foreach (var s in list)
                {
                    totalQty += s.Quantity;
                    totalValue += s.TotalCost;
                }

                string report =
                    "===== Stock-In Report =====\n\n" +
                    "From Date      : " + dtpFrom.Value.ToString("yyyy-MM-dd") + "\n" +
                    "To Date        : " + dtpTo.Value.ToString("yyyy-MM-dd") + "\n\n" +
                    "Total Records  : " + totalRecords + "\n" +
                    "Total Quantity : " + totalQty + "\n" +
                    "Total Value    : " + totalValue.ToString("N2") + " $\n\n" +
                    "Generated      : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                MessageBox.Show(report, "Stock-In Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate report: " + ex.Message);
            }
        }

        private void dgvStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvStockIn.Rows[e.RowIndex];
            txtStockInID.Text = row.Cells["StockInID"].Value?.ToString() ?? "";
            string productId = row.Cells["ProductID"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(productId))
                cboProductID.SelectedValue = productId;
            txtQtyInToStock.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
            txtUnitCost.Text = row.Cells["UnitCost"].Value?.ToString() ?? "";
            txtTotalCost.Text = row.Cells["TotalCost"].Value?.ToString() ?? "";
            txtNotes.Text = row.Cells["Notes"].Value?.ToString() ?? "";
            string supplierId = row.Cells["SupplierID"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(supplierId))
            {
                try { cboSupplierID.SelectedValue = Convert.ToInt32(supplierId); }
                catch { cboSupplierID.SelectedIndex = -1; }
            }
            if (row.Cells["DateIn"].Value != null && DateTime.TryParse(row.Cells["DateIn"].Value.ToString(), out DateTime dateIn))
                dtpLastUpdated.Value = dateIn;
        }

        private void txtQtyInToStock_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            if (int.TryParse(txtQtyInToStock.Text, out int qty) &&
                decimal.TryParse(txtUnitCost.Text, out decimal unitCost))
            {
                txtTotalCost.Text = (qty * unitCost).ToString("N2");
            }
            else
            {
                txtTotalCost.Text = "0.00";
            }
        }

        private void ClearInputs()
        {
            txtStockInID.Clear();
            cboProductID.SelectedIndex = -1;
            cboSupplierID.SelectedIndex = -1;
            txtQtyInToStock.Clear();
            txtUnitCost.Clear();
            txtTotalCost.Clear();
            txtNotes.Clear();
            dtpLastUpdated.Value = DateTime.Now;
        }
    }
}
