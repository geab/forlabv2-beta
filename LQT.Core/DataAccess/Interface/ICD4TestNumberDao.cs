using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LQT.Core.Domain;

namespace LQT.Core.DataAccess.Interface
{
    public interface ICD4TestNumberDao: IDao<CD4TestNumber>
    {
        CD4TestNumber GetCD4TestNumberSummary(int forecastId);
    }
}
