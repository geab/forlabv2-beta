using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IConsumableDao : IDao<MasterConsumable>
    {
        MasterConsumable GetConsumableById(int consId);
        MasterConsumable GetConsumableByTestandArea(int testId, int testingAreaId);
        IList<int> GetListOfConsumableUsageByInst(int instId);

        MasterConsumable GetConsumableByName(string name);
    }
}
