using System;
using System.Drawing;
using System.Windows.Forms;
using Inventory.App.Entities;
using Inventory.App.UserControls;
<<<<<<< HEAD
=======
using Inventory.UI;
>>>>>>> 561f509 (feat: add stock)

namespace Inventory.App.UI
{
    public partial class MainForm : Form
    {
        private readonly DatabaseUser currentUser;
        private uscProduct uscProduct1;
<<<<<<< HEAD
=======
        private uscStockIn uscStockIn1;
>>>>>>> 561f509 (feat: add stock)

        public MainForm(DatabaseUser user)
        {
            InitializeComponent();
            this.currentUser = user;
<<<<<<< HEAD
=======

>>>>>>> 561f509 (feat: add stock)
            this.uscProduct1 = new uscProduct();
            this.uscProduct1.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(this.uscProduct1);
            this.uscProduct1.Hide();
<<<<<<< HEAD
=======

            this.uscStockIn1 = new uscStockIn();
            this.uscStockIn1.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(this.uscStockIn1);
            this.uscStockIn1.Hide();
>>>>>>> 561f509 (feat: add stock)
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome SA";
            ShowProducts();
        }

<<<<<<< HEAD
        private void ShowProducts()
        {
=======
        private void HideAllUserControls()
        {
            uscProduct1.Hide();
            uscStockIn1.Hide();
        }

        private void ShowProducts()
        {
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
            uscProduct1.Show();
            uscProduct1.InitializeControl(currentUser);
            HighlightButton(btnProducts);
        }

<<<<<<< HEAD
        private void btnHome_Click(object sender, EventArgs e)
        {
            uscProduct1.Hide();
=======
        private void ShowStockIn()
        {
            HideAllUserControls();
            uscStockIn1.Show();
            uscStockIn1.InitializeControl(currentUser);
            HighlightButton(btnStockIn);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
            HighlightButton(btnHome);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            uscProduct1.Hide();
=======
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
            HighlightButton(btnCategory);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            uscProduct1.Hide();
=======
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
            HighlightButton(btnPurchases);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            uscProduct1.Hide();
=======
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
            HighlightButton(btnCustomers);
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            uscProduct1.Hide();
=======
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
            HighlightButton(btnStockOut);
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            uscProduct1.Hide();
            HighlightButton(btnStockIn);
=======
            ShowStockIn();
>>>>>>> 561f509 (feat: add stock)
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            uscProduct1.Hide();
=======
            HideAllUserControls();
>>>>>>> 561f509 (feat: add stock)
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
