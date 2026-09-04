using Inventory.App.Entities;

namespace Inventory.App.DAL
{
<<<<<<< HEAD
    // Class Connection ដាច់ដោយឡែក សម្រាប់តម្លើង Connection String
=======
>>>>>>> 561f509 (feat: add stock)
    public class DbConnection
    {
        private readonly string stringConnection;

        public DbConnection(DatabaseUser user)
        {
<<<<<<< HEAD
            string server = "Localhost";
            string database = "InventoryDB3";
            // ប្រើ Windows Authentication (Trusted Connection) ដើម្បីកុំត្រូវការ SQL Username/Password
            stringConnection = $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
=======
            string server = ".\\SQLEXPRESS";
            string database = "InventoryDB3";
            stringConnection = $"Server={server};Database={database};{user.GetCredentials()}" +
                               "TrustServerCertificate=True;" +
                               "Integrated Security=False;" +
                               "Encrypt=False;" +
                               "Connection Timeout=30;";
>>>>>>> 561f509 (feat: add stock)
        }

        public string GetConnectionString()
        {
            return stringConnection;
        }
    }
}
