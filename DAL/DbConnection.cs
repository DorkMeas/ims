using Inventory.App.Entities;

namespace Inventory.App.DAL
{
    // Class Connection ដាច់ដោយឡែក សម្រាប់តម្លើង Connection String
    public class DbConnection
    {
        private readonly string stringConnection;

        public DbConnection(DatabaseUser user)
        {
            string server = "Localhost";
            string database = "InventoryDB3";
            // ប្រើ Windows Authentication (Trusted Connection) ដើម្បីកុំត្រូវការ SQL Username/Password
            stringConnection = $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public string GetConnectionString()
        {
            return stringConnection;
        }
    }
}
