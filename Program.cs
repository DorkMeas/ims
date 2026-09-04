<<<<<<< HEAD
using System;
using System.Windows.Forms;
using Inventory.App.UI;

namespace Inventory.App
{
    internal static class Program
    {
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.UI;

namespace Inventory
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
>>>>>>> 561f509 (feat: add stock)
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
