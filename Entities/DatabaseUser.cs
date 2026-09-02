using System;

namespace Inventory.App.Entities
{
    // Class សម្រាប់ផ្ទុកទិន្នន័យ Username និង Password ជា Private របស់ Database User
    public class DatabaseUser
    {
        private string user;
        private string pass;

        public DatabaseUser(string username, string password)
        {
            this.user = username;
            this.pass = password;
        }

        // Method សម្រាប់ផ្តល់ទិន្នន័យ Credentials ទៅអោយ Class Connection
        public string GetCredentials()
        {
            return $"User Id={this.user};Password={this.pass};";
        }
    }
}
