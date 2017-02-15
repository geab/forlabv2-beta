using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHMorbidityTestDao : NHibernateDao<MorbidityTest>, IMorbidityTestDao
    {       
        
        public IList<MorbidityTest> GetAllMorbidityTestByClass(string classofTest)
        {
            string hql = "from MorbidityTest m where m.ClassOfTest = :ctest";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("ctest", classofTest);

            return q.List<MorbidityTest>();
        }
    }
}
