using System;

namespace Inventory.App.Entities
{
    public class StockIn
    {
        public int StockInID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateIn { get; set; }
        public string SupplierID { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }
        public string Notes { get; set; }
    }
}
