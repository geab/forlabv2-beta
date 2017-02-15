using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastInfoDao : IDao<ForecastInfo>
    {
        IList<ForecastInfo> GetForecastInfoByMethodology(string methodology);
        IList<ForecastInfo> GetForecastInfoByDatausage(string methodology, string datausage);

        int FSTotalProductCount(int id);
        int FCTotalProductCount(int id);
        int FSTotalTestCount(int id);
        int FCTotalTestCount(int id);
    }
}
