using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IHemaandViralNumberofTestDao : IDao<HemaandViralNumberofTest>
    {
        HemaandViralNumberofTest GetHematologyTestNumberSummary(int forecastId);
        HemaandViralNumberofTest GetViralLoadTestNumberSummary(int forecastId);
    }
}
