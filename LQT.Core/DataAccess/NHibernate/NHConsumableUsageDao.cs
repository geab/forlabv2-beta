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

    public class NHConsumableUsageDao : NHibernateDao<ConsumableUsage>, IConsumableUsageDao
    {

        public IList<ConsumableUsage> GetAllUsageByConsumableId(int consumableid)
        {
            string hql = "from ConsumableUsage cu where cu.Consumable.Id = :cid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("cid", consumableid);

            return q.List<ConsumableUsage>();
        
        }

        public IList<ConsumableUsage> GetConsumableUsageByTestId(int testId)
        {

            string hql = "from ConsumableUsage cu where cu.MasterConsumable.Test.Id = :tid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("tid", testId);

            return q.List<ConsumableUsage>();


        }

        public IList<ConsumableUsage> GetConsumableUsage(int testAreaId, QuanifyConsumableBasedOnEnum qcbEnum)
        {
            string hql = "from ConsumableUsage cu where cu.TestingAreaId = :tid and cu.QuanifyBasedOn = :qcb";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("tid", testAreaId);
            q.SetString("qcb", qcbEnum.ToString());

            return q.List<ConsumableUsage>();
        }

        public IList<ConsumableUsage> GetConsumableUsageByTestId(int testId, QuanifyConsumableBasedOnEnum qcbEnum)
        {
            string hql = "from ConsumableUsage cu where cu.TestId = :tid and cu.QuanifyBasedOn = :qcb";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("tid", testId);
            q.SetString("qcb", qcbEnum.ToString());

            return q.List<ConsumableUsage>();
        }

        public IList<ConsumableUsage> GetConsumableUsage(int testAreaId, QuanifyConsumableBasedOnEnum qcbEnum, int insId)
        {
            string hql = "from ConsumableUsage cu where cu.TestingAreaId = :tid and cu.QuanifyBasedOn = :qcb and cu.Instrument.Id = :insid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("tid", testAreaId);
            q.SetString("qcb", qcbEnum.ToString());
            q.SetInt32("insid", insId);
            return q.List<ConsumableUsage>();
        }

    }
}
