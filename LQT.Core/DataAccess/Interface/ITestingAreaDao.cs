using System;
using System.Collections.Generic;
using LQT.Core.Domain;


namespace LQT.Core.DataAccess.Interface
{
    public interface ITestingAreaDao :IDao<TestingArea>
    {
        TestingArea GetTestingAreaByName(string name);
        IList<TestingArea> GetTestingAreaByDemography(Boolean inDemo);
        IList<Instrument> GetDistinctInstrumentByCategory(string category);

        TestingArea GetTestingAreaByClassOfMorbidity(string category);
    }
}
