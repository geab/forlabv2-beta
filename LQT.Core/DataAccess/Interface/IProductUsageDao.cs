using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IProductUsageDao : IDao<ProductUsage>
    {
        IList<ProductUsage> GetProductUsageByInsId(int instrumentid);
        IList<ProductUsage> GetProductUsageByInsId(int instrumentid, bool isforcontrol);
        IList<ProductUsage> GetProductUsageByTestId(int testid, bool isforcontrol);
    }
}
