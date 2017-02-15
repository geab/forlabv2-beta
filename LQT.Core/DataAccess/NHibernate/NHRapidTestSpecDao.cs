using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHRapidTestSpecDao : NHibernateDao<RapidTestSpec>, IRapidTestSpecDao
    {
        public IList<RapidTestSpec> GetRapidTestSpecByTestGroup(string testgroup)
        {

            string hql = "from RapidTestSpec r where r.TestGroup = :tgroup order by r.ProductOrder asc";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("tgroup", testgroup);

            return q.List<RapidTestSpec>();

        }

    }
}
