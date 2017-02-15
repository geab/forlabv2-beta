using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface ITestingGroupDao : IDao<TestingGroup>
    {
        TestingGroup GetTestingGroupByName(int areaid, string name);
    }
}
