using System.Collections.Generic;
using Inventory.App.DAL;
using Inventory.App.Entities;

namespace Inventory.App.BLL
{
    public class CategoryBLL
    {
        private readonly CategoryDAL catDAL;

        public CategoryBLL(DatabaseUser user)
        {
            DbConnection dbConnection = new DbConnection(user);
            catDAL = new CategoryDAL(dbConnection);
        }

        public List<Category> GetCategoriesData()
        {
            return catDAL.GetAllCategories();
        }
    }
}
