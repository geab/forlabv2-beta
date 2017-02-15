using System;
using System.Collections.Generic;
using LQT.Core.Domain;


namespace LQT.Core.DataAccess.Interface
{
    public interface IRapidTestSpecDao: IDao<RapidTestSpec>
    {
        IList<RapidTestSpec> GetRapidTestSpecByTestGroup(string testgroup);
    }
}
