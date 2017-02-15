using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastCategoryProductDao : IDao<ForecastCategoryProduct>
    {
        IList<ForecastCategoryProduct> GetFCategoryProductByProId(int fcatid, int proid, SortDirection sd);
        decimal[] GetFCategoryProAmountUsed(int fcatid, int proid);
    }
}
