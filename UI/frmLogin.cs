using System;
using System.Windows.Forms;
using Inventory.App.Entities;

namespace Inventory.App.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
            }
            else if (username == "meas" && password == "1234")
            {
                MessageBox.Show("Login successful!");
                DatabaseUser loggedInUser = new DatabaseUser("sa", "");
                MainForm mainForm = new MainForm(loggedInUser);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
    }
}
