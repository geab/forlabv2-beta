using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForlabSiteDao : IDao<ForlabSite>
    {
        IList<ForlabSite> GetAllSiteByRegionId(int regionid);
        ForlabSite GetSiteByName(string sname, int regionid);

        IList<ForlabSite> GetReferingSiteByPlatform(string platform);
        IList<ForlabSite> GetReferingSiteByPlatform(int siteId, int platform);
        bool GetRefSiteBySiteId(int siteId, string platform);
        IList<ForlabSite> GetAllSiteByRegionandPlatform(int regionid, string platform);
        void deleteReferingSite(int siteId, string platform);

        ForlabSite GetSiteByName(string sname);
        IList<int> GetListOfReferedSites(int siteId, string platform);
        IList<int> GetListOfSiteInstruments(int instId);
    }
}
