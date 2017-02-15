using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastSiteTestDao :IDao<ForecastSiteTest>
    {
        IList<ForecastSiteTest> GetFSiteTestByTestId(int ftid, int testid, SortDirection sd);
        decimal[] GetFSiteTestAdjusted(int ftid, int testid);
       IList<ForecastSiteTest> GetHistoricalTest(string period, string fMethodology, string dataUsage, int testId, int siteId, DateTime startDate, int noHistoryRecord);
       void BatchSaveForecastSiteTest(IList<ForecastSiteTest> list);

    }
}
