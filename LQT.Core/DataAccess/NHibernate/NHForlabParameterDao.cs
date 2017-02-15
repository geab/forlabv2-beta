using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHForlabParameterDao : NHibernateDao<ForlabParameter>, IForlabParameterDao
    {
        public ForlabParameter GetForlabParameterByParamName(string pname)
        {
            string hql = "from ForlabParameter p where p.Id = :pname";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("pname", pname);

            object obj = q.UniqueResult();
            if (obj != null)
                return (ForlabParameter)obj;

            return null;
        }

    }
}
