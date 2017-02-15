using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IFTableDao : IDao<FTable>
    {
        IList<MasterProduct> GetFTableProducts(int finfoid);
        IList GetFResult(int finfoid, int proid);
        IList<FTable> GetFTableByFinfoId(int finfoid);
        IList RptForecastTestSummary(int finfoid);
    }
}
