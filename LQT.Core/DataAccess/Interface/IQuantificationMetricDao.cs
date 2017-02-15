using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IQuantificationMetricDao : IDao<QuantificationMetric>
    {
        IList<QuantificationMetric> GetAllQuantificationMetricByClass(string classofTest);
        IList<QuantificationMetric> GetListOfAllQuantificationMetrics();
    }
}
