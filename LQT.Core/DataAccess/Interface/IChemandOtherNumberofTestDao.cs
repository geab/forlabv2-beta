using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IChemandOtherNumberofTestDao:IDao<ChemandOtherNumberofTest>
    {
        ChemandOtherNumberofTest GetChemistryTestSummary(int forecastId);
        ChemandOtherNumberofTest GetOtherTestSummary(int forecastId);
        IList GetChemistryTestSummarys(int forecastid);
        IList GetOtherTestSummarys(int forecastid);
    }
}
