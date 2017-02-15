using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHProductUsageDao : NHibernateDao<ProductUsage>, IProductUsageDao
    {
        
        public IList<ProductUsage> GetProductUsageByInsId(int instrumentid)
        {
            string hql = "from ProductUsage t where t.Instrument.Id = :insid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("insid", instrumentid);

            return q.List<ProductUsage>();
        }
        public IList<ProductUsage> GetProductUsageByInsId(int instrumentid, bool isforcontrol)
        {
            string hql = "from ProductUsage t where t.Instrument.Id = :insid and t.IsForControl = :isforc";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("insid", instrumentid);
            q.SetBoolean("isforc", isforcontrol);

            return q.List<ProductUsage>();
        }

        public IList<ProductUsage> GetProductUsageByTestId(int testid, bool isforcontrol)
        {
            string hql = "from ProductUsage t where t.Test.Id = :insid and t.IsForControl = :isforc";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("insid", testid);
            q.SetBoolean("isforc", isforcontrol);

            return q.List<ProductUsage>();
        }
    }
}
