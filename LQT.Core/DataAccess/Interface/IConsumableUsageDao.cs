using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;
namespace LQT.Core.DataAccess.Interface
{
    public interface IConsumableUsageDao : IDao<ConsumableUsage>
    {
        IList<ConsumableUsage> GetAllUsageByConsumableId(int consumableid);
        IList<ConsumableUsage> GetConsumableUsageByTestId(int testId);
        IList<ConsumableUsage> GetConsumableUsage(int testAreaId,QuanifyConsumableBasedOnEnum qcbEnum );
        IList<ConsumableUsage> GetConsumableUsage(int testAreaId, QuanifyConsumableBasedOnEnum qcbEnum,int insId);
        IList<ConsumableUsage> GetConsumableUsageByTestId(int testId, QuanifyConsumableBasedOnEnum qcbEnum);
    }
}
