using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;
using NHibernate;
//

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHForlabRegionDao : NHibernateDao<ForlabRegion>, IForlabRegionDao
    {
        public ForlabRegion GetRegionByName(string rname)
        {
            string hql = "from ForlabRegion r where r.RegionName = :rname";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("rname", rname);
            object obj = q.UniqueResult();
            if (obj != null)
                return (ForlabRegion)obj;
            return null;
        }
    }
}
