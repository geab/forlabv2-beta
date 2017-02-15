using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHProductTypeDao : NHibernateDao<ProductType>, IProductTypeDao
    {
        public ProductType GetProductTypeByName(string name)
        {
            string hql = "from ProductType t where t.TypeName = :tname";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("tname", name);

            IList<ProductType> result = q.List<ProductType>();

            if (result.Count > 0)
                return result[0];

            return null;
        }
    }
}
