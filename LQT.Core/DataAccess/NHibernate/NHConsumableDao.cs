using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;
using NHibernate.Transform;
using System.Collections;

namespace LQT.Core.DataAccess.NHibernate
{
   
   public class NHConsumableDao : NHibernateDao<MasterConsumable>, IConsumableDao
    {
       
        public MasterConsumable GetConsumableById(int consId)
        {
            string hql = "from MasterConsumable c where c.Id = :cId";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("cId", consId);
            object obj = q.UniqueResult();
            if (obj != null)
                return (MasterConsumable)obj;
            return null;
        }

        public MasterConsumable GetConsumableByTestandArea(int testId, int testingAreaId)
        {
            string hql = "from MasterConsumable c where c.Test.Id = :tId and c.TestingArea.Id = :taId";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("tId", testId);
            q.SetInt32("taId", testingAreaId);
            object obj = q.UniqueResult();
            if (obj != null)
                return (MasterConsumable)obj;
            return null;
        }
        public IList<int> GetListOfConsumableUsageByInst(int instrumentid)
        {
            string sql = string.Format("SELECT Id FROM dbo.ConsumableUsage where dbo.ConsumableUsage.InstrumentId = {0}", instrumentid);

            ISession session = NHibernateHelper.OpenSession();
            return session.CreateSQLQuery(sql)
                .AddScalar("Id", NHibernateUtil.Int32)
                .List<int>();
        }
        public MasterConsumable GetConsumableByName(string name)
        {
            string hql = "from MasterConsumable c where c.Test.TestName = :tname";
            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("tname", name);
            object obj = q.UniqueResult();
            if (obj != null)
                return (MasterConsumable)obj;
            return null;

        }
    }
}
