using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;
using System.Collections;


namespace LQT.Core.DataAccess.NHibernate
{
    public class NHForecastCategoryDao : NHibernateDao<ForecastCategory>, IForecastCategoryDao
    {
        public ForecastCategory GetForecastCategoryByName(int fcastid, string cname)
        {
            string hql = "from ForecastCategory c where c.ForecastInfo.Id = :fcastid and c.CategoryName = :cname";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(hql);
            q.SetString("cname", cname);
            q.SetInt32("fcastid", fcastid);

            IList<ForecastCategory> result = q.List<ForecastCategory>();

            if (result.Count > 0)
                return result[0];

            return null;
        }

        public IList<ForecastCategory> GetFCategory(int fid)
        {
            //string hql = "from ForecastCategory c where c.ForecastInfo.Id = :fid ";

            //ISession session = NHibernateHelper.OpenSession();
            //IQuery q = session.CreateQuery(hql);
            //q.SetInt32("fid", fid);

            //IList<ForecastCategory> result = q.List<ForecastCategory>();

            //if (result.Count > 0)
            //    return result;

            //return null;



            string sql = string.Format("SELECT * FROM ForecastCategory INNER JOIN ForecastInfo ON ForecastCategory.ForecastId =ForecastInfo.ForecastID"
                    + " WHERE (dbo.ForecastCategory.ForecastId ={0})", fid);

            ISession session = NHibernateHelper.OpenSession();
            IList result = session.CreateSQLQuery(sql).
                              AddScalar("CategoryId", NHibernateUtil.Int32).List();

            IList<ForecastCategory> cat = new List<ForecastCategory>();
            foreach (int i in result)
            {
                ForecastCategory c = DataRepository.GetForecastCategoryById(i);
                cat.Add(c);
            }

            return cat;
        }
        
    }
}
