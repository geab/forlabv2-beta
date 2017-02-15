using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForlabRegionDao : IDao<ForlabRegion>
    {
        ForlabRegion GetRegionByName(string rname);
    }
}
