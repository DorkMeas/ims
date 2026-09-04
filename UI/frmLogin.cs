<<<<<<< HEAD
using System;
using System.Windows.Forms;
using Inventory.App.Entities;

namespace Inventory.App.UI
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.App.DAL;
using Inventory.App.Entities;
using Inventory.App.UI;

namespace Inventory.UI
>>>>>>> 561f509 (feat: add stock)
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Username and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseUser loggedInUser = new DatabaseUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            try
            {
                DbConnection dbConn = new DbConnection(loggedInUser);
                using (SqlConnection conn = new SqlConnection(dbConn.GetConnectionString()))
                {
                    conn.Open();
                }

>>>>>>> 561f509 (feat: add stock)
                MainForm mainForm = new MainForm(loggedInUser);
                mainForm.Show();
                this.Hide();
            }
<<<<<<< HEAD
            else
            {
                MessageBox.Show("Invalid username or password.");
=======
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> 561f509 (feat: add stock)
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
=======
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
>>>>>>> 561f509 (feat: add stock)
        }
    }
}
