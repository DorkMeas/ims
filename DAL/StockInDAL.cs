using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Inventory.App.Entities;

namespace Inventory.App.DAL
{
    public class StockInDAL
    {
        private readonly DbConnection dbCon;

        public StockInDAL(DbConnection dbConnect)
        {
            dbCon = dbConnect;
        }

        public List<StockIn> GetStockInRecords(DateTime? fromDate, DateTime? toDate)
        {
            List<StockIn> list = new List<StockIn>();
            using (SqlConnection conn = new SqlConnection(dbCon.GetConnectionString()))
            {
                string query = "SELECT * FROM StockIn WHERE DateIn BETWEEN @FromDate AND @ToDate";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate ?? DateTime.MinValue);
                    cmd.Parameters.AddWithValue("@ToDate", toDate ?? DateTime.MaxValue);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockIn s = new StockIn
                            {
                                StockInID = Convert.ToInt32(reader["StockInID"]),
                                ProductID = reader["ProductID"] != DBNull.Value ? reader["ProductID"].ToString() : "",
                                Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0,
                                DateIn = reader["DateIn"] != DBNull.Value ? Convert.ToDateTime(reader["DateIn"]) : DateTime.MinValue,
                                SupplierID = reader["SupplierID"] != DBNull.Value ? reader["SupplierID"].ToString() : "",
                                UnitCost = reader["UnitCost"] != DBNull.Value ? Convert.ToDecimal(reader["UnitCost"]) : 0,
                                TotalCost = reader["TotalCost"] != DBNull.Value ? Convert.ToDecimal(reader["TotalCost"]) : 0,
                                Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : ""
                            };
                            list.Add(s);
                        }
                    }
                }
            }
            return list;
        }

        public void InsertStockIn(StockIn stock)
        {
            using (SqlConnection conn = new SqlConnection(dbCon.GetConnectionString()))
            {
                string query = @"INSERT INTO StockIn (ProductID, Quantity, DateIn, SupplierID, UnitCost, TotalCost, Notes)
                                 VALUES (@ProductID, @Quantity, @DateIn, @SupplierID, @UnitCost, @TotalCost, @Notes)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", stock.ProductID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Quantity", stock.Quantity);
                    cmd.Parameters.AddWithValue("@DateIn", stock.DateIn);
                    cmd.Parameters.AddWithValue("@SupplierID", stock.SupplierID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UnitCost", stock.UnitCost);
                    cmd.Parameters.AddWithValue("@TotalCost", stock.TotalCost);
                    cmd.Parameters.AddWithValue("@Notes", stock.Notes ?? (object)DBNull.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStockIn(StockIn stock)
        {
            using (SqlConnection conn = new SqlConnection(dbCon.GetConnectionString()))
            {
                string query = @"UPDATE StockIn SET
                         ProductID = @ProductID,
                         Quantity = @Quantity,
                         DateIn = @DateIn,
                         SupplierID = @SupplierID,
                         UnitCost = @UnitCost,
                         TotalCost = @TotalCost,
                         Notes = @Notes
                         WHERE StockInID = @StockInID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StockInID", stock.StockInID);
                    cmd.Parameters.AddWithValue("@ProductID", stock.ProductID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Quantity", stock.Quantity);
                    cmd.Parameters.AddWithValue("@DateIn", stock.DateIn);
                    cmd.Parameters.AddWithValue("@SupplierID", stock.SupplierID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UnitCost", stock.UnitCost);
                    cmd.Parameters.AddWithValue("@TotalCost", stock.TotalCost);
                    cmd.Parameters.AddWithValue("@Notes", stock.Notes ?? (object)DBNull.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
