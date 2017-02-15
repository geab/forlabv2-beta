using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IProductTypeDao :IDao<ProductType>
    {
        ProductType GetProductTypeByName(string name);
    }
}
