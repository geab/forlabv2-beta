using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IInventoryAssumptionDao : IDao<InventoryAssumption>
    {
        InventoryAssumption GetInventoryAssumptionByForecastId(int forecastId);
    }
}
