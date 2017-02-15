using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LQT.GUI.MorbidityCalculation
{
    public class QMenuWithValue
    {
        public int QuantifyMenuId { get; set; }
        public double SiteValue { get; set; }
        public double ReferalSiteValue { get; set; }
        public double TotalValue
        {
            get { return SiteValue + ReferalSiteValue; }
        }

    }
}
