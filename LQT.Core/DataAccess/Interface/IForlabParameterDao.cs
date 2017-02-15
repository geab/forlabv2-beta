using System;
using System.Collections.Generic;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface IForlabParameterDao : IDao<ForlabParameter>
    {
        ForlabParameter GetForlabParameterByParamName(string pname);        
    }
}
