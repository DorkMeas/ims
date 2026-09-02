using System;

namespace Inventory.App.Entities
{
    // Class សម្រាប់ផ្ទុកទិន្នន័យ Product
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public int ReOrderLevel { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
