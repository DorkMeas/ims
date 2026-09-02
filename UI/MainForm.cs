using System;
using System.Drawing;
using System.Windows.Forms;
using Inventory.App.Entities;
using Inventory.App.UserControls;

namespace Inventory.App.UI
{
    public partial class MainForm : Form
    {
        private readonly DatabaseUser currentUser;
        private uscProduct uscProduct1;

        public MainForm(DatabaseUser user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.uscProduct1 = new uscProduct();
            this.uscProduct1.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(this.uscProduct1);
            this.uscProduct1.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome SA";
            ShowProducts();
        }

        private void ShowProducts()
        {
            uscProduct1.Show();
            uscProduct1.InitializeControl(currentUser);
            HighlightButton(btnProducts);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnHome);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnCategory);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnPurchases);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnCustomers);
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnStockOut);
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnStockIn);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
            HighlightButton(btnDashboard);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HighlightButton(Button activeBtn)
        {
            Color normal = Color.FromArgb(0, 191, 255);
            Color active = Color.FromArgb(135, 206, 250);
            btnHome.BackColor = normal;
            btnCategory.BackColor = normal;
            btnProducts.BackColor = normal;
            btnPurchases.BackColor = normal;
            btnCustomers.BackColor = normal;
            btnStockOut.BackColor = normal;
            btnStockIn.BackColor = normal;
            btnDashboard.BackColor = normal;
            activeBtn.BackColor = active;
        }
    }
}
