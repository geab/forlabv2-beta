using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IARTSiteDao : IDao<ARTSite>
    {
        IList<ARTSite> GetAllARTSite(int forecastid);
        void OpenBatchTransaction();
        void CommitBatchTransaction();
        void RolebackBatchTransaction();
        void BatchSave(ARTSite artsite);
        void BatchDelete(ARTSite artsite);
    }
}
