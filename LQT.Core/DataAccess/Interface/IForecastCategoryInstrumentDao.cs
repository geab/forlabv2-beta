using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastCategoryInstrumentDao : IDao<ForecastCategoryInstrument>
    {
        IList<ForecastCategoryInstrument> GetFCInstrumentByFinfoId(int fid);
        ForecastCategoryInstrument GetFCInstrumentById(int id);
       // void DeleteFCInstrument(int id);
        ForecastCategoryInstrument GetFCInstrumentByInstrumentId(int iid);
    }
}
