using System;
using System.Collections;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface ITestDao : IDao<Test>
    {
        IList<Test> GetAllTestsByAreaId(int areaid);
        IList<Test> GetAllTestsByGroupId(int groupid);
        Test GetTestByName(string name);
        Test GetTestByNameAndTestArea(string name, int areaid);
        IList<Test> GetTestByPlatform(string platform);
        IList GetProductUsageByInsIdAndPlatform(int instrumentid, string platform);
    }
}
