using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{
    public class NHARTSiteDao: NHibernateDao<ARTSite>, IARTSiteDao
    {
        private ITransaction _tansaction;
        private ISession _session;
        
        public void OpenBatchTransaction()
        {
            _session = NHibernateHelper.OpenSession();
            _tansaction = _session.BeginTransaction();
        }

        public void CommitBatchTransaction()
        {
            _session.Flush();
            _tansaction.Commit();
            _session.Close();
            _session = null;
            _tansaction = null;
        }

        public void RolebackBatchTransaction()
        {
            _tansaction.Rollback();
            _session = null;
            _tansaction = null;
        }
        
        public void BatchSave(ARTSite artsite)
        {
            _session.SaveOrUpdate(artsite);
        }

        public void BatchDelete(ARTSite artsite)
        {
            _session.Delete(artsite);
        }

        public IList<ARTSite> GetAllARTSite(int forecastid)
        {
            string sql = "from ARTSite s where s.MorbidityCategory.MorbidityForecast.Id = :forecastid";

            ISession session = NHibernateHelper.OpenSession();
            IQuery q = session.CreateQuery(sql);
            q.SetInt32("forecastid", forecastid);

            return q.List<ARTSite>();
        }
    }
}
