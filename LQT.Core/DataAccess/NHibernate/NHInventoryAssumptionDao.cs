using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;
using NHibernate.Transform;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHInventoryAssumptionDao : NHibernateDao<InventoryAssumption>, IInventoryAssumptionDao
    {
        public InventoryAssumption GetInventoryAssumptionByForecastId(int forecastId)
        {
            string hql = "from InventoryAssumption p where p.MorbidityForecast.Id =:fid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("fid", forecastId);

            IList result = q.List();
            if (result.Count >0 )
                return (InventoryAssumption)result[0];

            return null;
        }
    }
}
