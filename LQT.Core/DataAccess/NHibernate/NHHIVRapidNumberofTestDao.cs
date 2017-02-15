using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;
using NHibernate.Transform;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHHIVRapidNumberofTestDao:NHibernateDao<HIVRapidNumberofTest>,IHIVRapidNumberofTestDao
    {
        public HIVRapidNumberofTest GetHIVRapidNumberofTestSummary(int forecastId)
        {
            string sql = " SELECT  SUM(Screening) AS Screening, SUM(Confirmatory) AS Confirmatory, SUM(TieBreaker) AS TieBreaker ";
            sql += " FROM  HIVRapidNumberofTest Where ForecastId=:forecastId ";
           // sql += " GROUP BY ForecastId ";

            ISession session = NHibernateHelper.OpenSession();
            IQuery sqlQuery = session.CreateSQLQuery(sql).
                //AddScalar("ForecastId", NHibernateUtil.Int32).
                              AddScalar("Screening", NHibernateUtil.Double).
                              AddScalar("Confirmatory", NHibernateUtil.Double).
                              AddScalar("TieBreaker", NHibernateUtil.Double)
                              .SetResultTransformer(Transformers.AliasToBean(typeof(HIVRapidNumberofTest)));

            sqlQuery.SetInt32("forecastId", forecastId);

            HIVRapidNumberofTest result = (HIVRapidNumberofTest)sqlQuery.UniqueResult();

            if (result != null)
                return result;
            return null;
        }
    }
}
