using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastCategoryTestDao : IDao<ForecastCategoryTest>
    {
        IList<ForecastCategoryTest> GetFCategoryTestByTestId(int fcid, int testid, SortDirection sd);
        decimal[] GetFCategoryTestAdjusted(int fcid, int testid);
    }
}
