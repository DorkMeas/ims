using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Inventory.App.Entities;

namespace Inventory.App.DAL
{
    public class ProductDAL
    {
        private readonly DbConnection _dbConnection;

        public ProductDAL(DbConnection dbConnect)
        {
            _dbConnection = dbConnect;
        }

<<<<<<< HEAD
        // ប្រើប្រាស់ List<Product> ដដែល ដើម្បីកុំឲ្យប៉ះពាល់ដល់ BLL និង UI
=======
>>>>>>> 561f509 (feat: add stock)
        public List<Product> GetAllProducts()
        {
            List<Product> productsList = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_dbConnection.GetConnectionString()))
            {
                string query = "SELECT * FROM Products";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product p = new Product
                            {
                                ProductID = reader["ProductID"] != DBNull.Value ? reader["ProductID"].ToString() : "",
                                ProductName = reader["ProductName"] != DBNull.Value ? reader["ProductName"].ToString() : "",
                                CategoryID = reader["CategoryID"] != DBNull.Value ? reader["CategoryID"].ToString() : "",
                                Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : "",
                                Barcode = reader["Barcode"] != DBNull.Value ? reader["Barcode"].ToString() : "",
                                UnitPrice = reader["UnitPrice"] != DBNull.Value ? Convert.ToDecimal(reader["UnitPrice"]) : 0,
                                QuantityInStock = reader["QuantityInStock"] != DBNull.Value ? Convert.ToInt32(reader["QuantityInStock"]) : 0,
                                ReOrderLevel = reader["ReOrderLevel"] != DBNull.Value ? Convert.ToInt32(reader["ReOrderLevel"]) : 0,
                                LastUpdated = reader["LastUpdated"] != DBNull.Value ? Convert.ToDateTime(reader["LastUpdated"]) : DateTime.MinValue
                            };
                            productsList.Add(p);
                        }
                    }
                }
            }
            return productsList;
        }

<<<<<<< HEAD
=======
        public List<Product> GetAllProducts_with_ProId_N_ProName()
        {
            List<Product> proList = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_dbConnection.GetConnectionString()))
            {
                string query = @"SELECT ProductID, CAST(ProductID AS nvarchar(10)) + ' - ' + ProductName AS Product_Id_Name FROM Products";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product p = new Product
                            {
                                ProductID = reader["ProductID"] != DBNull.Value ? reader["ProductID"].ToString() : "",
                                ProductName = reader["Product_Id_Name"] != DBNull.Value ? reader["Product_Id_Name"].ToString() : ""
                            };
                            proList.Add(p);
                        }
                    }
                }
            }
            return proList;
        }

>>>>>>> 561f509 (feat: add stock)
        public void InsertProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_dbConnection.GetConnectionString()))
            {
                string query = @"INSERT INTO Products
                         (ProductID, ProductName, CategoryID, UnitPrice, QuantityInStock, Description, Barcode, ReOrderLevel, LastUpdated)
                         VALUES
                         (@ProductID, @ProductName, @CategoryID, @UnitPrice, @QuantityInStock, @Description, @Barcode, @ReOrderLevel, @LastUpdated)";
<<<<<<< HEAD

=======
>>>>>>> 561f509 (feat: add stock)
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", product.ProductID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@QuantityInStock", product.QuantityInStock);
                    cmd.Parameters.AddWithValue("@Description", product.Description ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Barcode", product.Barcode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReOrderLevel", product.ReOrderLevel);
                    cmd.Parameters.AddWithValue("@LastUpdated", product.LastUpdated);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_dbConnection.GetConnectionString()))
            {
                string query = @"UPDATE Products SET
                         ProductName = @ProductName,
                         CategoryID = @CategoryID,
                         UnitPrice = @UnitPrice,
                         QuantityInStock = @QuantityInStock,
                         Description = @Description,
                         Barcode = @Barcode,
                         ReOrderLevel = @ReOrderLevel,
                         LastUpdated = @LastUpdated
                         WHERE ProductID = @ProductID";
<<<<<<< HEAD

=======
>>>>>>> 561f509 (feat: add stock)
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", product.ProductID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CategoryID", product.CategoryID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@QuantityInStock", product.QuantityInStock);
                    cmd.Parameters.AddWithValue("@Description", product.Description ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Barcode", product.Barcode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ReOrderLevel", product.ReOrderLevel);
                    cmd.Parameters.AddWithValue("@LastUpdated", product.LastUpdated);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(string productId)
        {
            using (SqlConnection conn = new SqlConnection(_dbConnection.GetConnectionString()))
            {
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
