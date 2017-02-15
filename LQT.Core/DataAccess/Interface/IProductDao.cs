using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IProductDao :IDao<MasterProduct>
    {
        IList<MasterProduct> GetAllProductByType(int typeid);
        IList<MasterProduct> GetAllProductByClassOfTest(string classofTest);
        IList<MasterProduct> GetAllProductByClassOfTest(string classofTest, string rapidtestGroup);
        MasterProduct GetProductByName(string pname);
        decimal GetProductPrice(int proid, DateTime fromdate);
        IList<MasterProduct> GetPagingProducts(int typeId, int firstResult, int maxResult);
        int GetTotalCountOfProducts(int typeId);
    }
}
