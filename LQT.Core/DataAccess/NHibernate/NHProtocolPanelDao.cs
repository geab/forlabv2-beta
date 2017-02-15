using System;
using System.Collections.Generic;
using LQT.Core.Domain;
using LQT.Core.DataAccess.Interface;
using LQT.Core.Util;

using NHibernate;

namespace LQT.Core.DataAccess.NHibernate
{
 
    public class NHProtocolPanelDao : NHibernateDao<ProtocolPanel>, IProtocolPanelDao
    {
    }
}
