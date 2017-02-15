using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHForecastCategoryInstrumentDao : NHibernateDao<ForecastCategoryInstrument>, IForecastCategoryInstrumentDao
    {
        public IList<ForecastCategoryInstrument> GetFCInstrumentByFinfoId(int fid)
        {
           
            string hql = "from ForecastCategoryInstrument p where p.ForecastId = :fid" ;

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("fid", fid);

            return q.List<ForecastCategoryInstrument>();
        }

        public ForecastCategoryInstrument GetFCInstrumentById(int id)
        {
          
            string hql = "from ForecastCategoryInstrument p where p.Id = :id";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("id", id);
            object obj = q.UniqueResult();
            if (obj != null)
                return (ForecastCategoryInstrument)obj;
            return null;
        }






        public ForecastCategoryInstrument GetFCInstrumentByInstrumentId(int iid)
        {

            string hql = "from ForecastCategoryInstrument p where pInstrument.Id = :iid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetInt32("iid", iid);
            object obj = q.UniqueResult();
            if (obj != null)
                return (ForecastCategoryInstrument)obj;
            return null;
        }
    }
}
