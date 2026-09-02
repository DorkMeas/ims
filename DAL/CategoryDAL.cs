using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Inventory.App.Entities;

namespace Inventory.App.DAL
{
    public class CategoryDAL
    {
        private readonly DbConnection _dbConnection;

        public CategoryDAL(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categoryList = new List<Category>();
            using (SqlConnection conn = new SqlConnection(_dbConnection.GetConnectionString()))
            {
                string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryList.Add(new Category
                            {
                                CategoryID = reader["CategoryID"] != DBNull.Value ? reader["CategoryID"].ToString() : "",
                                CategoryName = reader["CategoryName"] != DBNull.Value ? reader["CategoryName"].ToString() : "",
                                Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : ""
                            });
                        }
                    }
                }
            }
            return categoryList;
        }
    }
}
