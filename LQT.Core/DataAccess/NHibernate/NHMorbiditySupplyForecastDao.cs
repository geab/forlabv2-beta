using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHMorbiditySupplyForecastDao: NHibernateDao<MorbiditySupplyForecast>, IMorbiditySupplyForecastDao
    {
        public IList GetSummaryOfTotalCost(int forecastid)
        {
            string sql = " SELECT Platform, sum(FinalQuantity * UnitCost) as amount  FROM MorbiditySupplyForecast";
            sql += String.Format(" where MForecastId = {0}  group by Platform", forecastid);

            ISession session = NHibernateHelper.OpenSession();
            return session.CreateSQLQuery(sql)
                 .AddScalar("Platform", NHibernateUtil.Int32)
                 .AddScalar("amount", NHibernateUtil.Double)
                 .List();
        }
    }
}
