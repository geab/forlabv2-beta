using System;
using System.Collections.Generic;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Domain;
using NHibernate;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHSiteCategoryDao : NHibernateDao<SiteCategory>, ISiteCategoryDao
    {
        public SiteCategory GetSiteCategoryByName(string scname)
        {
            string hql = "from SiteCategory r where r.CategoryName = :scname";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("scname", scname);
            object obj = q.UniqueResult();
            if (obj != null)
                return (SiteCategory)obj;
            return null;
        }
    }
}
