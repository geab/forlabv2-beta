using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHTestingGroupDao : NHibernateDao<TestingGroup>, ITestingGroupDao
    {       

        public TestingGroup GetTestingGroupByName(int areaid, string name)
        {
            TestingGroup t = new TestingGroup();
            
            string hql = "from TestingGroup g where g.TestingArea.Id = :aid and g.GroupName = :gname";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("gname", name);
            q.SetInt32("aid", areaid);

            IList<TestingGroup> result = q.List<TestingGroup>();

            if (result.Count > 0)
                return result[0];

            return null;
        }
                
    }
}
