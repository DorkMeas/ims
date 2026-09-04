using System;

namespace Inventory.App.Entities
{
<<<<<<< HEAD
    // Class សម្រាប់ផ្ទុកទិន្នន័យ Username និង Password ជា Private របស់ Database User
=======
>>>>>>> 561f509 (feat: add stock)
    public class DatabaseUser
    {
        private string user;
        private string pass;

        public DatabaseUser(string username, string password)
        {
            this.user = username;
            this.pass = password;
        }

<<<<<<< HEAD
        // Method សម្រាប់ផ្តល់ទិន្នន័យ Credentials ទៅអោយ Class Connection
=======
>>>>>>> 561f509 (feat: add stock)
        public string GetCredentials()
        {
            return $"User Id={this.user};Password={this.pass};";
        }
    }
}
