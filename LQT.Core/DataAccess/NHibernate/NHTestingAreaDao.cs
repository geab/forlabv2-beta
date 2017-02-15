using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHTestingAreaDao : NHibernateDao<TestingArea>, ITestingAreaDao
    {
       
        public TestingArea GetTestingAreaByName(string name)
        {
            string hql = "from TestingArea a where a.AreaName = :aname";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("aname", name);
            
            IList<TestingArea> result = q.List<TestingArea>();

            if (result.Count > 0)
                return result[0];

            return null;
        }

        public IList<TestingArea> GetTestingAreaByDemography(Boolean inDemo)
        {
            string hql = "from TestingArea a where a.UseInDemography = :inDemo";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetBoolean("inDemo", inDemo);
            IList<TestingArea> result = q.List<TestingArea>();

            return result;
        }

        public IList<Instrument> GetDistinctInstrumentByCategory(string category)
        {
            string hql = "from Instrument I where I.TestingArea.Id = from TestingArea a where a.Category = :category";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("category", category);

            IList<Instrument> result = q.List<Instrument>();

            return result;
        }

        public TestingArea GetTestingAreaByClassOfMorbidity(string category)
        {
            string hql = "from TestingArea a where a.Category = :cat";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("cat", category);

            return q.UniqueResult<TestingArea>();
        }
    }
}
