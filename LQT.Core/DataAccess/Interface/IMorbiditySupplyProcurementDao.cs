using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IMorbiditySupplyProcurementDao : IDao<MorbiditySupplyProcurement>
    {
        IList<MorbiditySupplyProcurement> GetMorbiditySupplyForecastSummery(int MForecastId);
        void BatchSaveMorbiditySupplyProcurement(IList<MorbiditySupplyProcurement> list);
        void DeleteAllSupplyForecastSummery(int MForecastId);

        
        IList<MorbiditySupplyProcurement> GetMorbiditySPByForecastId(int forecastId);
        IList<MorbiditySupplyProcurement> GetMorbiditySPByForecastIdPlatformId(int forecastId, int platformId);

        IList<MorbiditySupplyProcurement> GetSupplyProcurementByForecastId(int MforecastId);
    }
}
