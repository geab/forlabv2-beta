using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IMorbidityTestDao : IDao<MorbidityTest>
    {
        IList<MorbidityTest> GetAllMorbidityTestByClass(string classofTest);
    }
}
