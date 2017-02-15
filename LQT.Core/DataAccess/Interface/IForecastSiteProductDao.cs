using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastSiteProductDao :IDao<ForecastSiteProduct>
    {
        IList<ForecastSiteProduct> GetFSiteProductByProId(int fsiteid, int proid, SortDirection sd);
        decimal[] GetFSiteProAmountUsed(int fsiteid, int proid);
        IList<ForecastSiteProduct> GetHistoricalProduct(string period, string fMethodology, string dataUsage, int productId, int siteId, DateTime startDate, int noHistoryRecord);
        void BatchSaveForecastSiteProduct(IList<ForecastSiteProduct> list);
        IList<ForecastSiteProduct> GetFSiteSummarybyFSid(int fsiteid, SortDirection sd);
    }
}
