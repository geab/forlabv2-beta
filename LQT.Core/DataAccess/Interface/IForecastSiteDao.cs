using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastSiteDao : IDao<ForecastSite>
    {
        IList<ForlabSite> GetFSite(int fid);
    }
}
