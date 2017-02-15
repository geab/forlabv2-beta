﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Domain;
using NHibernate;
using NHibernate.Transform;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHHemaandViralNumberofTestDao : NHibernateDao<HemaandViralNumberofTest>, IHemaandViralNumberofTestDao
    {
        public HemaandViralNumberofTest GetHematologyTestNumberSummary(int forecastId)
        {
            string sql = " SELECT ForecastId, SUM(TestBasedOnProtocols) AS TestBasedOnProtocols, SUM(SymptomDirectedTests) AS SymptomDirectedTests, SUM(RepeatedDuetoClinicalReq) AS RepeatedDuetoClinicalReq ";
            sql += " ,SUM(InvalidTestandWastage) AS InvalidTestandWastage, SUM(BufferStockandControls) AS BufferStockandControls, SUM(ReagentstoRunControls) AS ReagentstoRunControls ";
            sql += " FROM  dbo.HemaandViralNumberofTest Where ForecastId=:forecastId and Platform=3";
            sql += " GROUP BY ForecastId ";

            ISession session = NHibernateHelper.OpenSession();
            IQuery sqlQuery = session.CreateSQLQuery(sql).
                AddScalar("ForecastId", NHibernateUtil.Int32).
                              AddScalar("TestBasedOnProtocols", NHibernateUtil.Double).
                              AddScalar("SymptomDirectedTests", NHibernateUtil.Double).
                              AddScalar("RepeatedDuetoClinicalReq", NHibernateUtil.Double).
                                AddScalar("InvalidTestandWastage", NHibernateUtil.Double).
                              AddScalar("BufferStockandControls", NHibernateUtil.Double).
                              AddScalar("ReagentstoRunControls", NHibernateUtil.Double)
                              .SetResultTransformer(Transformers.AliasToBean(typeof(HemaandViralNumberofTest)));

            sqlQuery.SetInt32("forecastId", forecastId);

            HemaandViralNumberofTest result = (HemaandViralNumberofTest)sqlQuery.UniqueResult();

            if (result != null)
                return result;
            return null;
        }

        public HemaandViralNumberofTest GetViralLoadTestNumberSummary(int forecastId)
        {
            string sql = " SELECT ForecastId, SUM(TestBasedOnProtocols) AS TestBasedOnProtocols, SUM(SymptomDirectedTests) AS SymptomDirectedTests, SUM(RepeatedDuetoClinicalReq) AS RepeatedDuetoClinicalReq ";
            sql += " ,SUM(InvalidTestandWastage) AS InvalidTestandWastage, SUM(BufferStockandControls) AS BufferStockandControls, SUM(ReagentstoRunControls) AS ReagentstoRunControls ";
            sql += " FROM  dbo.HemaandViralNumberofTest Where ForecastId=:forecastId and Platform=4";
            sql += " GROUP BY ForecastId ";

            ISession session = NHibernateHelper.OpenSession();
            IQuery sqlQuery = session.CreateSQLQuery(sql).
                AddScalar("ForecastId", NHibernateUtil.Int32).
                              AddScalar("TestBasedOnProtocols", NHibernateUtil.Double).
                              AddScalar("SymptomDirectedTests", NHibernateUtil.Double).
                              AddScalar("RepeatedDuetoClinicalReq", NHibernateUtil.Double).
                                AddScalar("InvalidTestandWastage", NHibernateUtil.Double).
                              AddScalar("BufferStockandControls", NHibernateUtil.Double).
                              AddScalar("ReagentstoRunControls", NHibernateUtil.Double)
                              .SetResultTransformer(Transformers.AliasToBean(typeof(HemaandViralNumberofTest)));

            sqlQuery.SetInt32("forecastId", forecastId);

            HemaandViralNumberofTest result = (HemaandViralNumberofTest)sqlQuery.UniqueResult();

            if (result != null)
                return result;
            return null;
        }
    }
}
