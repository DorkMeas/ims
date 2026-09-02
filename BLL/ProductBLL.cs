using System;
using System.Collections.Generic;
using Inventory.App.DAL;
using Inventory.App.Entities;

namespace Inventory.App.BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL proDAL;

        public ProductBLL(DatabaseUser user)
        {
            DbConnection dbConnection = new DbConnection(user);
            proDAL = new ProductDAL(dbConnection);
        }

        public List<Product> GetProductsData()
        {
            return proDAL.GetAllProducts();
        }

        public void AddNewProduct(Product product)
        {
            if (product.UnitPrice < 0)
                throw new Exception("Unit Price មិនអាចតូចជាងសូន្យបានទេ!");
            proDAL.InsertProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            if (product.UnitPrice < 0)
                throw new Exception("Unit Price មិនអាចតូចជាងសូន្យបានទេ!");
            proDAL.UpdateProduct(product);
        }

        public void DeleteProduct(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId))
                throw new Exception("ProductID មិនអាចទទេបានទេ!");
            proDAL.DeleteProduct(productId);
        }
    }
}
