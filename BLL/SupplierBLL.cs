using System.Collections.Generic;
using Inventory.App.DAL;
using Inventory.App.Entities;

namespace Inventory.App.BLL
{
    public class SupplierBLL
    {
        private readonly SupplierDAL supDAL;

        public SupplierBLL(DatabaseUser user)
        {
            DbConnection dbConnection = new DbConnection(user);
            supDAL = new SupplierDAL(dbConnection);
        }

        public List<Supplier> GetSuppliersData()
        {
            return supDAL.GetAllSuppliers();
        }

        public List<Supplier> GetSuppliersDataWith_SupId_N_SupName()
        {
            return supDAL.GetSuppliersWith_Id_N_Name();
        }
    }
}
