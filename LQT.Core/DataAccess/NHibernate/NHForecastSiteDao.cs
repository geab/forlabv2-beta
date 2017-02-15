using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;
using System.Collections;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHForecastSiteDao : NHibernateDao<ForecastSite>, IForecastSiteDao
    {
        public IList<ForlabSite> GetFSite(int fid)
        {

            string sql = string.Format("SELECT * FROM Site INNER JOIN ForecastSite ON ForecastSite.SiteId =Site.SiteID" 
                        +" WHERE (dbo.ForecastSite.ForecastInfoId ={0})",fid);

            ISession session = NHibernateHelper.OpenSession();
            IList result = session.CreateSQLQuery(sql).
                              AddScalar("SiteID", NHibernateUtil.Int32).List();

            IList<ForlabSite> Sites = new List<ForlabSite>();
            foreach (int i in result)
            {
                ForlabSite s = DataRepository.GetSiteById(i);
                Sites.Add(s);
            }

            return Sites;

           
        }

    }
}
