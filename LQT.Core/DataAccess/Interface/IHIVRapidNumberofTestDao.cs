using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IHIVRapidNumberofTestDao:IDao<HIVRapidNumberofTest>
    {
        HIVRapidNumberofTest GetHIVRapidNumberofTestSummary(int forecastId);
    }
}
