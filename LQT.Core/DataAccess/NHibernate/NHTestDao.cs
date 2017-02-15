﻿using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHTestDao : NHibernateDao<Test>, ITestDao
    {
        public IList<Test> GetAllTestsByAreaId(int areaid)
        {
            string hql = "from Test t where t.TestingArea.Id = :tid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("tid", areaid);

            return q.List<Test>();
        }

        public IList<Test> GetAllTestsByGroupId(int groupid)
        {
            string hql = "from Test t where t.TestingGroup.Id = :groupid";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("groupid", groupid);

            return q.List<Test>();
        }
    
        public Test GetTestByName(string name)
        {
            string hql = "from Test t where t.TestName = :tname";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("tname", name);

            IList<Test> result = q.List<Test>();

            if (result.Count > 0)
                return result[0];

            return null;
        }

        public Test GetTestByNameAndTestArea(string name, int areaid)
        {
            string hql = "from Test t where t.TestName = :tname and t.TestingArea.Id = :areaid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);

            q.SetString("tname", name);
            q.SetInt32("areaid", areaid);

            IList<Test> result = q.List<Test>();

            if (result.Count > 0)
                return result[0];

            return null;
        }


        public IList<Test> GetTestByPlatform(string platform)
        {
           
            string hql = "from Test t where t.TestingArea.Category = :platform";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("platform", platform);

            return q.List<Test>();
        }

        public IList GetProductUsageByInsIdAndPlatform(int instrumentid, string platform)
        {
            string currentDate = DateTime.Now.ToShortDateString();
            string sql = "SELECT p.ProductId as proId, p.Rate as rate, p.ProductUsedIn as location, t.TestingDuration as dur, t.TestType as type, ";
            sql += String.Format("(select dbo.fnGetProductPacksize(MasterProduct.ProductID,'{0}') as PackagingSize from MasterProduct where ProductId = p.ProductID) as psize, ", currentDate);
            sql += "(select MinimumPackPerSite from MasterProduct where ProductId = p.ProductID) as minsize FROM ProductUsage AS ";
            sql += "p INNER JOIN Test AS t ON p.TestId = t.TestID INNER JOIN TestingArea AS a ON t.TestingAreaID = a.TestingAreaID ";
            sql += String.Format("WHERE a.Category = '{0}' AND p.InstrumentId = {1}", platform, instrumentid);

            ISession session = NHibernateHelper.OpenSession();
            return session.CreateSQLQuery(sql)
                .AddScalar("proId", NHibernateUtil.Int32)
                .AddScalar("rate", NHibernateUtil.Decimal)
                .AddScalar("location", NHibernateUtil.String)
                .AddScalar("dur", NHibernateUtil.String)
                .AddScalar("type", NHibernateUtil.String)
                .AddScalar("psize", NHibernateUtil.Int32)
                .AddScalar("minsize", NHibernateUtil.Int32)
                .List();
        }

        public IList<int> GetListOfProductUsageByInsId(int instrumentid)
        {
            string sql = "SELECT dbo.ProductUsage.Id FROM dbo.ProductUsage ";
            sql += String.Format("WHERE (dbo.ProductUsage.InstrumentId = {0}",instrumentid);

            ISession session = NHibernateHelper.OpenSession();
            return session.CreateSQLQuery(sql)
                .AddScalar("Id", NHibernateUtil.Int32)
                .List<int>();
        }
    }
}
