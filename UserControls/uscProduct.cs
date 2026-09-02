using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory.App.BLL;
using Inventory.App.Entities;

namespace Inventory.App.UserControls
{
    public partial class uscProduct : UserControl
    {
        private ProductBLL proBLL;	// ប្រកាស BLL សម្រាប់ Product
        private CategoryBLL catBLL;	// ប្រកាស BLL សម្រាប់ Category

        public uscProduct()
        {
            InitializeComponent();
        }

        // កូដស្របតាម 4-Layers
        private void LoadCategoryID()
        {
            try
            {
                List<Category> categories = catBLL.GetCategoriesData();
                this.cboCategoryID.DataSource = categories;
                this.cboCategoryID.DisplayMember = "CategoryName";
                this.cboCategoryID.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហាក្នុងការទាញយកប្រភេទផលិតផល៖ " + ex.Message);
            }
        }

        // ទទួលយក Object DatabaseUser ពី MainForm
        public void InitializeControl(DatabaseUser user)
        {
            try
            {
                proBLL = new ProductBLL(user);
                catBLL = new CategoryBLL(user);
                LoadCategoryID();
                LoadProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("បរាជ័យក្នុងការភ្ជាប់ទិន្នន័យ៖ " + ex.Message);
            }
        }

        private void LoadProductData()
        {
            if (proBLL == null) return;
            List<Product> products = proBLL.GetProductsData();
            dgvProducts.DataSource = products;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var newProduct = new Product
                {
                    ProductID = txtProductID.Text.Trim(),
                    ProductName = txtProductName.Text.Trim(),
                    CategoryID = cboCategoryID.SelectedValue?.ToString() ?? "",
                    UnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal price) ? price : 0,
                    QuantityInStock = int.TryParse(txtQtyInStock.Text, out int qty) ? qty : 0,
                    Description = txtDescription.Text.Trim(),
                    Barcode = txtBarcode.Text.Trim(),
                    ReOrderLevel = int.TryParse(txtReorderLevel.Text, out int reOrder) ? reOrder : 0,
                    LastUpdated = DateTime.Now
                };
                proBLL.AddNewProduct(newProduct);
                MessageBox.Show("ទិន្នន័យត្រូវបានបញ្ចូលជោគជ័យ!");
                LoadProductData();
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហា៖ " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text))
                {
                    MessageBox.Show("សូមជ្រើសរើស Product ដើម្បី Update!");
                    return;
                }
                var product = new Product
                {
                    ProductID = txtProductID.Text.Trim(),
                    ProductName = txtProductName.Text.Trim(),
                    CategoryID = cboCategoryID.SelectedValue?.ToString() ?? "",
                    UnitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal price) ? price : 0,
                    QuantityInStock = int.TryParse(txtQtyInStock.Text, out int qty) ? qty : 0,
                    Description = txtDescription.Text.Trim(),
                    Barcode = txtBarcode.Text.Trim(),
                    ReOrderLevel = int.TryParse(txtReorderLevel.Text, out int reOrder) ? reOrder : 0,
                    LastUpdated = DateTime.Now
                };
                proBLL.UpdateProduct(product);
                MessageBox.Show("ទិន្នន័យត្រូវបានកែប្រែជោគជ័យ!");
                LoadProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហា៖ " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductID.Text))
                {
                    MessageBox.Show("សូមជ្រើសរើស Product ដើម្បី Delete!");
                    return;
                }
                if (MessageBox.Show("តើអ្នកប្រាកដជាចង់លុប Product នេះទេ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    proBLL.DeleteProduct(txtProductID.Text.Trim());
                    MessageBox.Show("ទិន្នន័យត្រូវបានលុបជោគជ័យ!");
                    LoadProductData();
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("មានបញ្ហា៖ " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            cboCategoryID.SelectedIndex = -1;
            txtUnitPrice.Clear();
            txtQtyInStock.Clear();
            txtDescription.Clear();
            txtBarcode.Clear();
            txtReorderLevel.Clear();
            txtLastUpdated.Clear();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            txtProductID.Text = row.Cells["ProductID"].Value?.ToString() ?? "";
            txtProductName.Text = row.Cells["ProductName"].Value?.ToString() ?? "";
            string catId = row.Cells["CategoryID"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(catId))
                cboCategoryID.SelectedValue = catId;
            txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString() ?? "";
            txtQtyInStock.Text = row.Cells["QuantityInStock"].Value?.ToString() ?? "";
            txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";
            txtBarcode.Text = row.Cells["Barcode"].Value?.ToString() ?? "";
            txtReorderLevel.Text = row.Cells["ReOrderLevel"].Value?.ToString() ?? "";
            txtLastUpdated.Text = row.Cells["LastUpdated"].Value?.ToString() ?? "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (proBLL == null) return;
            string keyword = txtSearch.Text.Trim().ToLower();
            List<Product> all = proBLL.GetProductsData();
            if (string.IsNullOrEmpty(keyword))
            {
                dgvProducts.DataSource = all;
                return;
            }
            var filtered = all.FindAll(p =>
                (p.ProductID ?? "").ToLower().Contains(keyword) ||
                (p.ProductName ?? "").ToLower().Contains(keyword) ||
                (p.Barcode ?? "").ToLower().Contains(keyword));
            dgvProducts.DataSource = filtered;
        }
    }
}
