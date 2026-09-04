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

<<<<<<< HEAD
        public void AddNewProduct(Product product)
        {
            if (product.UnitPrice < 0)
                throw new Exception("Unit Price មិនអាចតូចជាងសូន្យបានទេ!");
=======
        public List<Product> GetProductsData_with_ProId_N_ProName()
        {
            return proDAL.GetAllProducts_with_ProId_N_ProName();
        }

        public void AddNewProduct(Product product)
        {
            if (product.UnitPrice < 0)
                throw new Exception("Unit Price cannot be less than zero!");
>>>>>>> 561f509 (feat: add stock)
            proDAL.InsertProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            if (product.UnitPrice < 0)
<<<<<<< HEAD
                throw new Exception("Unit Price មិនអាចតូចជាងសូន្យបានទេ!");
=======
                throw new Exception("Unit Price cannot be less than zero!");
>>>>>>> 561f509 (feat: add stock)
            proDAL.UpdateProduct(product);
        }

        public void DeleteProduct(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId))
<<<<<<< HEAD
                throw new Exception("ProductID មិនអាចទទេបានទេ!");
=======
                throw new Exception("ProductID cannot be empty!");
>>>>>>> 561f509 (feat: add stock)
            proDAL.DeleteProduct(productId);
        }
    }
}
