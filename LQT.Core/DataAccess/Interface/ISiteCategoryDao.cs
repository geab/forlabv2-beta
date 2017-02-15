using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface ISiteCategoryDao : IDao<SiteCategory>
    {
        SiteCategory GetSiteCategoryByName(string scname);
    }
}
