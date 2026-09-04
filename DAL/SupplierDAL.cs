using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Inventory.App.Entities;

namespace Inventory.App.DAL
{
    public class SupplierDAL
    {
        private readonly DbConnection dbCon;

        public SupplierDAL(DbConnection dbConnect)
        {
            dbCon = dbConnect;
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliersList = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(dbCon.GetConnectionString()))
            {
                string query = @"SELECT SupplierID, SupplierName, ContactPerson, Phone, Email, Address FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier s = new Supplier
                            {
                                SupplierID = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0,
                                SupplierName = reader["SupplierName"] != DBNull.Value ? reader["SupplierName"].ToString() : "",
                                ContactPerson = reader["ContactPerson"] != DBNull.Value ? reader["ContactPerson"].ToString() : "",
                                Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : "",
                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                                Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : ""
                            };
                            suppliersList.Add(s);
                        }
                    }
                }
            }
            return suppliersList;
        }

        public List<Supplier> GetSuppliersWith_Id_N_Name()
        {
            List<Supplier> suppliersList = new List<Supplier>();
            using (SqlConnection conn = new SqlConnection(dbCon.GetConnectionString()))
            {
                string query = @"SELECT SupplierID,
                                       CAST(SupplierID AS nvarchar(10)) + ' - ' + SupplierName AS Supplier_Id_Name,
                                       ContactPerson, Phone, Email, Address
                                FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier s = new Supplier
                            {
                                SupplierID = reader["SupplierID"] != DBNull.Value ? Convert.ToInt32(reader["SupplierID"]) : 0,
                                SupplierName = reader["Supplier_Id_Name"] != DBNull.Value ? reader["Supplier_Id_Name"].ToString() : "",
                                ContactPerson = reader["ContactPerson"] != DBNull.Value ? reader["ContactPerson"].ToString() : "",
                                Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : "",
                                Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "",
                                Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : ""
                            };
                            suppliersList.Add(s);
                        }
                    }
                }
            }
            return suppliersList;
        }
    }
}
