using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHQuantifyMenuDao : NHibernateDao<QuantifyMenu>, IQuantifyMenuDao
    {       
       
        public IList<QuantifyMenu> GetAllQuantifyMenuByClass(string classofTest)
        {
            string hql = "from QuantifyMenu m where m.ClassOfTest = :ctest";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("ctest", classofTest);

            return q.List<QuantifyMenu>();
        }
        
        public IList<QuantifyMenu> GetGeneralQuantifyMenuByClass(string classofTest)
        {
            string hql = "from QuantifyMenu m where m.ClassOfTest = :ctest and m.TestType = :ttype";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("ctest", classofTest);
            q.SetString("ttype", TestTypeEnum.General.ToString());

            return q.List<QuantifyMenu>();
        }
        public IList<QuantifyMenu> GetAllGeneralQuantifyMenus()
        {
            string hql = "from QuantifyMenu m where m.TestType = :ttype";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("ttype", TestTypeEnum.General.ToString());

            return q.List<QuantifyMenu>();
        }
        public IList<QuantifyMenu> GetAllQuantifyMenuByInstrument(int instrumentId)
        {
            string hql = "from QuantifyMenu m where m.InstrumentId = :instid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("instid", instrumentId);

            return q.List<QuantifyMenu>();
        }

        public QuantifyMenu GetQuantifyMenuByProductId(int productId)
        {
            string hql = "from QuantifyMenu m where m.ProductId = :proid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("proid", productId);

            return q.UniqueResult<QuantifyMenu>();
        }

    }
}
