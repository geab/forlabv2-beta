using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IMorbiditySupplyForecastDao : IDao<MorbiditySupplyForecast>
    {
        IList GetSummaryOfTotalCost(int forecastid);
    }
}
