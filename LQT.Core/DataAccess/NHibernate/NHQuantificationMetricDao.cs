using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHQuantificationMetricDao : NHibernateDao<QuantificationMetric>, IQuantificationMetricDao
    {       
        public IList<QuantificationMetric> GetAllQuantificationMetricByClass(string classofTest)
        {
            string hql = "from QuantificationMetric m where m.ClassOfTest = :ctest";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("ctest", classofTest);

            return q.List<QuantificationMetric>();
        }

        public IList<QuantificationMetric> GetListOfAllQuantificationMetrics()
        {
            string hql = "from QuantificationMetric m order by m.ClassOfTest, m.Product.ProductName";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            
            return q.List<QuantificationMetric>();
        }
    }
}
