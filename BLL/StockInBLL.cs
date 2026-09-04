using System;
using System.Collections.Generic;
using Inventory.App.DAL;
using Inventory.App.Entities;

namespace Inventory.App.BLL
{
    public class StockInBLL
    {
        private readonly StockInDAL stockDAL;

        public StockInBLL(DatabaseUser user)
        {
            DbConnection dbConnection = new DbConnection(user);
            stockDAL = new StockInDAL(dbConnection);
        }

        public List<StockIn> GetStockInData(DateTime? fromDate, DateTime? toDate)
        {
            return stockDAL.GetStockInRecords(fromDate, toDate);
        }

        public void AddStockIn(StockIn stock)
        {
            if (stock.Quantity <= 0)
                throw new Exception("Quantity cannot be less than or equal to zero!");
            stock.TotalCost = stock.Quantity * stock.UnitCost;
            stockDAL.InsertStockIn(stock);
        }

        public void UpdateStockIn(StockIn stock)
        {
            if (stock.Quantity <= 0)
                throw new Exception("Quantity cannot be less than or equal to zero!");
            if (stock.StockInID <= 0)
                throw new Exception("Invalid Stock-In ID!");
            stock.TotalCost = stock.Quantity * stock.UnitCost;
            stockDAL.UpdateStockIn(stock);
        }
    }
}
