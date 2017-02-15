using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface 
{
    public interface IForecastedResultDao: IDao<ForecastedResult>
    {
        void OpenBatchTransaction();
        void CommitBatchTransaction();
        void RolebackBatchTransaction();
        void BatchSave(ForecastedResult fr);
        void BatchDelete(ForecastedResult fr);
        void DeleteAllFResult(int finfoid);
        IList GetBeyondMaxTPutResult(int finfoid, int monthinperiod);

        IList<MAPEResult> GetSiteMAPEByTest(int fid, int fsid, int tid);
        IList<MAPEResult> GetSiteMAPEByProduct(int fid, int fsid, int pid);
        IList<MAPEResult> GetCategoryMAPEByProduct(int fid, int cid, int pid);
        IList<MAPEResult> GetCategoryMAPEByTest(int fid, int cid, int tid);
        IList<MAPEResult> GetMAPESummaryByProduct(int fid);
        IList<MAPEResult> GetMAPESummaryByTest(int fid);

        IList GetUniqueFType(int ForecastId, int ProductType);
    }
}
