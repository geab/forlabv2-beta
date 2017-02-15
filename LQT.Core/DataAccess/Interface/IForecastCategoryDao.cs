using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForecastCategoryDao : IDao<ForecastCategory>
    {
        ForecastCategory GetForecastCategoryByName(int fcastid, string cname);

        IList<ForecastCategory> GetFCategory(int fid);        
    }
}
