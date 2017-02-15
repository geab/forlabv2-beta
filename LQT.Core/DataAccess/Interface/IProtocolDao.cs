using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.Util;

namespace LQT.Core.DataAccess.Interface
{
    public interface IProtocolDao: IDao<Protocol>
    {
        Protocol GetProtocolByPlatform(int Platformid);
    }
}
