using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{

    public class NHProtocolDao : NHibernateDao<Protocol>, IProtocolDao
    {
        public Protocol GetProtocolByPlatform(int Platformid)
        {

            string hql = "from Protocol p where p.ProtocolType = :Platformid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("Platformid", Platformid);

            IList<Protocol> result= q.List<Protocol>();
            if (result.Count > 0)
                return result[0];
            return null;
        }
    }
}
